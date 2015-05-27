Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Drawing.Text

Public Class CPNFStroke

    Const BRUSH_SAMPLING_CNT = 3
    Structure StrokeStruct
        Dim pt As PointF
        Dim press As Integer
    End Structure

    Public m_ItemList As New ArrayList

    Public m_PenStyle As Integer

    Dim m_ptStart As PointF
    Dim m_ptEnd As PointF

    Function Count() As Integer
        Return m_ItemList.Count
    End Function


    Sub New()

    End Sub
    Sub InsertItem(ByVal idx As Integer, ByVal pt As PointF, ByVal prs As Integer)
        Dim item As StrokeStruct
        item.pt = pt
        item.press = prs
        m_ItemList.Insert(idx, item)

    End Sub

    Sub AddLastItem(ByVal prs As Integer)
        Dim item As StrokeStruct
        item.press = prs
        item.pt = CType(m_ItemList(m_ItemList.Count - 1), StrokeStruct).pt
        AddItem(item)
    End Sub
    Sub AddItem(ByVal pt As PointF, ByVal prs As Integer)
        Dim item As StrokeStruct
        item.pt = pt
        item.press = prs
        AddItem(item)
    End Sub
    Sub AddItem(ByVal item As StrokeStruct)
        m_ItemList.Add(item)
    End Sub


    Public Sub GetItem(ByVal Idx As Integer, ByRef pt As PointF, ByRef press As Integer)
        Dim sts As StrokeStruct = m_ItemList.Item(Idx)
        pt = sts.pt
        press = sts.press
    End Sub
    Public Function GetItemPoint(ByVal Idx As Integer) As PointF
        Dim sts As StrokeStruct = m_ItemList.Item(Idx)
        Return sts.pt
    End Function
    Public Function GetStrokeItem(ByVal pt As PointF, ByVal press As Integer) As StrokeStruct
        Dim sts As StrokeStruct
        sts.pt = pt
        sts.press = press
        Return sts
    End Function

   



    Function DrawLastQuard(ByVal g As Graphics, ByVal pn As Pen, ByVal nLastIdx As Integer) As RectangleF

        Dim c As Integer
        If nLastIdx < 0 Then
            c = m_ItemList.Count() - 1
        Else
            c = nLastIdx + 1
        End If



        '        Console.WriteLine("c=" + c.ToString)
        '       Console.WriteLine("m_item=" + m_ItemList.Count.ToString)

        Dim previousPoint1 As PointF
        Dim previousPoint2 As PointF
        Dim previousPoint3 As PointF


        Dim currentPoint As PointF

        Dim ps As StrokeStruct
        If c = 1 Then
            ps = m_ItemList.Item(0)
            currentPoint = ps.pt
            previousPoint1 = currentPoint
            previousPoint2 = currentPoint
            previousPoint3 = currentPoint
        ElseIf c = 2 Then
            ps = m_ItemList.Item(1)
            currentPoint = ps.pt
            ps = m_ItemList.Item(0)
            previousPoint1 = ps.pt
            previousPoint2 = previousPoint1
            previousPoint3 = previousPoint2
        ElseIf c = 3 Then
            ps = m_ItemList.Item(2)
            currentPoint = ps.pt
            ps = m_ItemList.Item(1)
            previousPoint1 = ps.pt
            ps = m_ItemList.Item(0)
            previousPoint2 = ps.pt
            previousPoint3 = previousPoint2
        Else
            ps = m_ItemList.Item(c - 1)
            currentPoint = ps.pt

            ps = m_ItemList.Item(c - 2)
            previousPoint1 = ps.pt
            ps = m_ItemList.Item(c - 3)
            previousPoint2 = ps.pt
            ps = m_ItemList.Item(c - 4)
            previousPoint3 = ps.pt

        End If

        Dim mid1 As PointF = GetMidPoint(previousPoint2, previousPoint3)
        Dim mid2 As PointF = GetMidPoint(previousPoint1, currentPoint)
        Dim ctrl1X As Double
        Dim ctrl1Y As Double
        Dim ctrl2X As Double
        Dim ctrl2Y As Double

        GetBezierPoints(previousPoint3.X, previousPoint2.X, previousPoint1.X, currentPoint.X, _
                        previousPoint3.Y, previousPoint2.Y, previousPoint1.Y, currentPoint.Y, _
                        ctrl1X, ctrl2X, ctrl1Y, ctrl2Y)

        Dim ppath As New Drawing2D.GraphicsPath

        ppath.AddBezier(mid1, New PointF(ctrl1X, ctrl1Y), New PointF(ctrl2X, ctrl2Y), mid2)
        '      Console.WriteLine("drawing...")

        g.DrawPath(pn, ppath)

        Dim clipRect As RectangleF = ppath.GetBounds
        clipRect.Inflate(pn.Width, pn.Width)

        Return clipRect


    End Function


    Function DrawBezierQuard(ByVal g As Graphics, ByVal pn As Pen, ByVal pt1 As PointF, ByVal pt2 As PointF, ByVal pt3 As PointF, ByVal pt4 As PointF) As PointF
        Dim currentPoint, previousPoint1, previousPoint2, previousPoint3 As PointF

        If pt1 <> Nothing And pt2 <> Nothing And pt3 <> Nothing And pt4 <> Nothing Then
            currentPoint = pt1
            previousPoint1 = pt2
            previousPoint2 = pt3
            previousPoint3 = pt4
        ElseIf pt1 <> Nothing And pt2 <> Nothing And pt3 <> Nothing And pt4 = Nothing Then
            currentPoint = pt1
            previousPoint1 = pt2
            previousPoint2 = pt3
            previousPoint3 = pt3

        ElseIf pt1 <> Nothing And pt2 <> Nothing And pt3 = Nothing And pt4 = Nothing Then
            currentPoint = pt1
            previousPoint1 = pt2
            previousPoint2 = pt2
            previousPoint3 = pt2
        ElseIf pt1 <> Nothing And pt2 = Nothing And pt3 = Nothing And pt4 = Nothing Then
            currentPoint = pt1
            previousPoint1 = pt1
            previousPoint2 = pt1
            previousPoint3 = pt1

        ElseIf pt1 = Nothing And pt2 = Nothing And pt3 = Nothing And pt4 = Nothing Then
            Return Nothing
        End If


        Dim mid1 As PointF = GetMidPoint(previousPoint2, previousPoint3)
        Dim mid2 As PointF = GetMidPoint(previousPoint1, currentPoint)
        Dim ctrl1X As Double
        Dim ctrl1Y As Double
        Dim ctrl2X As Double
        Dim ctrl2Y As Double

        GetBezierPoints(previousPoint3.X, previousPoint2.X, previousPoint1.X, currentPoint.X, _
                        previousPoint3.Y, previousPoint2.Y, previousPoint1.Y, currentPoint.Y, _
                        ctrl1X, ctrl2X, ctrl1Y, ctrl2Y)

        Try
            g.DrawBezier(pn, mid1, New PointF(ctrl1X, ctrl1Y), New PointF(ctrl2X, ctrl2Y), mid2)
        Catch memExp As OutOfMemoryException
            Try
                pn.Width = 1
                g.DrawBezier(pn, mid1, New PointF(ctrl1X, ctrl1Y), New PointF(ctrl2X, ctrl2Y), mid2)
            Catch mmexp As OutOfMemoryException
            End Try
        End Try

        Return mid2
    End Function


    

    Sub DrawBrushBySpeed(ByVal g As Graphics, ByVal pn As Pen, ByVal previousPoint1 As PointF, ByVal currentPoint As PointF)



        Static TSave As Double
        Static thicksave1 As Single
        Static thicksave2 As Single


        Dim cX, cY As Single

        cX = 0
        cY = 0




        Dim pn2 As Pen = pn.Clone

        Dim thick_ As Single = GetLenBetPoints(previousPoint1, currentPoint)
        thick_ = (thicksave1 + thicksave2 + thick_) / 3

        Dim T As Double = GetBrushThick(thick_, pn2.Width)
        '        Console.WriteLine("T=" + T.ToString + " W=" + pn2.Width.ToString + " D=" + thick_.ToString)


        Dim iterCnt As Integer

        If thick_ > 20 Then
            iterCnt = 30
        ElseIf thick_ > 10 Then
            iterCnt = 10
        ElseIf thick_ > 2 Then
            iterCnt = 4
        Else
            iterCnt = 2
        End If

        Dim r As Double
        Dim deltaX As Double = (currentPoint.X - previousPoint1.X) / iterCnt
        Dim deltaY As Double = (currentPoint.Y - previousPoint1.Y) / iterCnt
        Dim deltaT As Double = (T - TSave) / iterCnt
        Dim SX As Single
        Dim SY As Single

        Dim EX As Single
        Dim EY As Single

        For i As Integer = 1 To iterCnt
            r = TSave + i * deltaT
            pn2.Width = r
            SX = previousPoint1.X + (i - 1) * deltaX
            SY = previousPoint1.Y + (i - 1) * deltaY

            EX = previousPoint1.X + i * deltaX
            EY = previousPoint1.Y + i * deltaY


            g.DrawLine(pn2, SX, SY, EX, EY)

        Next



        TSave = T
        thicksave2 = thicksave1
        thicksave1 = thick_


    End Sub


    Sub DrawBrushByPenPressure(ByVal g As Graphics, ByVal pn As Pen, ByVal nLastIdx As Integer)
        Dim TSave As Single
        Dim TCurrent As Single
        Dim previousPoint2 As PointF
        Dim previousPoint1 As PointF
        Dim currentPoint As PointF
        Dim sts As StrokeStruct

        If nLastIdx = -1 Then
            nLastIdx = m_ItemList.Count - 1
        Else

        End If

        If nLastIdx < 2 Then
            Return
        End If

        sts = m_ItemList.Item(nLastIdx - 1)

        Dim thick_ As Single = sts.press
        Dim pn2 As Pen = pn.Clone
        If pn2.Width >= 1 Then
            TSave = Me.GetBrushThick(thick_, pn2.Width)
        Else
            TSave = Me.GetBrushThick(thick_, 2)
        End If

        sts = m_ItemList.Item(nLastIdx)
        thick_ = sts.press
        If pn2.Width >= 1 Then
            TCurrent = GetBrushThick(thick_, pn2.Width)
        Else
            TCurrent = GetBrushThick(thick_, 2)
        End If

        sts = m_ItemList.Item(nLastIdx)
        currentPoint = sts.pt
        sts = m_ItemList.Item(nLastIdx - 1)
        previousPoint1 = sts.pt
        sts = m_ItemList.Item(nLastIdx - 2)
        previousPoint2 = sts.pt

        Dim origin As PointF
        Dim destination As PointF
        Dim control As PointF


        origin = GetMidPoint(previousPoint2, previousPoint1)
        destination = GetMidPoint(previousPoint1, currentPoint)
        control = previousPoint1

        Dim length As Integer = Math.Abs(origin.X - destination.X) + Math.Abs(origin.Y - destination.Y)

        Dim iterCnt As Integer
        Dim deltaT2 = Math.Abs(TCurrent - TSave)
        If length > 20 Then
            iterCnt = 20
        ElseIf length > 10 Then
            iterCnt = 12
        ElseIf length > 4 Then
            If deltaT2 > 3.0 Then
                iterCnt = 20
            ElseIf deltaT2 > 2.0 Then
                iterCnt = 12
            Else
                iterCnt = 8
            End If
        ElseIf length > 2 Then
            iterCnt = 4
        Else
            iterCnt = 1
        End If

        '        iterCnt = iterCnt * 2

        Dim r As Single = 0
        Dim deltaT As Single = (TCurrent - TSave) / iterCnt
        Dim SX, SY, EX, EY As Single
        Dim t As Single = 0.0
        SX = origin.X
        SY = origin.Y

        Dim inc As Single = 1.0 / iterCnt

        For i As Integer = 1 To iterCnt Step 1
            t += inc
            EX = Math.Pow(1 - t, 2) * origin.X + 2.0 * (1 - t) * t * control.X + t * t * destination.X
            EY = Math.Pow(1 - t, 2) * origin.Y + 2.0 * (1 - t) * t * control.Y + t * t * destination.Y
            r = TSave + i * deltaT

            pn2.Width = r
            'Console.WriteLine("bpen - {0} / count - {1}", r, i)
            g.DrawLine(pn2, SX, SY, EX, EY)

            SX = EX
            SY = EY
        Next

    End Sub

  

    Function GetBrushThick(ByVal dist As Double, ByVal nThick As Integer) As Double

        Dim minT As Single = 0.1
        Dim maxT As Single = 1.8
        Dim minD As Single = 50
        Dim maxD As Single = 700
        Dim ret As Single

        If nThick > 3 Then
            maxT = 1
            minT = 0.01
        End If

        If dist < minD Then
            ret = minT
        ElseIf dist > maxD Then
            ret = maxT
        Else
            Dim r As Single = (maxT - minT) / (maxD - minD)
            ret = r * dist + minT - r * minD
        End If



        'ret = (maxT + minT) - ret ' for reverse type
        
        Return nThick * ret



    End Function


    Function GetInfo() As String
        Dim sz As String = ""
        Dim i As Integer = 0
        For Each st As StrokeStruct In m_ItemList
            sz += i.ToString + " " + st.pt.ToString + " " + st.press.ToString
            i += 1

        Next
        Return sz
    End Function
    Function GetMidPoint(ByVal pt1 As PointF, ByVal pt2 As PointF) As PointF
        Return New PointF((pt1.X + pt2.X) / 2, (pt1.Y + pt2.Y) / 2)

    End Function
   


    Sub GetBezierPoints(ByVal x0 As Double, ByVal x1 As Double, ByVal x2 As Double, ByVal x3 As Double, ByVal y0 As Double, _
                    ByVal y1 As Double, ByVal y2 As Double, ByVal y3 As Double, _
              ByRef ctrl1_x As Double, ByRef ctrl2_x As Double, ByRef ctrl1_y As Double, ByRef ctrl2_y As Double)

        '// Assume we need to calculate the control
        '// points between (x1,y1) and (x2,y2).
        '// Then x0,y0 - the previous vertex,
        '//      x3,y3 - the next one.

        Dim xc1 As Double = (x0 + x1) / 2.0

        Dim yc1 As Double = (y0 + y1) / 2.0
        Dim xc2 As Double = (x1 + x2) / 2.0
        Dim yc2 As Double = (y1 + y2) / 2.0
        Dim xc3 As Double = (x2 + x3) / 2.0
        Dim yc3 As Double = (y2 + y3) / 2.0

        Dim len1 As Double = Math.Sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0))
        Dim len2 As Double = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))
        Dim len3 As Double = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2))
        Dim k1 As Double
        If len1 + len2 > 0 Then
            k1 = len1 / (len1 + len2)
        Else
            k1 = 0
        End If

        Dim k2 As Double
        If (len2 + len3) > 0 Then
            k2 = len2 / (len2 + len3)
        Else
            k2 = 0
        End If


        Dim xm1 As Double = xc1 + (xc2 - xc1) * k1
        Dim ym1 As Double = yc1 + (yc2 - yc1) * k1

        Dim xm2 As Double = xc2 + (xc3 - xc2) * k2
        Dim ym2 As Double = yc2 + (yc3 - yc2) * k2

        Dim smooth_value As Double = 0.2
        '// Resulting control points. Here smooth_value is mentioned
        '// above coefficient K whose value should be in range [0...1].
        ctrl1_x = xm1 + (xc2 - xm1) * smooth_value + x1 - xm1
        ctrl1_y = ym1 + (yc2 - ym1) * smooth_value + y1 - ym1

        ctrl2_x = xm2 + (xc2 - xm2) * smooth_value + x2 - xm2
        ctrl2_y = ym2 + (yc2 - ym2) * smooth_value + y2 - ym2

    End Sub


    Public Sub SetMinMaXPt(ByRef minPt As PointF, ByRef maxPt As PointF)
        Dim MinX, MaxX, MInY, MaxY As Double
        MinX = 999999
        MaxX = 0
        MInY = 999999
        MaxY = 0

        'For Each st As Stroke In e.Strokes
        '        Dim st As Stroke = myInk.Ink.Strokes(myInk.Ink.Strokes.Count - 1)
        For Each sts As StrokeStruct In m_ItemList
            If MinX > sts.pt.X Then MinX = sts.pt.X
            If MaxX < sts.pt.X Then MaxX = sts.pt.X
            If MInY > sts.pt.Y Then MInY = sts.pt.Y
            If MaxY < sts.pt.Y Then MaxY = sts.pt.Y

        Next
        'Next

        minPt.X = MinX
        minPt.Y = MInY
        maxPt.X = MaxX
        maxPt.Y = MaxY

        m_ptStart.X = MinX
        m_ptStart.Y = MInY
        m_ptEnd.X = MaxX
        m_ptEnd.Y = MaxY


    End Sub

   


    Function GetBezierPoint(ByVal t As Single, ByVal P0 As PointF, ByVal P1 As PointF, ByVal P2 As PointF, ByVal P3 As PointF) As PointF
        Dim Pt As PointF

        Pt.X = (1.0 - t) * (1.0 - t) * (1.0 - t) * P0.X + 3.0 * (1.0 - t) * (1.0 - t) * t * P1.X + 3.0 * (1.0 - t) * t * t * P2.X + t * t * t * P3.X
        Pt.Y = (1.0 - t) * (1.0 - t) * (1.0 - t) * P0.Y + 3.0 * (1.0 - t) * (1.0 - t) * t * P1.Y + 3.0 * (1.0 - t) * t * t * P2.Y + t * t * t * P3.Y


        Return Pt
    End Function

    Public Function GetLenBetPoints(ByVal pt1 As PointF, ByVal pt2 As PointF)
        Return Math.Sqrt((pt1.X - pt2.X) * (pt1.X - pt2.X) + (pt1.Y - pt2.Y) * (pt1.Y - pt2.Y))
    End Function

End Class
