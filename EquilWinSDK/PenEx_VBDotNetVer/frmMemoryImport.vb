Imports System.Runtime.InteropServices

Public Class frmMemoryImport

    Dim DI_dataList As Dictionary(Of String, List(Of Integer)) = New Dictionary(Of String, List(Of Integer))


    Private Sub btnGetList_Click(sender As Object, e As EventArgs) Handles btnGetList.Click
        If EquilModelCode = 3 Then 'Sp2
            StartDISetup(0)
        Else    'sm
            StartDISetup(1)

        End If
    End Sub

    Public Sub SetDIList()

        Dim clist As Byte() = Nothing
        Try
            Dim _size As Integer = 0
            GetDIList(Nothing, _size)

            clist = Array.CreateInstance(GetType(Byte), _size)

            Dim pData As GCHandle = GCHandle.Alloc(clist, GCHandleType.Pinned)
            GetDIList(pData.AddrOfPinnedObject(), _size)
            pData.Free()
        Catch ex As Exception
            MsgBox("SetDilist error - " & ex.Message)
        End Try


        Console.WriteLine("Set di list done")
        MakeImportNotebookList(clist)


    End Sub



    Private Sub MakeImportNotebookList(ByVal importList As Byte())
        'yy/MM/dd/hh/mm/ss/size - 6byte + 4byte(int)
        Dim nOffset As Integer = 0
        Dim nTotalSize As Integer = importList.Length
        Dim tmp As Byte() = New Byte(10 - 1) {}
        Dim newFolder As String = "StartFolder"
        Dim oldFolder As String = String.Empty

        DI_dataList.Clear()
        Dim folderIdx As Integer = -1
        Dim fileIdx As Integer = 0

        Dim nYearOld As Integer = 0
        Dim nMonthOld As Integer = 0
        Dim nDayOld As Integer = 0

        While nTotalSize > 0
            Buffer.BlockCopy(importList, nOffset, tmp, 0, 10)   'copy 10byte
            Dim nYear As Integer = Convert.ToInt32(tmp(0))
            Dim nMonth As Integer = Convert.ToInt32(tmp(1))
            Dim nDay As Integer = Convert.ToInt32(tmp(2))
            Dim nHour As Integer = Convert.ToInt32(tmp(3))
            Dim nMin As Integer = Convert.ToInt32(tmp(4))
            Dim nSec As Integer = Convert.ToInt32(tmp(5))
            Dim nSize As Integer = BitConverter.ToInt32(tmp, 6)
            Dim sfileName As String = String.Format("{0:0000}{1:00}{2:00}{3:00}{4:00}{5:00}_{6}", nYear + 2000, nMonth, nDay, nHour, nMin, nSec, nSize)
            If nYear = nYearOld And nMonth = nMonthOld And nDay = nDayOld Then
                fileIdx += 1
            Else
                folderIdx += 1
                fileIdx = 0
            End If
            Console.WriteLine("sfileName=" + sfileName)
            nOffset += 10   'move offset
            nTotalSize -= 10

            ListBox1.Items.Add(sfileName)
            Dim ll As List(Of Integer) = New List(Of Integer)
            ll.Add(folderIdx)
            ll.Add(fileIdx)
            DI_dataList.Add(sfileName, ll)

            nYearOld = nYear
            nMonthOld = nMonth
            nDayOld = nDay

        End While



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnGetMemoryData_Click(sender As Object, e As EventArgs) Handles btnGetMemoryData.Click
        Dim fileName As String = ListBox1.SelectedItem
        Dim ll As List(Of Integer) = DI_dataList(fileName)
        SetDI(DICOMMAND.OPENFILE, ll.Item(0), ll.Item(1))
    End Sub

    Private Sub btnStopImport_Click(sender As Object, e As EventArgs) Handles btnStopImport.Click
        DIOpenFileStop()
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        SetDI(DICOMMAND.REMOVEALL, 0, 0)
    End Sub
End Class