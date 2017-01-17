Imports System.Runtime.InteropServices
Imports System.Drawing.Text

Public Class frmCalibration2
    Public m_bkImg As Image

    Public bDisconnect As Boolean = False
    Dim m_bDrag As Boolean = False
    Dim m_ptOld As Point
    Enum StatusNum
        BeforeFirstPoint
        FirstPoint
        SecondPoint
        EndPoint
    End Enum
    Enum AlignNum
        TOPLEFT
        RIGHTBOTTOM
        CENTER
    End Enum
    Enum PenCalibrationSatus
        CAL_TOP = 0
        CAL_BOTTOM
        CAL_END
    End Enum
    Private m_nStatus As StatusNum
    Class ImgNum

        Public align As AlignNum
        Public pt As Point
        Const r As Integer = 20
        Const tk As Integer = 2

        Function Rect() As Rectangle
            Return New Rectangle(pt.X - r, pt.Y - r, 2 * r, 2 * r)
        End Function
        Function CenterPoint() As Point
            Return pt
        End Function
        Sub Draw(gr As Graphics, bGuide As Boolean)
            Dim crSelect As Color = Color.Blue
            Dim crGuide As Color = Color.Gray


            Dim selPen As Pen

            If bGuide Then
                selPen = New Pen(crGuide, tk)
            Else
                selPen = New Pen(crSelect, tk)
            End If
            gr.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            gr.DrawEllipse(selPen, New Rectangle(pt.X - r, pt.Y - r, 2 * r, 2 * r))
            gr.DrawLine(selPen, New Point(pt.X - r, pt.Y), New Point(pt.X + r, pt.Y))
            gr.DrawLine(selPen, New Point(pt.X, pt.Y - r), New Point(pt.X, pt.Y + r))
            If bGuide Then
            Else
                Dim tPoint As Point
                'Dim s As String = "원하는 위치로 포인트를 드래그하고," + vbCrLf + " 종이위에 일치하는 점을 펜으로 찍어 주세요."
                Dim s As String = "drag the point where you want to put, dot where it shows on the paper"
                Dim ft As New Font("Arial", 10)

                gr.TextRenderingHint = TextRenderingHint.AntiAlias
                '텍스트의 경우는 그릴때 영역이 정해진다.
                Dim wF As SizeF = gr.MeasureString(s, ft)
                If wF.Width + pt.X + r + 2 > gr.VisibleClipBounds.Width Then
                    tPoint.X = pt.X - r - wF.Width - 2
                Else
                    tPoint.X = pt.X + r + 2
                End If
                tPoint.Y = pt.Y
                Dim tRect As Rectangle = New Rectangle(tPoint, Drawing.Size.Round(wF))
                gr.FillRectangle(Brushes.AliceBlue, tRect)
                gr.DrawRectangle(Pens.Blue, tRect)
                gr.DrawString(s, ft, Brushes.Black, tPoint)

            End If



        End Sub
    End Class
    Dim imgNum1 As New ImgNum()
    Dim imgNum2 As New ImgNum()
    Dim selNum As ImgNum = Nothing
    Public m_CaliTop As Point
    Public m_CaliBottom As Point
    Public m_RectSource As Rectangle
    Public Function GetTargetRect() As Rectangle
        Return New Rectangle(imgNum1.pt.X, imgNum1.pt.Y, imgNum2.pt.X - imgNum1.pt.X, imgNum2.pt.Y - imgNum1.pt.Y)
    End Function
    Private Sub frmCalibration2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rectD As RectangleF = GetWorkingMonitorRect(Me.Handle)


#If 0 Then
        Me.Height = rectD.Height - 10
        Me.Width = (Me.ClientRectangle.Height - ToolStrip1.Height - 1) * m_RectSource.Width / m_RectSource.Height
        picMain.Width = Me.ClientRectangle.Width
        picMain.Left = 0
        picMain.Height = Me.ClientRectangle.Height - ToolStrip1.Height - 1
        picMain.Top = ToolStrip1.Height + 1
        picMain.BackgroundImage = m_bkImg
        picMain.BackgroundImageLayout = ImageLayout.Stretch
#Else
        Me.Height = rectD.Height
        Dim gap As Integer = Me.Width - Me.ClientRectangle.Width

        Me.Width = gap + Me.ClientRectangle.Height * m_RectSource.Width / m_RectSource.Height
        picMain.Width = Me.ClientRectangle.Width
        picMain.Left = 0
        picMain.Height = Me.ClientRectangle.Height
        picMain.Top = 0
        picMain.BackgroundImage = m_bkImg
        picMain.BackgroundImageLayout = ImageLayout.Stretch

