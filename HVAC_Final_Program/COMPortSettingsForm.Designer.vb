<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COMPortSettingsForm
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
        Me.COMSelectedCOMPortListBox = New System.Windows.Forms.Label()
        Me.COMPortSelectedTextBox = New System.Windows.Forms.TextBox()
        Me.COMScanButton = New System.Windows.Forms.Button()
        Me.COMPortSelectListBox = New System.Windows.Forms.ListBox()
        Me.COMSaveSettingsButton = New System.Windows.Forms.Button()
        Me.COMBaudRateDomainLabel = New System.Windows.Forms.Label()
        Me.COMBaudRateDomain = New System.Windows.Forms.DomainUpDown()
        Me.COMReturnButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'COMSelectedCOMPortListBox
        '
        Me.COMSelectedCOMPortListBox.AutoSize = True
        Me.COMSelectedCOMPortListBox.Location = New System.Drawing.Point(12, 11)
        Me.COMSelectedCOMPortListBox.Name = "COMSelectedCOMPortListBox"
        Me.COMSelectedCOMPortListBox.Size = New System.Drawing.Size(127, 16)
        Me.COMSelectedCOMPortListBox.TabIndex = 20
        Me.COMSelectedCOMPortListBox.Text = "Selected COM Port: "
        '
        'COMPortSelectedTextBox
        '
        Me.COMPortSelectedTextBox.Enabled = False
        Me.COMPortSelectedTextBox.Location = New System.Drawing.Point(15, 30)
        Me.COMPortSelectedTextBox.Name = "COMPortSelectedTextBox"
        Me.COMPortSelectedTextBox.Size = New System.Drawing.Size(189, 22)
        Me.COMPortSelectedTextBox.TabIndex = 19
        '
        'COMScanButton
        '
        Me.COMScanButton.Location = New System.Drawing.Point(210, 14)
        Me.COMScanButton.Name = "COMScanButton"
        Me.COMScanButton.Size = New System.Drawing.Size(106, 61)
        Me.COMScanButton.TabIndex = 18
        Me.COMScanButton.Text = "Scan"
        Me.COMScanButton.UseVisualStyleBackColor = True
        '
        'COMPortSelectListBox
        '
        Me.COMPortSelectListBox.FormattingEnabled = True
        Me.COMPortSelectListBox.ItemHeight = 16
        Me.COMPortSelectListBox.Location = New System.Drawing.Point(15, 58)
        Me.COMPortSelectListBox.Name = "COMPortSelectListBox"
        Me.COMPortSelectListBox.Size = New System.Drawing.Size(189, 180)
        Me.COMPortSelectListBox.TabIndex = 17
        '
        'COMSaveSettingsButton
        '
        Me.COMSaveSettingsButton.Location = New System.Drawing.Point(510, 362)
        Me.COMSaveSettingsButton.Name = "COMSaveSettingsButton"
        Me.COMSaveSettingsButton.Size = New System.Drawing.Size(136, 78)
        Me.COMSaveSettingsButton.TabIndex = 16
        Me.COMSaveSettingsButton.Text = "Save Settings"
        Me.COMSaveSettingsButton.UseVisualStyleBackColor = True
        '
        'COMBaudRateDomainLabel
        '
        Me.COMBaudRateDomainLabel.AutoSize = True
        Me.COMBaudRateDomainLabel.Location = New System.Drawing.Point(12, 241)
        Me.COMBaudRateDomainLabel.Name = "COMBaudRateDomainLabel"
        Me.COMBaudRateDomainLabel.Size = New System.Drawing.Size(134, 16)
        Me.COMBaudRateDomainLabel.TabIndex = 15
        Me.COMBaudRateDomainLabel.Text = "Selected Baud Rate: "
        '
        'COMBaudRateDomain
        '
        Me.COMBaudRateDomain.Items.Add("921500")
        Me.COMBaudRateDomain.Items.Add("460800")
        Me.COMBaudRateDomain.Items.Add("230400")
        Me.COMBaudRateDomain.Items.Add("115200")
        Me.COMBaudRateDomain.Items.Add("57600")
        Me.COMBaudRateDomain.Items.Add("38400")
        Me.COMBaudRateDomain.Items.Add("19200")
        Me.COMBaudRateDomain.Items.Add("9600")
        Me.COMBaudRateDomain.Items.Add("4800")
        Me.COMBaudRateDomain.Items.Add("2400")
        Me.COMBaudRateDomain.Items.Add("1200")
        Me.COMBaudRateDomain.Location = New System.Drawing.Point(12, 260)
        Me.COMBaudRateDomain.Name = "COMBaudRateDomain"
        Me.COMBaudRateDomain.ReadOnly = True
        Me.COMBaudRateDomain.Size = New System.Drawing.Size(189, 22)
        Me.COMBaudRateDomain.TabIndex = 14
        Me.COMBaudRateDomain.Text = "Baud Rate"
        '
        'COMReturnButton
        '
        Me.COMReturnButton.Location = New System.Drawing.Point(652, 362)
        Me.COMReturnButton.Name = "COMReturnButton"
        Me.COMReturnButton.Size = New System.Drawing.Size(136, 78)
        Me.COMReturnButton.TabIndex = 13
        Me.COMReturnButton.Text = "Return"
        Me.COMReturnButton.UseVisualStyleBackColor = True
        '
        'COMPortSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.COMSelectedCOMPortListBox)
        Me.Controls.Add(Me.COMPortSelectedTextBox)
        Me.Controls.Add(Me.COMScanButton)
        Me.Controls.Add(Me.COMPortSelectListBox)
        Me.Controls.Add(Me.COMSaveSettingsButton)
        Me.Controls.Add(Me.COMBaudRateDomainLabel)
        Me.Controls.Add(Me.COMBaudRateDomain)
        Me.Controls.Add(Me.COMReturnButton)
        Me.Name = "COMPortSettingsForm"
        Me.Text = "COMPortSettingsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents COMSelectedCOMPortListBox As Label
    Friend WithEvents COMPortSelectedTextBox As TextBox
    Friend WithEvents COMScanButton As Button
    Friend WithEvents COMPortSelectListBox As ListBox
    Friend WithEvents COMSaveSettingsButton As Button
    Friend WithEvents COMBaudRateDomainLabel As Label
    Friend WithEvents COMBaudRateDomain As DomainUpDown
    Friend WithEvents COMReturnButton As Button
End Class
