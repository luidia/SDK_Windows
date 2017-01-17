Imports System.Runtime.InteropServices

Public Class frmCalibration
    Dim iPenCalibrationStatus As Integer = PenCalibrationSatus.CAL_TOP
    Dim m_pRec As _pen_rec  '그릴 영역
    Public m_CaliTop As System.Drawing.PointF
    Public m_CaliBottom As System.Drawing.PointF
    Public bDisconnect As Boolean = False
    Private nClickIndex As Integer = -1
    Private m_LeftRight As Integer = 0  '0: left side of station. 1:right side of station
    Private sPenMessage As String = "PenMessage"
    Enum PenCalibrationSatus
        CAL_TOP = 0
        CAL_BOTTOM
        CAL_END
    End Enum

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_RETURNMESSAGE
                If nClickIndex < 1 Then

                    m_pRec = Marshal.PtrToStructure(m.WParam, New _pen_rec().GetType) 'IntPtr을 구조체형으로 변환

                    If m_pRec.PenStatus = PenStatus.PEN_UP Then
                        Select Case iPenCalibrationStatus
                            Case PenCalibrationSatus.CAL_TOP
                                If m_pRec.X = 0 Or m_pRec.Y = 0 Then Exit Sub
                                If (m_pRec.bRight And m_LeftRight = 1) Or (m_pRec.bRight = False And m_LeftRight = 0) Then
                                    btnStationOther_Click(Nothing, Nothing)
                                    Exit Sub
                                End If

                                nClickIndex += 1
                                If nClickIndex <> 0 Then Exit Sub
                                iPenCalibrationStatus = PenCalibrationSatus.CAL_BOTTOM
                                m_CaliTop = New System.Drawing.PointF(m_pRec.X, m_pRec.Y)
                                pic1.Visible = False
                                pic2.Visible = True
                            Case PenCalibrationSatus.CAL_BOTTOM

                                If (m_pRec.bRight And m_LeftRight = 1) Or (m_pRec.bRight = False And m_LeftRight = 0) Then
                                    pic1.Visible = True
                                    pic2.Visible = False

                                    iPenCalibrationStatus = PenCalibrationSatus.CAL_TOP
                                    nClickIndex = -1
                                    btnStationOther_Click(Nothing, Nothing)
                                    Exit Sub
                                End If
                                nClickIndex += 1
                                Dim ret As Boolean = True
                                If nClickIndex <> 1 Then Exit Sub

                                m_CaliBottom = New System.Drawing.PointF(m_pRec.X, m_pRec.Y)
                                ''' test !!!!!!!
                                'm_CaliTop = New Point(1638, 47444)
                                'm_CaliBottom = New System.Drawing.Point(5884, 53234)
                                'm_CaliTop = New Point(1792, 47544)
                                'm_CaliBottom = New System.Drawing.PointF(6450, 53102)
                                ''''''''''''''''''''
                                'Calibration TOP.x=1638 Top.y=47444 Bottom.x=5884 Bottom.y=53233

                                Console.WriteLine("Calibration TOP.x={0} Top.y={1} Bottom.x={2} Bottom.y={3}", m_CaliTop.X, m_CaliTop.Y, m_CaliBottom.X, m_CaliBottom.Y)
                                If Math.Abs(m_CaliBottom.X - m_CaliTop.X) < 300 Or Math.Abs(m_CaliBottom.Y - m_CaliTop.Y) < 300 Then
                                    ret = False
                                End If
                                If m_CaliBottom.X < m_CaliTop.X Or m_CaliBottom.Y < m_CaliTop.Y Then
                                    ret = False
                                End If
                                'Dim commitCali As New EquilMsgBoxOKCancel(CBizCom.PSMGetString(TextMsg.CheckChangeFile), Me)
                                If ret = True Then
                                    SetCalibration_Top(m_CaliTop.X, m_CaliTop.Y)
                                    SetCalibration_Bottom(m_CaliBottom.X, m_CaliBottom.Y)
                                    SetCalibration_End()

                                    Me.DialogResult = DialogResult.OK
 
                                Else
                                pic1.Visible = True
                                pic2.Visible = False

                                iPenCalibrationStatus = PenCalibrationSatus.CAL_TOP
                                nClickIndex = -1
                                End If
                                'If MsgBoxResult.Ok = MsgBox(CBizCom.PSMGetString(TextMsg.CheckChangeFile), MsgBoxStyle.OkCancel, CBizCom.PSMGetString(TextMsg.SUBMENU_GESTURE_FUNC11)) Then
                                'Else
                                'End If


                        End Select
                    End If
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

    Private Sub frmCalibration_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadToolTip()
        ChangeCaliImg()
    End Sub

    Sub LoadToolTip()
        Me.Text = "Calibration"
        '   Me.Font = New Font(CBizCom.GetLocaleFont(1), Me.Font.Size)

        Label1.Text = "Select your Page size"
        '    Label1.Font = New Font(CBizCom.GetLocaleFont(1), Label1.Font.Size, FontStyle.Bold)
        Label1.Location = New Point(Me.Width / 2 - Me.Label1.Width / 2, 25)

        Label2.Text = "On your paper, use the Equil  to tap the points in order, as shown in the picture"
        '   Label2.Font = New Font(CBizCom.GetLocaleFont(1), Label2.Font.Size)
        Label2.Location = New Point(Me.Width / 2 - Me.Label2.Width / 2, Label1.ClientRectangle.Bottom + 20)
    End Sub

    Sub ChangeCaliImg()
        Dim dpix As Single = Me.CurrentAutoScaleDimensions.Width / 96.0F
        Const LEFTMARGIN As Integer = 10
        If EquilModelCode <= 3 Then
            Me.BackgroundImage = My.Resources.sp_cali
            pic1.Location = New Point(dpix * 140, dpix * 260)
            pic2.Location = New Point(dpix * 350, dpix * 550)
            pic2sub.Location = New Point(dpix * 350, dpix * 550)
        ElseIf EquilModelCode = 4 Then
            Select Case CURRENT_MARKER_DIRECT
                Case StationPosition.LEFT, StationPosition.RIGHT
                    Select Case m_LeftRight
                        Case 0
                            Me.BackgroundImage = My.Resources.sm_cali02
                            pic1.Location = New Point(dpix * 80, dpix * 257)
                            pic2.Location = New Point(dpix * 400, dpix * 430)
                            pic2sub.Location = New Point(dpix * 400, dpix * 430)
                            btnStationOther.Left = Me.ClientRectangle.Width - btnStationOther.Width - LEFTMARGIN
                            btnStationOther.Top = Me.ClientRectangle.Height / 2 - btnStationOther.Height / 2 + 10
                            btnStationOther.Visible = True
                            btnStationOther.Image = My.Resources.sm_btn_off
                            btnStationOther.Tag = 0

                            btnStationCur.Left = LEFTMARGIN
                            btnStationCur.Top = Me.ClientRectangle.Height / 2 - btnStationCur.Height / 2 + 10
                            btnStationCur.Visible = True
                            btnStationCur.Image = My.Resources.sm_btn
                            btnStationCur.Tag = 1
                        Case 1
                            Me.BackgroundImage = My.Resources.sm_cali02
                            pic1.Location = New Point(dpix * 384, dpix * 257)
                            pic2.Location = New Point(dpix * 80, dpix * 430)
                            pic2sub.Location = New Point(dpix * 80, dpix * 430)
                            btnStationOther.Left = LEFTMARGIN
                            btnStationOther.Top = Me.ClientRectangle.Height / 2 - btnStationOther.Height / 2 + 10
                            btnStationOther.Visible = True
                            btnStationOther.Image = My.Resources.sm_btn_off
                            btnStationOther.Tag = 0
                            btnStationCur.Left = Me.ClientRectangle.Width - btnStationOther.Width - LEFTMARGIN
                            btnStationCur.Top = Me.ClientRectangle.Height / 2 - btnStationCur.Height / 2 + 10
                            btnStationCur.Visible = True
                            btnStationCur.Image = My.Resources.sm_btn
                            btnStationCur.Tag = 1

                    End Select
                    btnStationTop.Visible = False

                Case StationPosition.TOP
                    Me.BackgroundImage = My.Resources.sm_cali01
                    pic1.Location = New Point(dpix * 80, dpix * 247)
                    pic2.Location = New Point(dpix * 400, dpix * 520)
                    pic2sub.Location = New Point(dpix * 400, dpix * 520)
                    btnStationOther.Visible = False
                    btnStationCur.Visible = False
                    btnStationTop.Visible = True

                    btnStationTop.Image = My.Resources.sm_top_btn
                Case StationPosition.BOTTOM
                    Me.BackgroundImage = My.Resources.sm_cali03
                    pic1.Location = New Point(dpix * 80, dpix * 247)
                    pic2.Location = New Point(dpix * 400, dpix * 520)
                    pic2sub.Location = New Point(dpix * 400, dpix * 520)
                    btnStationOther.Visible = False
                    btnStationCur.Visible = False
                    btnStationBottom.Visible = True
                    btnStationBottom.Image = My.Resources.sm_bottom_btn
                    btnStationTop.Visible = False
            End Select
        End If

    End Sub

    Private Sub btnStationOther_Click(sender As Object, e As EventArgs) Handles btnStationOther.Click


        If btnStationOther.Tag = 1 Then Exit Sub

        m_LeftRight = If(m_LeftRight = 1, 0, 1)

        ChangeCaliImg()
    End Sub

    Private Sub btnStationCur_Click(sender As Object, e As EventArgs) Handles btnStationCur.Click

        If btnStationCur.Tag = 1 Then Exit Sub
        m_LeftRight = If(m_LeftRight = 1, 0, 1)

        ChangeCaliImg()
    End Sub


    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        If nClickIndex = -1 Then Exit Sub
        pic1.Visible = True
        pic2.Visible = False

        iPenCalibrationStatus = PenCalibrationSatus.CAL_TOP
        nClickIndex = -1

    End Sub
End Class