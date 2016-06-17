<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenEx
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.cboPenStyle = New System.Windows.Forms.ComboBox()
        Me.btnConnectPen = New System.Windows.Forms.Button()
        Me.btnClearLog = New System.Windows.Forms.Button()
        Me.btnReStartPen = New System.Windows.Forms.Button()
        Me.btnCalibration = New System.Windows.Forms.Button()
        Me.btnDrawing = New System.Windows.Forms.Button()
        Me.lbLog = New System.Windows.Forms.ListBox()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lbAliveSec = New System.Windows.Forms.Label()
        Me.lbTemperature = New System.Windows.Forms.Label()
        Me.lbPressure = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbSensordis = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbMCU1Ver = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbIRGAP = New System.Windows.Forms.Label()
        Me.lbMCU2Ver = New System.Windows.Forms.Label()
        Me.lbModelCode = New System.Windows.Forms.Label()
        Me.lbHWVer = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbPacketCountClear = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbPacketCount = New System.Windows.Forms.Label()
        Me.lbConvY = New System.Windows.Forms.Label()
        Me.lbRawY = New System.Windows.Forms.Label()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.lbRawX = New System.Windows.Forms.Label()
        Me.lbConvX = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbBatteryPen = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lbBatteryStation = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAudio = New System.Windows.Forms.Button()
        Me.txtAudioVolume = New System.Windows.Forms.TextBox()
        Me.txtAudioMode = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbConnectionType = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lbStationFlag = New System.Windows.Forms.Label()
        Me.lbStationPosition = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbMakerState = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(747, 804)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cboPenStyle)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnConnectPen)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnClearLog)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnReStartPen)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnCalibration)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnDrawing)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lbLog)
        Me.SplitContainer2.Panel2.Controls.Add(Me.picMain)
        Me.SplitContainer2.Size = New System.Drawing.Size(747, 300)
        Me.SplitContainer2.SplitterDistance = 40
        Me.SplitContainer2.TabIndex = 0
        '
        'cboPenStyle
        '
        Me.cboPenStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPenStyle.FormattingEnabled = True
        Me.cboPenStyle.Location = New System.Drawing.Point(544, 11)
        Me.cboPenStyle.Name = "cboPenStyle"
        Me.cboPenStyle.Size = New System.Drawing.Size(200, 20)
        Me.cboPenStyle.TabIndex = 7
        '
        'btnConnectPen
        '
        Me.btnConnectPen.Location = New System.Drawing.Point(280, 0)
        Me.btnConnectPen.Name = "btnConnectPen"
        Me.btnConnectPen.Size = New System.Drawing.Size(82, 40)
        Me.btnConnectPen.TabIndex = 6
        Me.btnConnectPen.Text = "Connect"
        Me.btnConnectPen.UseVisualStyleBackColor = True
        '
        'btnClearLog
        '
        Me.btnClearLog.Location = New System.Drawing.Point(456, 0)
        Me.btnClearLog.Name = "btnClearLog"
        Me.btnClearLog.Size = New System.Drawing.Size(82, 40)
        Me.btnClearLog.TabIndex = 5
        Me.btnClearLog.Text = "Clear Log"
        Me.btnClearLog.UseVisualStyleBackColor = True
        '
        'btnReStartPen
        '
        Me.btnReStartPen.Location = New System.Drawing.Point(368, 0)
        Me.btnReStartPen.Name = "btnReStartPen"
        Me.btnReStartPen.Size = New System.Drawing.Size(82, 40)
        Me.btnReStartPen.TabIndex = 3
        Me.btnReStartPen.Text = "StopPen"
        Me.btnReStartPen.UseVisualStyleBackColor = True
        '
        'btnCalibration
        '
        Me.btnCalibration.Location = New System.Drawing.Point(88, 0)
        Me.btnCalibration.Name = "btnCalibration"
        Me.btnCalibration.Size = New System.Drawing.Size(82, 40)
        Me.btnCalibration.TabIndex = 1
        Me.btnCalibration.Text = "Calibration"
        Me.btnCalibration.UseVisualStyleBackColor = True
        '
        'btnDrawing
        '
        Me.btnDrawing.Location = New System.Drawing.Point(0, 0)
        Me.btnDrawing.Name = "btnDrawing"
        Me.btnDrawing.Size = New System.Drawing.Size(82, 40)
        Me.btnDrawing.TabIndex = 0
        Me.btnDrawing.Text = "Drawing"
        Me.btnDrawing.UseVisualStyleBackColor = True
        '
        'lbLog
        '
        Me.lbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbLog.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbLog.FormattingEnabled = True
        Me.lbLog.ItemHeight = 16
        Me.lbLog.Location = New System.Drawing.Point(0, 0)
        Me.lbLog.Name = "lbLog"
        Me.lbLog.Size = New System.Drawing.Size(747, 256)
        Me.lbLog.TabIndex = 1
        '
        'picMain
        '
        Me.picMain.BackColor = System.Drawing.Color.Transparent
        Me.picMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(747, 256)
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.TrackBar1)
        Me.GroupBox5.Controls.Add(Me.lbAliveSec)
        Me.GroupBox5.Controls.Add(Me.lbTemperature)
        Me.GroupBox5.Controls.Add(Me.lbPressure)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 285)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(661, 90)
        Me.GroupBox5.TabIndex = 52
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Smart Pen"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(17, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Alive Sec"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(17, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pressure"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(228, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Temperature"
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(333, 49)
        Me.TrackBar1.Maximum = 700
        Me.TrackBar1.Minimum = 25
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(100, 20)
        Me.TrackBar1.TabIndex = 39
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 25
        '
        'lbAliveSec
        '
        Me.lbAliveSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbAliveSec.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbAliveSec.Location = New System.Drawing.Point(122, 17)
        Me.lbAliveSec.Name = "lbAliveSec"
        Me.lbAliveSec.Size = New System.Drawing.Size(100, 20)
        Me.lbAliveSec.TabIndex = 30
        '
        'lbTemperature
        '
        Me.lbTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTemperature.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbTemperature.Location = New System.Drawing.Point(333, 17)
        Me.lbTemperature.Name = "lbTemperature"
        Me.lbTemperature.Size = New System.Drawing.Size(100, 20)
        Me.lbTemperature.TabIndex = 36
        '
        'lbPressure
        '
        Me.lbPressure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPressure.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbPressure.Location = New System.Drawing.Point(122, 49)
        Me.lbPressure.Name = "lbPressure"
        Me.lbPressure.Size = New System.Drawing.Size(100, 20)
        Me.lbPressure.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label20.Location = New System.Drawing.Point(228, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 20)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Threshold"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.lbSensordis)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.lbMCU1Ver)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lbIRGAP)
        Me.GroupBox4.Controls.Add(Me.lbMCU2Ver)
        Me.GroupBox4.Controls.Add(Me.lbModelCode)
        Me.GroupBox4.Controls.Add(Me.lbHWVer)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(662, 69)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hardware Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(240, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sensor dis"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(429, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IR_GAP"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(240, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MCU1 Ver"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(429, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MCU2 Ver"
        '
        'lbSensordis
        '
        Me.lbSensordis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSensordis.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbSensordis.Location = New System.Drawing.Point(323, 16)
        Me.lbSensordis.Name = "lbSensordis"
        Me.lbSensordis.Size = New System.Drawing.Size(100, 20)
        Me.lbSensordis.TabIndex = 37
        Me.lbSensordis.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(7, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ModelCode"
        '
        'lbMCU1Ver
        '
        Me.lbMCU1Ver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMCU1Ver.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbMCU1Ver.Location = New System.Drawing.Point(323, 43)
        Me.lbMCU1Ver.Name = "lbMCU1Ver"
        Me.lbMCU1Ver.Size = New System.Drawing.Size(100, 20)
        Me.lbMCU1Ver.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(7, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "H/W Ver"
        '
        'lbIRGAP
        '
        Me.lbIRGAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbIRGAP.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbIRGAP.Location = New System.Drawing.Point(534, 17)
        Me.lbIRGAP.Name = "lbIRGAP"
        Me.lbIRGAP.Size = New System.Drawing.Size(100, 20)
        Me.lbIRGAP.TabIndex = 27
        Me.lbIRGAP.Visible = False
        '
        'lbMCU2Ver
        '
        Me.lbMCU2Ver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMCU2Ver.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbMCU2Ver.Location = New System.Drawing.Point(534, 43)
        Me.lbMCU2Ver.Name = "lbMCU2Ver"
        Me.lbMCU2Ver.Size = New System.Drawing.Size(100, 20)
        Me.lbMCU2Ver.TabIndex = 21
        '
        'lbModelCode
        '
        Me.lbModelCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbModelCode.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbModelCode.Location = New System.Drawing.Point(122, 17)
        Me.lbModelCode.Name = "lbModelCode"
        Me.lbModelCode.Size = New System.Drawing.Size(100, 20)
        Me.lbModelCode.TabIndex = 24
        '
        'lbHWVer
        '
        Me.lbHWVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbHWVer.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbHWVer.Location = New System.Drawing.Point(122, 42)
        Me.lbHWVer.Name = "lbHWVer"
        Me.lbHWVer.Size = New System.Drawing.Size(100, 20)
        Me.lbHWVer.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lbPacketCountClear)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lbPacketCount)
        Me.GroupBox3.Controls.Add(Me.lbConvY)
        Me.GroupBox3.Controls.Add(Me.lbRawY)
        Me.GroupBox3.Controls.Add(Me.lbStatus)
        Me.GroupBox3.Controls.Add(Me.lbRawX)
        Me.GroupBox3.Controls.Add(Me.lbConvX)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 132)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(17, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Packet Count"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(18, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status"
        '
        'lbPacketCountClear
        '
        Me.lbPacketCountClear.AutoSize = True
        Me.lbPacketCountClear.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbPacketCountClear.ForeColor = System.Drawing.Color.Blue
        Me.lbPacketCountClear.Location = New System.Drawing.Point(228, 17)
        Me.lbPacketCountClear.Name = "lbPacketCountClear"
        Me.lbPacketCountClear.Size = New System.Drawing.Size(40, 20)
        Me.lbPacketCountClear.TabIndex = 38
        Me.lbPacketCountClear.Text = "Clear"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(18, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Raw X"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(18, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Conv X"
        '
        'lbPacketCount
        '
        Me.lbPacketCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPacketCount.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbPacketCount.Location = New System.Drawing.Point(122, 17)
        Me.lbPacketCount.Name = "lbPacketCount"
        Me.lbPacketCount.Size = New System.Drawing.Size(100, 20)
        Me.lbPacketCount.TabIndex = 23
        '
        'lbConvY
        '
        Me.lbConvY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbConvY.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbConvY.Location = New System.Drawing.Point(334, 98)
        Me.lbConvY.Name = "lbConvY"
        Me.lbConvY.Size = New System.Drawing.Size(100, 20)
        Me.lbConvY.TabIndex = 35
        '
        'lbRawY
        '
        Me.lbRawY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbRawY.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbRawY.Location = New System.Drawing.Point(334, 73)
        Me.lbRawY.Name = "lbRawY"
        Me.lbRawY.Size = New System.Drawing.Size(100, 20)
        Me.lbRawY.TabIndex = 34
        '
        'lbStatus
        '
        Me.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStatus.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbStatus.Location = New System.Drawing.Point(123, 48)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(100, 20)
        Me.lbStatus.TabIndex = 26
        '
        'lbRawX
        '
        Me.lbRawX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbRawX.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbRawX.Location = New System.Drawing.Point(123, 73)
        Me.lbRawX.Name = "lbRawX"
        Me.lbRawX.Size = New System.Drawing.Size(100, 20)
        Me.lbRawX.TabIndex = 33
        '
        'lbConvX
        '
        Me.lbConvX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbConvX.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbConvX.Location = New System.Drawing.Point(123, 98)
        Me.lbConvX.Name = "lbConvX"
        Me.lbConvX.Size = New System.Drawing.Size(100, 20)
        Me.lbConvX.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(229, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Raw Y"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(229, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Conv Y"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label19.Location = New System.Drawing.Point(232, 47)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(253, 20)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "[1 = Down, 2 = Move, 3 = Up, 4 = Hover]"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.lbBatteryPen)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.lbBatteryStation)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 229)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 50)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Battery"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label29.Location = New System.Drawing.Point(242, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 20)
        Me.Label29.TabIndex = 45
        Me.Label29.Text = "Pen"
        '
        'lbBatteryPen
        '
        Me.lbBatteryPen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbBatteryPen.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbBatteryPen.Location = New System.Drawing.Point(337, 16)
        Me.lbBatteryPen.Name = "lbBatteryPen"
        Me.lbBatteryPen.Size = New System.Drawing.Size(100, 20)
        Me.lbBatteryPen.TabIndex = 46
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label27.Location = New System.Drawing.Point(6, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 20)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Station"
        '
        'lbBatteryStation
        '
        Me.lbBatteryStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbBatteryStation.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbBatteryStation.Location = New System.Drawing.Point(122, 17)
        Me.lbBatteryStation.Name = "lbBatteryStation"
        Me.lbBatteryStation.Size = New System.Drawing.Size(100, 20)
        Me.lbBatteryStation.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAudio)
        Me.GroupBox1.Controls.Add(Me.txtAudioVolume)
        Me.GroupBox1.Controls.Add(Me.txtAudioMode)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.lbConnectionType)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label55)
        Me.GroupBox1.Controls.Add(Me.lbStationFlag)
        Me.GroupBox1.Controls.Add(Me.lbStationPosition)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lbMakerState)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 381)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 107)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Smart Marker"
        '
        'btnAudio
        '
        Me.btnAudio.Location = New System.Drawing.Point(457, 77)
        Me.btnAudio.Name = "btnAudio"
        Me.btnAudio.Size = New System.Drawing.Size(89, 20)
        Me.btnAudio.TabIndex = 53
        Me.btnAudio.Text = "Set Audio"
        Me.btnAudio.UseVisualStyleBackColor = True
        '
        'txtAudioVolume
        '
        Me.txtAudioVolume.Location = New System.Drawing.Point(337, 76)
        Me.txtAudioVolume.Name = "txtAudioVolume"
        Me.txtAudioVolume.Size = New System.Drawing.Size(100, 21)
        Me.txtAudioVolume.TabIndex = 52
        '
        'txtAudioMode
        '
        Me.txtAudioMode.Location = New System.Drawing.Point(337, 49)
        Me.txtAudioMode.Name = "txtAudioMode"
        Me.txtAudioMode.Size = New System.Drawing.Size(100, 21)
        Me.txtAudioMode.TabIndex = 51
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label31.Location = New System.Drawing.Point(6, 73)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(110, 20)
        Me.Label31.TabIndex = 49
        Me.Label31.Text = "Connection Type"
        '
        'lbConnectionType
        '
        Me.lbConnectionType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbConnectionType.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbConnectionType.Location = New System.Drawing.Point(122, 73)
        Me.lbConnectionType.Name = "lbConnectionType"
        Me.lbConnectionType.Size = New System.Drawing.Size(100, 20)
        Me.lbConnectionType.TabIndex = 50
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label25.Location = New System.Drawing.Point(228, 74)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(94, 20)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Audio Volume"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label23.Location = New System.Drawing.Point(232, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 20)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Audio Mode"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label22.Location = New System.Drawing.Point(232, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 20)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Flag"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label55.Location = New System.Drawing.Point(6, 50)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(61, 20)
        Me.Label55.TabIndex = 43
        Me.Label55.Text = "Direction"
        '
        'lbStationFlag
        '
        Me.lbStationFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStationFlag.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbStationFlag.Location = New System.Drawing.Point(337, 20)
        Me.lbStationFlag.Name = "lbStationFlag"
        Me.lbStationFlag.Size = New System.Drawing.Size(100, 20)
        Me.lbStationFlag.TabIndex = 44
        '
        'lbStationPosition
        '
        Me.lbStationPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStationPosition.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbStationPosition.Location = New System.Drawing.Point(122, 50)
        Me.lbStationPosition.Name = "lbStationPosition"
        Me.lbStationPosition.Size = New System.Drawing.Size(100, 20)
        Me.lbStationPosition.TabIndex = 44
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label21.Location = New System.Drawing.Point(6, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 20)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Property"
        '
        'lbMakerState
        '
        Me.lbMakerState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMakerState.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.lbMakerState.Location = New System.Drawing.Point(122, 20)
        Me.lbMakerState.Name = "lbMakerState"
        Me.lbMakerState.Size = New System.Drawing.Size(100, 20)
        Me.lbMakerState.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(176, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calibration by Form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPenEx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 804)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPenEx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equil SDK"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDrawing As System.Windows.Forms.Button
    Friend WithEvents btnClearLog As System.Windows.Forms.Button
    Friend WithEvents btnReStartPen As System.Windows.Forms.Button
    Friend WithEvents btnCalibration As System.Windows.Forms.Button
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents lbTemperature As System.Windows.Forms.Label
    Friend WithEvents lbConvY As System.Windows.Forms.Label
    Friend WithEvents lbRawY As System.Windows.Forms.Label
    Friend WithEvents lbRawX As System.Windows.Forms.Label
    Friend WithEvents lbAliveSec As System.Windows.Forms.Label
    Friend WithEvents lbConvX As System.Windows.Forms.Label
    Friend WithEvents lbMCU1Ver As System.Windows.Forms.Label
    Friend WithEvents lbIRGAP As System.Windows.Forms.Label
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents lbPressure As System.Windows.Forms.Label
    Friend WithEvents lbModelCode As System.Windows.Forms.Label
    Friend WithEvents lbPacketCount As System.Windows.Forms.Label
    Friend WithEvents lbHWVer As System.Windows.Forms.Label
    Friend WithEvents lbMCU2Ver As System.Windows.Forms.Label
    Friend WithEvents lbSensordis As System.Windows.Forms.Label
    Friend WithEvents btnConnectPen As System.Windows.Forms.Button
    Friend WithEvents lbPacketCountClear As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents lbLog As System.Windows.Forms.ListBox
    Friend WithEvents cboPenStyle As System.Windows.Forms.ComboBox
    Friend WithEvents lbMakerState As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents lbStationFlag As System.Windows.Forms.Label
    Friend WithEvents lbStationPosition As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lbBatteryPen As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lbBatteryStation As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lbConnectionType As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnAudio As System.Windows.Forms.Button
    Friend WithEvents txtAudioVolume As System.Windows.Forms.TextBox
    Friend WithEvents txtAudioMode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
