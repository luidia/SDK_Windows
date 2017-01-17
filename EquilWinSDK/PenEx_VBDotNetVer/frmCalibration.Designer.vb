<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalibration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalibration))
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pic2sub = New System.Windows.Forms.PictureBox()
        Me.btnStationOther = New System.Windows.Forms.Button()
        Me.btnStationCur = New System.Windows.Forms.Button()
        Me.btnStationTop = New System.Windows.Forms.Button()
        Me.btnStationBottom = New System.Windows.Forms.Button()
        Me.btnRetry = New System.Windows.Forms.PictureBox()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2sub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRetry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.Transparent
        Me.pic1.BackgroundImage = Global.PenEx_VBDotNetVer.My.Resources.Resources.cali_num1
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.Location = New System.Drawing.Point(86, 251)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(40, 40)
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.BackColor = System.Drawing.Color.Transparent
        Me.pic2.BackgroundImage = Global.PenEx_VBDotNetVer.My.Resources.Resources.cali_num2
        Me.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic2.Location = New System.Drawing.Point(385, 520)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(40, 40)
        Me.pic2.TabIndex = 1
        Me.pic2.TabStop = False
        Me.pic2.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(137, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 56)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selezionare la grandezza del foglio desiderata"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(114, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 70)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tap the points with Equil JOT on your paper in the numerical order as the screen " & _
    "shot shows"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic2sub
        '
        Me.pic2sub.BackColor = System.Drawing.Color.Transparent
        Me.pic2sub.BackgroundImage = Global.PenEx_VBDotNetVer.My.Resources.Resources.eq_pointer_guide
        Me.pic2sub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic2sub.Location = New System.Drawing.Point(385, 520)
        Me.pic2sub.Name = "pic2sub"
        Me.pic2sub.Size = New System.Drawing.Size(40, 40)
        Me.pic2sub.TabIndex = 4
        Me.pic2sub.TabStop = False
        '
        'btnStationOther
        '
        Me.btnStationOther.BackColor = System.Drawing.Color.Transparent
        Me.btnStationOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStationOther.FlatAppearance.BorderSize = 0
        Me.btnStationOther.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStationOther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStationOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStationOther.Location = New System.Drawing.Point(456, 320)
        Me.btnStationOther.Name = "btnStationOther"
        Me.btnStationOther.Size = New System.Drawing.Size(32, 132)
        Me.btnStationOther.TabIndex = 5
        Me.btnStationOther.UseVisualStyleBackColor = False
        '
        'btnStationCur
        '
        Me.btnStationCur.BackColor = System.Drawing.Color.Transparent
        Me.btnStationCur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStationCur.FlatAppearance.BorderSize = 0
        Me.btnStationCur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStationCur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStationCur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStationCur.Location = New System.Drawing.Point(12, 320)
        Me.btnStationCur.Name = "btnStationCur"
        Me.btnStationCur.Size = New System.Drawing.Size(32, 132)
        Me.btnStationCur.TabIndex = 6
        Me.btnStationCur.UseVisualStyleBackColor = False
        '
        'btnStationTop
        '
        Me.btnStationTop.BackColor = System.Drawing.Color.Transparent
        Me.btnStationTop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStationTop.FlatAppearance.BorderSize = 0
        Me.btnStationTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStationTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStationTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStationTop.Location = New System.Drawing.Point(192, 198)
        Me.btnStationTop.Name = "btnStationTop"
        Me.btnStationTop.Size = New System.Drawing.Size(132, 32)
        Me.btnStationTop.TabIndex = 7
        Me.btnStationTop.UseVisualStyleBackColor = False
        '
        'btnStationBottom
        '
        Me.btnStationBottom.BackColor = System.Drawing.Color.Transparent
        Me.btnStationBottom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStationBottom.FlatAppearance.BorderSize = 0
        Me.btnStationBottom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStationBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStationBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStationBottom.Location = New System.Drawing.Point(192, 576)
        Me.btnStationBottom.Name = "btnStationBottom"
        Me.btnStationBottom.Size = New System.Drawing.Size(132, 32)
        Me.btnStationBottom.TabIndex = 8
        Me.btnStationBottom.UseVisualStyleBackColor = False
        '
        'btnRetry
        '
        Me.btnRetry.BackColor = System.Drawing.Color.Transparent
        Me.btnRetry.BackgroundImage = CType(resources.GetObject("btnRetry.BackgroundImage"), System.Drawing.Image)
        Me.btnRetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetry.Location = New System.Drawing.Point(235, 148)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(40, 40)
        Me.btnRetry.TabIndex = 9
        Me.btnRetry.TabStop = False
        '
        'frmCalibration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(512, 668)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.btnStationBottom)
        Me.Controls.Add(Me.btnStationTop)
        Me.Controls.Add(Me.btnStationCur)
        Me.Controls.Add(Me.btnStationOther)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.pic2sub)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalibration"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCalibration"
        Me.TopMost = True
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2sub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRetry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pic2sub As System.Windows.Forms.PictureBox
    Friend WithEvents btnStationOther As System.Windows.Forms.Button
    Friend WithEvents btnStationCur As System.Windows.Forms.Button
    Friend WithEvents btnStationTop As System.Windows.Forms.Button
    Friend WithEvents btnStationBottom As System.Windows.Forms.Button
    Friend WithEvents btnRetry As System.Windows.Forms.PictureBox
End Class
