<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemoryImport
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnGetMemoryData = New System.Windows.Forms.Button()
        Me.btnStopImport = New System.Windows.Forms.Button()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.btnGetList = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(28, 82)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(595, 148)
        Me.ListBox1.TabIndex = 1
        '
        'btnGetMemoryData
        '
        Me.btnGetMemoryData.Location = New System.Drawing.Point(28, 236)
        Me.btnGetMemoryData.Name = "btnGetMemoryData"
        Me.btnGetMemoryData.Size = New System.Drawing.Size(104, 41)
        Me.btnGetMemoryData.TabIndex = 2
        Me.btnGetMemoryData.Text = "Get Data"
        Me.btnGetMemoryData.UseVisualStyleBackColor = true
        '
        'btnStopImport
        '
        Me.btnStopImport.Location = New System.Drawing.Point(138, 236)
        Me.btnStopImport.Name = "btnStopImport"
        Me.btnStopImport.Size = New System.Drawing.Size(104, 41)
        Me.btnStopImport.TabIndex = 3
        Me.btnStopImport.Text = "Stop Import"
        Me.btnStopImport.UseVisualStyleBackColor = true
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(438, 236)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(185, 41)
        Me.btnDeleteAll.TabIndex = 4
        Me.btnDeleteAll.Text = "Delete All File"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'btnGetList
        '
        Me.btnGetList.Location = New System.Drawing.Point(248, 236)
        Me.btnGetList.Name = "btnGetList"
        Me.btnGetList.Size = New System.Drawing.Size(104, 41)
        Me.btnGetList.TabIndex = 0
        Me.btnGetList.Text = "Resume"
        Me.btnGetList.UseVisualStyleBackColor = true
        '
        'frmMemoryImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 599)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnStopImport)
        Me.Controls.Add(Me.btnGetMemoryData)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnGetList)
        Me.Name = "frmMemoryImport"
        Me.Text = "frmMemoryImport"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnGetMemoryData As System.Windows.Forms.Button
    Friend WithEvents btnStopImport As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents btnGetList As System.Windows.Forms.Button
End Class
