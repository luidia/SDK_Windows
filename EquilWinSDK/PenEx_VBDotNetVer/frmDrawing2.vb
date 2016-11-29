Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D


Public Class frmDrawing2
    Dim m_pRec As _pen_rec
    Dim m_bDrag As Boolean = False


    Dim m_ptMouseMove As PointF
    Dim bPenConnecting As Boolean = False
    Dim bPenConnectExit As Boolean = False

    'for drawing .
    Dim m_Bmp As Bitmap              'bitmap for double buffering
    Dim m_BmpLayer As Bitmap          'bitmap for layer drawing in case of highlighter pen 
    Public m_GrBmp As Graphics         'virtual bitmap
    Public m_GrMain As Graphics     'graphics for picturebox control
    Public m_GrLayer As Graphics     'graphics for m_BmpLayer

    Dim intNumberOfPoints As Integer = 0

    Dim m_ReciveHanle As System.IntPtr
    Dim m_DrawHanle As System.IntPtr

    Public bPenConnect As Boolean = False 'Pen is connect or not
    Public m_ConnectTime As System.Timers.Timer
    Public ConnectThread As Threading.Thread

    Dim m_DrawPen As Pen
    Dim m_PenStyle As PENSTYLE
    Dim m_Stroke As CPNFStroke
    Dim imgattr As ImageAttributes   'highlighter attribute
    Const Htransparency As Double = 0.3 ' transparency of highlighter 
    Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub
    Public Sub SetConfig(ppn As Pen, penStyle As Integer)
        m_DrawPen = ppn
        m_PenStyle = penStyle
    End Sub

    Public Sub MouseFlagDisable()
        If m_bDrag Then
            picMainDoMouseUp(m_ptMouseMove, MouseButtons.Left, 255, False)
        End If
    End Sub
    Sub picMainDoMouseDown(ByVal e As PointF, ByVal btn As Integer, ByVal press As Integer, ByVal bCtrlKey As Boolean)
        m_bDrag = True

        Select Case m_PenStyle
            Case PENSTYLE.PENSTYLE_BRUSH, PENSTYLE.PENSTYLE_HIGHLIGHT, PENSTYLE.PENSTYLE_NORMAL


                m_Stroke = New CPNFStroke
                m_Stroke.AddItem(e, press)
        End Select
    End Sub

    Sub picMainDoMouseMove(ByVal e As PointF, ByVal btn As Integer, ByVal Press As Integer, ByVal bCtrlKey As Boolean)
        Try
            If m_bDrag = True Then
                m_ptMouseMove.X = e.X
                m_ptMouseMove.Y = e.Y

                Select Case m_PenStyle

                    Case PENSTYLE.PENSTYLE_BRUSH
                        m_Stroke.AddItem(m_ptMouseMove, Press)
                        m_Stroke.DrawBrushByPenPressure(m_GrBmp, m_DrawPen, -1)
                        m_Stroke.DrawBrushByPenPressure(m_GrMain, m_DrawPen, -1)

                    Case PENSTYLE.PENSTYLE_HIGHLIGHT
                        m_Stroke.AddItem(m_ptMouseMove, Press)
                        Dim clipRect As RectangleF = m_Stroke.DrawLastQuard(m_GrLayer, m_DrawPen, -1)
                        picMain.Invalidate(Rectangle.Round(clipRect))



                    Case PENSTYLE.PENSTYLE_NORMAL
                        m_GrMain = picMain.CreateGraphics
                        m_GrMain.SmoothingMode = SmoothingMode.AntiAlias
                        m_Stroke.AddItem(m_ptMouseMove, Press)
                        m_Stroke.DrawLastQuard(m_GrBmp, m_DrawPen, -1)
                        m_Stroke.DrawLastQuard(m_GrMain, m_DrawPen, -1)

                End Select

            End If
        Catch ex As Exception
        Finally

        End Try
    End Sub

    Sub picMainDoMouseUp(ByVal e As PointF, ByVal btn As Integer, ByVal press As Integer, ByVal bCtrlKey As Boolean)
        If m_bDrag = True Then
            m_bDrag = False


            If m_PenStyle = PENSTYLE.PENSTYLE_HIGHLIGHT Then
                m_GrBmp.DrawImage(m_BmpLayer, New Rectangle(0, 0, m_Bmp.Width, m_Bmp.Height), _
                            0, 0, _
                            m_BmpLayer.Width, m_BmpLayer.Height, GraphicsUnit.Pixel, imgattr)
                m_GrLayer.Clear(Color.Transparent)
            End If
            picMain.Invalidate()

        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_DI_CHANGE_STATION
                MsgBox("Sensor position changed")

            Case WM_DISCONNECTPEN
                MsgBox("Bluetooth Disconnected")
            Case WM_DISCONNECTUSB
                MsgBox("USB Disconnected")
            Case WM_DI_NEWPAGE
                MsgBox("press button of sensor(New Page)")
            Case WM_DI_DUPLICATE
                MsgBox("long press button of sensor(Duplicate Page)")
            Case WM_RETURNMESSAGE
                m_pRec = New _pen_rec

                m_pRec = Marshal.PtrToStructure(m.WParam, New _pen_rec().GetType) 'get pen data from message

                Dim press As Integer = m_pRec.P

                Dim pt As New PointF



                Try
                    pt.X = m_pRec.TX ' Calibrated X
                    pt.Y = m_pRec.TY ' Calibrated Y

                    Select Case m_pRec.PenStatus
                        Case PenStatus.PEN_DOWN
                            picMainDoMouseDown(pt, MouseButtons.Left, press, False)
                        Case PenStatus.PEN_MOVE
                            If m_bDrag = True Then
                                If m_ptMouseMove.X * 1000 = pt.X * 1000 AndAlso m_ptMouseMove.Y * 1000 = pt.Y * 1000 Then 'elliminate multiple data.
                                Else
                                    picMainDoMouseMove(pt, MouseButtons.Left, press, False)
                                End If
                            End If
                        Case PenStatus.PEN_UP
                            picMainDoMouseUp(pt, MouseButtons.Left, press, False)
                        Case PenStatus.PEN_HOVER

                    End Select

                Catch ex As Exception
                    MouseFlagDisable()
                End Try

                Console.WriteLine("WM_RETURNMESSAGE Status={0} Point={1}", m_pRec.PenStatus, pt)
            Case WM_GESTUREMESSAGE
                MouseFlagDisable()

                Select Case m.LParam '
                    Case GestureMessage.GESTURE_CIRCLE_CLOCKWISE
                        Console.WriteLine("GESTURE CIRCLE CLOCKWISE")
                    Case GestureMessage.GESTURE_CIRCLE_COUNTERCLOCKWISE
                        Console.WriteLine("GESTURE CIRCLE COUNTERCLOCKWISE")
                    Case GestureMessage.GESTURE_CLICK
                        Console.WriteLine("GESTURE CLICK")
                End Select

            Case WM_PENCONDITION

            Case WM_MCU_VERSION

            Case WM_DISCONNECTPEN

            Case WM_DI_NEWPAGE
                Console.WriteLine("WM_DI_NEWPAGE New Page Button Clicked")
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Private Sub frmDrawing2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        picMain.Top = 0
        picMain.Left = 0
        picMain.Width = Me.ClientSize.Width
        picMain.Height = Me.ClientSize.Height
        picMain.BackgroundImage = Image.FromFile(Application.StartupPath + "\sample.png")
        picMain.BackgroundImageLayout = ImageLayout.Stretch
        CreateBitmap(True)
    End Sub
    Private Sub picMain_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles picMain.Paint
        If m_Bmp Is Nothing Then Exit Sub

        Dim gr As Graphics = e.Graphics
        Dim grState As GraphicsState = Nothing



        m_GrBmp.Dispose()
        m_GrBmp = Graphics.FromImage(m_Bmp)
        m_GrBmp.SmoothingMode = SmoothingMode.AntiAlias

        gr.DrawImage(m_Bmp, e.ClipRectangle, e.ClipRectangle, GraphicsUnit.Pixel)

        If m_bDrag Then
            Select Case m_PenStyle
                Case PENSTYLE.PENSTYLE_HIGHLIGHT
                    gr.DrawImage(m_BmpLayer, e.ClipRectangle, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height, GraphicsUnit.Pixel, imgattr)
            End Select
        End If
    End Sub
    Sub CreateBitmap(bCreate As Boolean)
        If m_Bmp IsNot Nothing Then m_Bmp.Dispose()
        If m_BmpLayer IsNot Nothing Then m_BmpLayer.Dispose()


        m_Bmp = New Bitmap(picMain.Width, picMain.Height)
        m_BmpLayer = New Bitmap(picMain.Width, picMain.Height)

        m_GrBmp = Graphics.FromImage(m_Bmp)
        m_GrLayer = Graphics.FromImage(m_BmpLayer)

        m_GrBmp.SmoothingMode = SmoothingMode.AntiAlias
        m_GrLayer.SmoothingMode = SmoothingMode.AntiAlias

        SetHPenAlpha()
    End Sub
    Public Sub SetHPenAlpha()
        If imgattr Is Nothing Then imgattr = New ImageAttributes() 'imgattr.Dispose()

        Dim values()() As Single = {New Single() {1, 0, 0, 0, 0}, _
                                 New Single() {0, 1, 0, 0, 0}, _
                                 New Single() {0, 0, 1, 0, 0}, _
                                 New Single() {0, 0, 0, Convert.ToSingle(Htransparency), 0}, _
                                 New Single() {0, 0, 0, 0, 1, 0}}
        Dim colMatrix As New ColorMatrix(values)
        imgattr.SetColorMatrix(colMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)
    End Sub
End Class