#End If
        Const initMargin As Integer = 100
        imgNum1.pt = New Point(initMargin, initMargin)

        imgNum2.pt = New Point(picMain.Width - initMargin, picMain.Height - initMargin)

        Me.Text = "This is the feature for when you use the Smartpen on the printed image from App. This calibration will help you to match precisely with what you write on printed image and what you see on the app. "
        Console.WriteLine("m_RectSource={0} picmain={1} me.w={2} me.h={3} clientrect={4}", m_RectSource, picMain.ClientRectangle, Me.Width, Me.Height, Me.ClientRectangle)
    End Sub

    Private Sub picMain_MouseDown(sender As Object, e As MouseEventArgs) Handles picMain.MouseDown
        If imgNum1.Rect.Contains(e.Location) Then
            selNum = imgNum1
            m_ptOld = e.Location
        ElseIf imgNum2.Rect.Contains(e.Location) Then
            selNum = imgNum2
            m_ptOld = e.Location
        Else
            selNum = Nothing
        End If

    End Sub


    Private Sub picMain_MouseMove(sender As Object, e As MouseEventArgs) Handles picMain.MouseMove
        If selNum IsNot Nothing Then
            selNum.pt.X += e.Location.X - m_ptOld.X
            selNum.pt.Y += e.Location.Y - m_ptOld.Y
            m_ptOld = e.Location
            picMain.Invalidate()
            'Console.WriteLine("picMain_MouseMove selNum.pt={0}", selNum.pt)
        Else
            If imgNum1.Rect.Contains(e.Location) Then
                picMain.Cursor = Cursors.Hand
            ElseIf imgNum2.Rect.Contains(e.Location) Then
                picMain.Cursor = Cursors.Hand
            Else
                picMain.Cursor = Cursors.Arrow
            End If

        End If
    End Sub

    Private Sub picMain_MouseUp(sender As Object, e As MouseEventArgs) Handles picMain.MouseUp
        selNum = Nothing
    End Sub

    Private Sub picMain_Paint(sender As Object, e As PaintEventArgs) Handles picMain.Paint
        Select Case m_nStatus
            Case StatusNum.BeforeFirstPoint
                imgNum1.Draw(e.Graphics, False)
                imgNum2.Draw(e.Graphics, True)
            Case StatusNum.FirstPoint
                imgNum2.Draw(e.Graphics, False)
            Case StatusNum.SecondPoint
            Case StatusNum.EndPoint

        End Select
    End Sub


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_RETURNMESSAGE

                Dim m_pRec As _pen_rec = Marshal.PtrToStructure(m.WParam, New _pen_rec().GetType) 'IntPtr을 구조체형으로 변환

                If m_pRec.PenStatus = PenStatus.PEN_UP Then
                    Select Case m_nStatus
                        Case StatusNum.BeforeFirstPoint
                            If m_pRec.X = 0 Or m_pRec.Y = 0 Then Exit Sub


                            m_nStatus = StatusNum.FirstPoint
                            m_CaliTop = New System.Drawing.Point(m_pRec.X, m_pRec.Y)
                            Console.WriteLine("BeforeFirstPoint TOP.x={0} Top.y={1} Bottom.x={2} Bottom.y={3}", m_CaliTop.X, m_CaliTop.Y, m_CaliBottom.X, m_CaliBottom.Y)
                            picMain.Invalidate()
                        Case StatusNum.FirstPoint


                            Dim ret As Boolean = True

                            m_CaliBottom = New System.Drawing.Point(m_pRec.X, m_pRec.Y)


                            Console.WriteLine("FirstPoint TOP.x={0} Top.y={1} Bottom.x={2} Bottom.y={3}", m_CaliTop.X, m_CaliTop.Y, m_CaliBottom.X, m_CaliBottom.Y)
                            If Math.Abs(m_CaliBottom.X - m_CaliTop.X) < 300 Or Math.Abs(m_CaliBottom.Y - m_CaliTop.Y) < 300 Then
                                ret = False
                            End If
                            If m_CaliBottom.X < m_CaliTop.X Or m_CaliBottom.Y < m_CaliTop.Y Then
                                ret = False
                            End If
                            If ret = True Then
                                Me.DialogResult = DialogResult.OK
                            Else

                                m_nStatus = StatusNum.BeforeFirstPoint
                                picMain.Invalidate()

                            End If

                    End Select
                End If

            Case WM_DISCONNECTPEN
                Console.WriteLine("WM_DISCONNECTPEN")
                bDisconnect = True
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            Case WM_LOST_PEN
                Console.WriteLine("WM_LOST_PEN")
                bDisconnect = True
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            Case WM_GESTUREMESSAGE

            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
End Class