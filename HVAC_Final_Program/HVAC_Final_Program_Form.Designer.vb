<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HVAC_Final_Program_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SerialPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HVACSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HVACSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialPortToolStripMenuItem, Me.HVACSettingsToolStripMenuItem, Me.HVACSettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SerialPortToolStripMenuItem
        '
        Me.SerialPortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.SerialPortToolStripMenuItem.Name = "SerialPortToolStripMenuItem"
        Me.SerialPortToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.SerialPortToolStripMenuItem.Text = "File"
        '
        'HVACSettingsToolStripMenuItem
        '
        Me.HVACSettingsToolStripMenuItem.Name = "HVACSettingsToolStripMenuItem"
        Me.HVACSettingsToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.HVACSettingsToolStripMenuItem.Text = "COM Port"
        '
        'HVACSettingToolStripMenuItem
        '
        Me.HVACSettingToolStripMenuItem.Name = "HVACSettingToolStripMenuItem"
        Me.HVACSettingToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.HVACSettingToolStripMenuItem.Text = "HVAC Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HVAC_Final_Program_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 565)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HVAC_Final_Program_Form"
        Me.Text = "HVAC_Final_Program_Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SerialPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HVACSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HVACSettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
