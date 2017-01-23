Module Mod_Functions
    Public Function GetWorkingMonitorRect() As Rectangle
        Return GetWorkingMonitorRect(Nothing)
    End Function
    Public Function GetWorkingMonitorRect(ByVal hWnd As IntPtr) As Rectangle
        If hWnd <> Nothing Then
            Return Screen.FromHandle(hWnd).WorkingArea
        End If
        Dim applicationName As String = IO.Path.GetFileName(Application.ExecutablePath)
        For Each process As System.Diagnostics.Process In System.Diagnostics.Process.GetProcesses()
            If (process.ProcessName.Equals(applicationName)) Then
                Dim _sc As System.Windows.Forms.Screen = System.Windows.Forms.Screen.FromHandle(process.MainWindowHandle)
                Return _sc.WorkingArea
            End If
        Next
        Return Screen.PrimaryScreen.WorkingArea
    End Function

End Module
