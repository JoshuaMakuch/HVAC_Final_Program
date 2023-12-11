<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HVAC_Final_Program_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SerialPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HVACSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedCOMPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedBaudRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HVACSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCurrentSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadSettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OverallTemperatureLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HighTempTextBox = New System.Windows.Forms.TextBox()
        Me.HighUpButton = New System.Windows.Forms.Button()
        Me.HighDownButton = New System.Windows.Forms.Button()
        Me.LowDownButton = New System.Windows.Forms.Button()
        Me.LowTempTextBox = New System.Windows.Forms.TextBox()
        Me.LowUpButton = New System.Windows.Forms.Button()
        Me.HighTempTextBoxLabel = New System.Windows.Forms.Label()
        Me.LowTempTextBoxLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QYATHandleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SafteyInterlockIndicatorLabel = New System.Windows.Forms.Label()
        Me.HeatingElementIndicatorLabel = New System.Windows.Forms.Label()
        Me.CoolingElementIndicatorLabel = New System.Windows.Forms.Label()
        Me.FanIndicatorLabel = New System.Windows.Forms.Label()
        Me.SystemTemperatureLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HouseTemperatureLabel = New System.Windows.Forms.Label()
        Me.DifferentialTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorPictureBox = New System.Windows.Forms.PictureBox()
        Me.ISULogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.FanIndicatorPictureBox = New System.Windows.Forms.PictureBox()
        Me.CoolingElementIndicatorPictureBox = New System.Windows.Forms.PictureBox()
        Me.HeatingElementIndicatorPictureBox = New System.Windows.Forms.PictureBox()
        Me.SafteyInterlockIndicatorPictureBox = New System.Windows.Forms.PictureBox()
        Me.PortStatePictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISULogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FanIndicatorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoolingElementIndicatorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeatingElementIndicatorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SafteyInterlockIndicatorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PortStatePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialPortToolStripMenuItem, Me.HVACSettingsToolStripMenuItem, Me.HVACSettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1003, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SerialPortToolStripMenuItem
        '
        Me.SerialPortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.SerialPortToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SerialPortToolStripMenuItem.Name = "SerialPortToolStripMenuItem"
        Me.SerialPortToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.SerialPortToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HVACSettingsToolStripMenuItem
        '
        Me.HVACSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.SettToolStripMenuItem, Me.ReloadSettingsToolStripMenuItem})
        Me.HVACSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HVACSettingsToolStripMenuItem.Name = "HVACSettingsToolStripMenuItem"
        Me.HVACSettingsToolStripMenuItem.Size = New System.Drawing.Size(85, 26)
        Me.HVACSettingsToolStripMenuItem.Text = "COM Port"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'SettToolStripMenuItem
        '
        Me.SettToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectedCOMPortToolStripMenuItem, Me.SelectedBaudRateToolStripMenuItem, Me.OpenSettingsToolStripMenuItem})
        Me.SettToolStripMenuItem.Name = "SettToolStripMenuItem"
        Me.SettToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.SettToolStripMenuItem.Text = "Settings"
        '
        'SelectedCOMPortToolStripMenuItem
        '
        Me.SelectedCOMPortToolStripMenuItem.Name = "SelectedCOMPortToolStripMenuItem"
        Me.SelectedCOMPortToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.SelectedCOMPortToolStripMenuItem.Text = "SelectedCOMPort"
        '
        'SelectedBaudRateToolStripMenuItem
        '
        Me.SelectedBaudRateToolStripMenuItem.Name = "SelectedBaudRateToolStripMenuItem"
        Me.SelectedBaudRateToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.SelectedBaudRateToolStripMenuItem.Text = "SelectedBaudRate"
        '
        'OpenSettingsToolStripMenuItem
        '
        Me.OpenSettingsToolStripMenuItem.Name = "OpenSettingsToolStripMenuItem"
        Me.OpenSettingsToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.OpenSettingsToolStripMenuItem.Text = "Open Settings"
        '
        'ReloadSettingsToolStripMenuItem
        '
        Me.ReloadSettingsToolStripMenuItem.Name = "ReloadSettingsToolStripMenuItem"
        Me.ReloadSettingsToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.ReloadSettingsToolStripMenuItem.Text = "Reload Settings"
        '
        'HVACSettingToolStripMenuItem
        '
        Me.HVACSettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveCurrentSettingsToolStripMenuItem, Me.ReloadSettingsToolStripMenuItem1})
        Me.HVACSettingToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HVACSettingToolStripMenuItem.Name = "HVACSettingToolStripMenuItem"
        Me.HVACSettingToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.HVACSettingToolStripMenuItem.Text = "HVAC Settings"
        '
        'SaveCurrentSettingsToolStripMenuItem
        '
        Me.SaveCurrentSettingsToolStripMenuItem.Name = "SaveCurrentSettingsToolStripMenuItem"
        Me.SaveCurrentSettingsToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.SaveCurrentSettingsToolStripMenuItem.Text = "Save Current Settings"
        '
        'ReloadSettingsToolStripMenuItem1
        '
        Me.ReloadSettingsToolStripMenuItem1.Name = "ReloadSettingsToolStripMenuItem1"
        Me.ReloadSettingsToolStripMenuItem1.Size = New System.Drawing.Size(236, 26)
        Me.ReloadSettingsToolStripMenuItem1.Text = "Reload Settings"
        '
        'SerialPort1
        '
        '
        'OverallTemperatureLabel
        '
        Me.OverallTemperatureLabel.AutoSize = True
        Me.OverallTemperatureLabel.Font = New System.Drawing.Font("Trebuchet MS", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverallTemperatureLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OverallTemperatureLabel.Location = New System.Drawing.Point(302, 181)
        Me.OverallTemperatureLabel.Name = "OverallTemperatureLabel"
        Me.OverallTemperatureLabel.Size = New System.Drawing.Size(404, 151)
        Me.OverallTemperatureLabel.TabIndex = 1
        Me.OverallTemperatureLabel.Text = "75.5ºF"
        Me.OverallTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Black
        Me.ExitButton.Location = New System.Drawing.Point(872, 538)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(116, 58)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Enabled = False
        Me.TimeLabel.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.Black
        Me.TimeLabel.Location = New System.Drawing.Point(339, 324)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(324, 152)
        Me.TimeLabel.TabIndex = 3
        Me.TimeLabel.Text = "00:00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12-12-2023" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'HighTempTextBox
        '
        Me.HighTempTextBox.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighTempTextBox.Location = New System.Drawing.Point(15, 146)
        Me.HighTempTextBox.Name = "HighTempTextBox"
        Me.HighTempTextBox.ReadOnly = True
        Me.HighTempTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HighTempTextBox.Size = New System.Drawing.Size(116, 23)
        Me.HighTempTextBox.TabIndex = 6
        '
        'HighUpButton
        '
        Me.HighUpButton.BackColor = System.Drawing.Color.Transparent
        Me.HighUpButton.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighUpButton.ForeColor = System.Drawing.Color.Black
        Me.HighUpButton.Location = New System.Drawing.Point(15, 175)
        Me.HighUpButton.Name = "HighUpButton"
        Me.HighUpButton.Size = New System.Drawing.Size(97, 32)
        Me.HighUpButton.TabIndex = 4
        Me.HighUpButton.Text = "High Up"
        Me.HighUpButton.UseVisualStyleBackColor = False
        '
        'HighDownButton
        '
        Me.HighDownButton.BackColor = System.Drawing.Color.Transparent
        Me.HighDownButton.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighDownButton.ForeColor = System.Drawing.Color.Black
        Me.HighDownButton.Location = New System.Drawing.Point(15, 213)
        Me.HighDownButton.Name = "HighDownButton"
        Me.HighDownButton.Size = New System.Drawing.Size(97, 31)
        Me.HighDownButton.TabIndex = 9
        Me.HighDownButton.Text = "High Down"
        Me.HighDownButton.UseVisualStyleBackColor = False
        '
        'LowDownButton
        '
        Me.LowDownButton.BackColor = System.Drawing.Color.Transparent
        Me.LowDownButton.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowDownButton.ForeColor = System.Drawing.Color.Black
        Me.LowDownButton.Location = New System.Drawing.Point(15, 335)
        Me.LowDownButton.Name = "LowDownButton"
        Me.LowDownButton.Size = New System.Drawing.Size(97, 31)
        Me.LowDownButton.TabIndex = 12
        Me.LowDownButton.Text = "Low Down"
        Me.LowDownButton.UseVisualStyleBackColor = False
        '
        'LowTempTextBox
        '
        Me.LowTempTextBox.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowTempTextBox.Location = New System.Drawing.Point(15, 268)
        Me.LowTempTextBox.Name = "LowTempTextBox"
        Me.LowTempTextBox.ReadOnly = True
        Me.LowTempTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LowTempTextBox.Size = New System.Drawing.Size(116, 23)
        Me.LowTempTextBox.TabIndex = 11
        '
        'LowUpButton
        '
        Me.LowUpButton.BackColor = System.Drawing.Color.Transparent
        Me.LowUpButton.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowUpButton.ForeColor = System.Drawing.Color.Black
        Me.LowUpButton.Location = New System.Drawing.Point(15, 297)
        Me.LowUpButton.Name = "LowUpButton"
        Me.LowUpButton.Size = New System.Drawing.Size(97, 32)
        Me.LowUpButton.TabIndex = 10
        Me.LowUpButton.Text = "Low Up"
        Me.LowUpButton.UseVisualStyleBackColor = False
        '
        'HighTempTextBoxLabel
        '
        Me.HighTempTextBoxLabel.AutoSize = True
        Me.HighTempTextBoxLabel.ForeColor = System.Drawing.Color.Black
        Me.HighTempTextBoxLabel.Location = New System.Drawing.Point(12, 127)
        Me.HighTempTextBoxLabel.Name = "HighTempTextBoxLabel"
        Me.HighTempTextBoxLabel.Size = New System.Drawing.Size(77, 16)
        Me.HighTempTextBoxLabel.TabIndex = 23
        Me.HighTempTextBoxLabel.Text = "High Temp:"
        '
        'LowTempTextBoxLabel
        '
        Me.LowTempTextBoxLabel.AutoSize = True
        Me.LowTempTextBoxLabel.ForeColor = System.Drawing.Color.Black
        Me.LowTempTextBoxLabel.Location = New System.Drawing.Point(12, 249)
        Me.LowTempTextBoxLabel.Name = "LowTempTextBoxLabel"
        Me.LowTempTextBoxLabel.Size = New System.Drawing.Size(73, 16)
        Me.LowTempTextBoxLabel.TabIndex = 24
        Me.LowTempTextBoxLabel.Text = "Low Temp:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'QYATHandleTimer
        '
        Me.QYATHandleTimer.Enabled = True
        Me.QYATHandleTimer.Interval = 250
        '
        'SafteyInterlockIndicatorLabel
        '
        Me.SafteyInterlockIndicatorLabel.AutoSize = True
        Me.SafteyInterlockIndicatorLabel.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SafteyInterlockIndicatorLabel.ForeColor = System.Drawing.Color.Black
        Me.SafteyInterlockIndicatorLabel.Location = New System.Drawing.Point(880, 40)
        Me.SafteyInterlockIndicatorLabel.Name = "SafteyInterlockIndicatorLabel"
        Me.SafteyInterlockIndicatorLabel.Size = New System.Drawing.Size(105, 18)
        Me.SafteyInterlockIndicatorLabel.TabIndex = 32
        Me.SafteyInterlockIndicatorLabel.Text = "Saftey Interlock:"
        '
        'HeatingElementIndicatorLabel
        '
        Me.HeatingElementIndicatorLabel.AutoSize = True
        Me.HeatingElementIndicatorLabel.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatingElementIndicatorLabel.ForeColor = System.Drawing.Color.Black
        Me.HeatingElementIndicatorLabel.Location = New System.Drawing.Point(881, 162)
        Me.HeatingElementIndicatorLabel.Name = "HeatingElementIndicatorLabel"
        Me.HeatingElementIndicatorLabel.Size = New System.Drawing.Size(104, 18)
        Me.HeatingElementIndicatorLabel.TabIndex = 34
        Me.HeatingElementIndicatorLabel.Text = "Heater Element:"
        '
        'CoolingElementIndicatorLabel
        '
        Me.CoolingElementIndicatorLabel.AutoSize = True
        Me.CoolingElementIndicatorLabel.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolingElementIndicatorLabel.ForeColor = System.Drawing.Color.Black
        Me.CoolingElementIndicatorLabel.Location = New System.Drawing.Point(881, 284)
        Me.CoolingElementIndicatorLabel.Name = "CoolingElementIndicatorLabel"
        Me.CoolingElementIndicatorLabel.Size = New System.Drawing.Size(107, 18)
        Me.CoolingElementIndicatorLabel.TabIndex = 36
        Me.CoolingElementIndicatorLabel.Text = "Cooling Element:"
        '
        'FanIndicatorLabel
        '
        Me.FanIndicatorLabel.AutoSize = True
        Me.FanIndicatorLabel.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FanIndicatorLabel.ForeColor = System.Drawing.Color.Black
        Me.FanIndicatorLabel.Location = New System.Drawing.Point(881, 406)
        Me.FanIndicatorLabel.Name = "FanIndicatorLabel"
        Me.FanIndicatorLabel.Size = New System.Drawing.Size(34, 18)
        Me.FanIndicatorLabel.TabIndex = 38
        Me.FanIndicatorLabel.Text = "Fan:"
        '
        'SystemTemperatureLabel
        '
        Me.SystemTemperatureLabel.AutoSize = True
        Me.SystemTemperatureLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemTemperatureLabel.ForeColor = System.Drawing.Color.Black
        Me.SystemTemperatureLabel.Location = New System.Drawing.Point(369, 476)
        Me.SystemTemperatureLabel.Name = "SystemTemperatureLabel"
        Me.SystemTemperatureLabel.Size = New System.Drawing.Size(250, 26)
        Me.SystemTemperatureLabel.TabIndex = 39
        Me.SystemTemperatureLabel.Text = "System Temperature: 75ºF"
        Me.SystemTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HouseTemperatureLabel
        '
        Me.HouseTemperatureLabel.AutoSize = True
        Me.HouseTemperatureLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HouseTemperatureLabel.ForeColor = System.Drawing.Color.Black
        Me.HouseTemperatureLabel.Location = New System.Drawing.Point(390, 149)
        Me.HouseTemperatureLabel.Name = "HouseTemperatureLabel"
        Me.HouseTemperatureLabel.Size = New System.Drawing.Size(202, 26)
        Me.HouseTemperatureLabel.TabIndex = 42
        Me.HouseTemperatureLabel.Text = "House Temperature: "
        '
        'DifferentialTimer
        '
        Me.DifferentialTimer.Enabled = True
        Me.DifferentialTimer.Interval = 5000
        '
        'ErrorPictureBox
        '
        Me.ErrorPictureBox.Location = New System.Drawing.Point(9, 390)
        Me.ErrorPictureBox.Name = "ErrorPictureBox"
        Me.ErrorPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.ErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ErrorPictureBox.TabIndex = 43
        Me.ErrorPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ErrorPictureBox, "If you can see the sad face," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "an error has occured and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "system maintenace is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "re" &
        "quired :(")
        '
        'ISULogoPictureBox
        '
        Me.ISULogoPictureBox.Image = Global.HVAC_Final_Program.My.Resources.Resources.Bengal
        Me.ISULogoPictureBox.Location = New System.Drawing.Point(9, 40)
        Me.ISULogoPictureBox.Name = "ISULogoPictureBox"
        Me.ISULogoPictureBox.Size = New System.Drawing.Size(82, 84)
        Me.ISULogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ISULogoPictureBox.TabIndex = 41
        Me.ISULogoPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ISULogoPictureBox, "HVAC System Program" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Designed By: Joshua Makuch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fall 2023 - RCET")
        '
        'FanIndicatorPictureBox
        '
        Me.FanIndicatorPictureBox.Location = New System.Drawing.Point(884, 425)
        Me.FanIndicatorPictureBox.Name = "FanIndicatorPictureBox"
        Me.FanIndicatorPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.FanIndicatorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FanIndicatorPictureBox.TabIndex = 37
        Me.FanIndicatorPictureBox.TabStop = False
        '
        'CoolingElementIndicatorPictureBox
        '
        Me.CoolingElementIndicatorPictureBox.Location = New System.Drawing.Point(884, 303)
        Me.CoolingElementIndicatorPictureBox.Name = "CoolingElementIndicatorPictureBox"
        Me.CoolingElementIndicatorPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.CoolingElementIndicatorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CoolingElementIndicatorPictureBox.TabIndex = 35
        Me.CoolingElementIndicatorPictureBox.TabStop = False
        '
        'HeatingElementIndicatorPictureBox
        '
        Me.HeatingElementIndicatorPictureBox.Location = New System.Drawing.Point(884, 181)
        Me.HeatingElementIndicatorPictureBox.Name = "HeatingElementIndicatorPictureBox"
        Me.HeatingElementIndicatorPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.HeatingElementIndicatorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HeatingElementIndicatorPictureBox.TabIndex = 33
        Me.HeatingElementIndicatorPictureBox.TabStop = False
        '
        'SafteyInterlockIndicatorPictureBox
        '
        Me.SafteyInterlockIndicatorPictureBox.Location = New System.Drawing.Point(883, 59)
        Me.SafteyInterlockIndicatorPictureBox.Name = "SafteyInterlockIndicatorPictureBox"
        Me.SafteyInterlockIndicatorPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.SafteyInterlockIndicatorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SafteyInterlockIndicatorPictureBox.TabIndex = 31
        Me.SafteyInterlockIndicatorPictureBox.TabStop = False
        '
        'PortStatePictureBox
        '
        Me.PortStatePictureBox.Location = New System.Drawing.Point(9, 496)
        Me.PortStatePictureBox.Name = "PortStatePictureBox"
        Me.PortStatePictureBox.Size = New System.Drawing.Size(100, 100)
        Me.PortStatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PortStatePictureBox.TabIndex = 26
        Me.PortStatePictureBox.TabStop = False
        '
        'HVAC_Final_Program_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1003, 608)
        Me.Controls.Add(Me.ErrorPictureBox)
        Me.Controls.Add(Me.HouseTemperatureLabel)
        Me.Controls.Add(Me.ISULogoPictureBox)
        Me.Controls.Add(Me.SystemTemperatureLabel)
        Me.Controls.Add(Me.FanIndicatorLabel)
        Me.Controls.Add(Me.FanIndicatorPictureBox)
        Me.Controls.Add(Me.CoolingElementIndicatorLabel)
        Me.Controls.Add(Me.CoolingElementIndicatorPictureBox)
        Me.Controls.Add(Me.HeatingElementIndicatorLabel)
        Me.Controls.Add(Me.HeatingElementIndicatorPictureBox)
        Me.Controls.Add(Me.SafteyInterlockIndicatorLabel)
        Me.Controls.Add(Me.SafteyInterlockIndicatorPictureBox)
        Me.Controls.Add(Me.PortStatePictureBox)
        Me.Controls.Add(Me.LowTempTextBoxLabel)
        Me.Controls.Add(Me.HighTempTextBoxLabel)
        Me.Controls.Add(Me.LowDownButton)
        Me.Controls.Add(Me.LowTempTextBox)
        Me.Controls.Add(Me.LowUpButton)
        Me.Controls.Add(Me.HighDownButton)
        Me.Controls.Add(Me.HighTempTextBox)
        Me.Controls.Add(Me.HighUpButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.OverallTemperatureLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HVAC_Final_Program_Form"
        Me.Text = "HVAC_Final_Program_Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISULogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FanIndicatorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoolingElementIndicatorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeatingElementIndicatorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SafteyInterlockIndicatorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PortStatePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SerialPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HVACSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HVACSettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverallTemperatureLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HighTempTextBox As TextBox
    Friend WithEvents HighUpButton As Button
    Friend WithEvents HighDownButton As Button
    Friend WithEvents LowDownButton As Button
    Friend WithEvents LowTempTextBox As TextBox
    Friend WithEvents LowUpButton As Button
    Friend WithEvents SelectedCOMPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedBaudRateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighTempTextBoxLabel As Label
    Friend WithEvents LowTempTextBoxLabel As Label
    Friend WithEvents PortStatePictureBox As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents QYATHandleTimer As Timer
    Friend WithEvents SafteyInterlockIndicatorPictureBox As PictureBox
    Friend WithEvents SafteyInterlockIndicatorLabel As Label
    Friend WithEvents HeatingElementIndicatorLabel As Label
    Friend WithEvents HeatingElementIndicatorPictureBox As PictureBox
    Friend WithEvents CoolingElementIndicatorLabel As Label
    Friend WithEvents CoolingElementIndicatorPictureBox As PictureBox
    Friend WithEvents FanIndicatorLabel As Label
    Friend WithEvents FanIndicatorPictureBox As PictureBox
    Friend WithEvents SystemTemperatureLabel As Label
    Friend WithEvents ISULogoPictureBox As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HouseTemperatureLabel As Label
    Friend WithEvents SaveCurrentSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadSettingsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DifferentialTimer As Timer
    Friend WithEvents ErrorPictureBox As PictureBox
End Class
