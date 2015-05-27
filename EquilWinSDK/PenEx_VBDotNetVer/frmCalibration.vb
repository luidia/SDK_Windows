Imports System.Runtime.InteropServices

Public Class frmCalibration
    Dim iPenCalibrationStatus As Integer = PenCalibrationStatus.CAL_TOP
    Private nClickIndex As Integer = -1
    Dim m_pRec As New _pen_rec  '그릴 영역
    Dim ptStart, ptEnd As PointF

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_RETURNMESSAGE
                m_pRec = New _pen_rec

                m_pRec = Marshal.PtrToStructure(m.WParam, New _pen_rec().GetType) 'IntPtr을 구조체형으로 변환

                If m_pRec.PenStatus = PenStatus.PEN_UP Then
                    Select Case iPenCalibrationStatus
                        Case PenCalibrationStatus.CAL_TOP
                            nClickIndex += 1
                            If nClickIndex <> 0 Then Exit Sub
                            iPenCalibrationStatus = PenCalibrationStatus.CAL_BOTTOM

                            ptStart.X = m_pRec.X
                            ptStart.Y = m_pRec.Y
                            'SetCalibration_Top(m_pRec.X, m_pRec.Y)

                            pic1.Visible = False
                            pic2.Visible = True
                        Case PenCalibrationStatus.CAL_BOTTOM
                            nClickIndex += 1
                            If nClickIndex <> 1 Then Exit Sub
                            ptEnd.X = m_pRec.X
                            ptEnd.Y = m_pRec.Y

                            If MsgBox("Do you want to save the changes ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                                SetCalibration_Top(ptStart.X, ptStart.Y)
                                SetCalibration_Bottom(ptEnd.X, ptEnd.Y)
                                SetCalibration_End()

                                Me.DialogResult = DialogResult.OK
                            Else
                                Me.DialogResult = DialogResult.Cancel
                            End If
                    End Select
                End If

            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
End Class