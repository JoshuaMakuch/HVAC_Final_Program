'Joshua Makuch
'RCET 3371
'December 1, 2023
'HVAC_Final_Program_Form
'https://github.com/JoshuaMakuch/HVAC_Final_Program

Imports System.IO.Ports
Imports System.Threading

Public Class HVAC_Final_Program_Form

    Public GrowlGreyLight As Color = Color.FromArgb(230, 231, 232)
    Public GrowlGreyMed As Color = Color.FromArgb(167, 167, 167)
    Public GrowlGrey As Color = Color.FromArgb(130, 130, 130)
    Public Roarange As Color = Color.FromArgb(244, 121, 32)
    Public RoarangeL As Color = Color.FromArgb(246, 146, 64)
    Public BengalBlack As Color = Color.FromArgb(0, 0, 0)
    Dim HVACSettingsFileName As String = CurDir() & "\" & "HVAC_Settings" & ".txt"
    Dim COMPortFileName As String = CurDir() & "\" & "COMPortSettings" & ".txt"
    Dim SelectedCOMPort As String
    Dim SelectedBaudRate As String
    Dim PortState As Boolean
    Public receiveByte(18) As Byte 'Receive Data Bytes
    Dim NewData As Integer
    Dim DataIn1, DataIn2, DataIn3, DataIn4, DataIn5, DataIn6, DataIn7, DataIn8 As Integer
    Dim SafteyInterlockIndicator, HeatingElementIndicator, CoolingElementIndicator, SystemFanIndicator As Boolean
    Dim QYATBoardSampleTime As Integer

    Dim HighTemp As Double = 90
    Dim LowTemp As Double = 50
    Dim CurrentTemp As Double


    'Handles timer 1 tick
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = CStr(TimeString & vbCrLf & DateString)

        'Port State Indicator Handle
        If PortState Then
            ConnectToolStripMenuItem.Text = "Disconnect"
            PortStatePictureBox.Image = My.Resources.PortStateOn
        ElseIf Not PortState Then
            ConnectToolStripMenuItem.Text = "Connect"
            PortStatePictureBox.Image = My.Resources.PortStateOff
        End If

        'Saftey Interlock Indicator Handle
        If SafteyInterlockIndicator Then
            SafteyInterlockIndicatorPictureBox.Image = My.Resources.SafteyOn
        ElseIf Not SafteyInterlockIndicator Then
            SafteyInterlockIndicatorPictureBox.Image = My.Resources.SafteyOff
        End If

        'Heating Element Indicator Handle
        If HeatingElementIndicator Then
            HeatingElementIndicatorPictureBox.Image = My.Resources.HeatOn
        ElseIf Not HeatingElementIndicator Then
            HeatingElementIndicatorPictureBox.Image = My.Resources.HeatOff
        End If

        'Cooling Element Indicator Handle
        If CoolingElementIndicator Then
            CoolingElementIndicatorPictureBox.Image = My.Resources.CoolingOn
        ElseIf Not CoolingElementIndicator Then
            CoolingElementIndicatorPictureBox.Image = My.Resources.CoolingOff
        End If

        'System Fan Indicator Handle
        If SystemFanIndicator Then
            FanIndicatorPictureBox.Image = My.Resources.FanOn
        ElseIf Not SystemFanIndicator Then
            FanIndicatorPictureBox.Image = My.Resources.FanOff
        End If


    End Sub

    'Handles Exit Button Press
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Handles High up button press
    Private Sub HighUpButton_Click(sender As Object, e As EventArgs) Handles HighUpButton.Click
        If HighTemp + 0.5 < 90.1 Then
            HighTemp += 0.5
            HighTempTextBox.Text = CStr(Math.Round(HighTemp, 1)) & " ºF"
        End If
    End Sub

    'Handles High down button press
    Private Sub HighDownButton_Click(sender As Object, e As EventArgs) Handles HighDownButton.Click
        If HighTemp - 0.5 > 49.9 And HighTemp - 0.5 > LowTemp Then
            HighTemp -= 0.5
            HighTempTextBox.Text = CStr(Math.Round(HighTemp, 1)) & " ºF"
        End If
    End Sub

    'Handles Low up button press
    Private Sub LowUpButton_Click(sender As Object, e As EventArgs) Handles LowUpButton.Click
        If LowTemp + 0.5 < 90.1 And LowTemp + 0.5 < HighTemp Then
            LowTemp += 0.5
            LowTempTextBox.Text = CStr(Math.Round(LowTemp, 1)) & " ºF"
        End If
    End Sub

    'Handles Low down button Press
    Private Sub LowDownButton_Click(sender As Object, e As EventArgs) Handles LowDownButton.Click
        If LowTemp - 0.5 > 49.9 Then
            LowTemp -= 0.5
            LowTempTextBox.Text = CStr(Math.Round(LowTemp, 1)) & " ºF"
        End If
    End Sub

    'When the form loads
    Private Sub HVAC_Final_Program_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FileOpen(1, HVACSettingsFileName, OpenMode.Input) 'Open file for input
            Input(1, HighTemp)
            Input(1, LowTemp)
            FileClose(1)
        Catch ex As Exception
            MsgBox("HVAC Settings file not found or corrupted, creating a new one...")
            FileClose(1)
            FileOpen(1, HVACSettingsFileName, OpenMode.Output) 'Open file for output (write access)
            Write(1, 90, 50)
            FileClose(1)
        End Try

        Try
            FileOpen(1, HVACSettingsFileName, OpenMode.Input) 'Open file for input
            Input(1, HighTemp)
            Input(1, LowTemp)
            FileClose(1)
        Catch ex As Exception
            FileClose(1)
        End Try

        HighTempTextBox.Text = CStr(Math.Round(HighTemp, 1)) & " ºF"
        LowTempTextBox.Text = CStr(Math.Round(LowTemp, 1)) & " ºF"

        'Reloads COM Port Settings file
        ReloadSettingsToolStripMenuItem_Click(sender, e)
    End Sub

    'When the form closes, attempt to close the serial port
    Private Sub HVAC_Final_Program_Form_UnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Close()
    End Sub


    '***************************************************
    'Serial Port Handling Subs
    '***************************************************



    'When COM port settings tool strip button is clicked
    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettToolStripMenuItem.Click
        COMPortSettingsForm.Show()
    End Sub

    'When the COM Port settings reload button is pressed
    Private Sub ReloadSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadSettingsToolStripMenuItem.Click
        'Attempt to reload the Com port settings file, if not declare a lack of settings file
        Try
            FileOpen(1, COMPortFileName, OpenMode.Input) 'Open file for input
            Input(1, SelectedCOMPort)
            Input(1, SelectedBaudRate)
            FileClose(1)
            SelectedCOMPort = SelectedCOMPort.Replace(ChrW(34), "").Trim()
            SelectedBaudRate = SelectedBaudRate.Replace(ChrW(34), "").Trim()
            SelectedCOMPortToolStripMenuItem.Text = "Selected COM Port: " & CStr(SelectedCOMPort)
            SelectedBaudRateToolStripMenuItem.Text = "Selected Baud Rate: " & CStr(SelectedBaudRate)
        Catch ex As Exception
            MsgBox("Settings file not found, please open settings to create one.")
            FileClose(1)
        End Try
    End Sub

    'When the COM Port connect button is pressed
    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        'Will attempt to connect to the serial port if not alread connected
        If Not PortState Then
            If SelectedBaudRate <> "" Then SerialPort1.BaudRate = SelectedBaudRate
            If SelectedCOMPort <> "" Then SerialPort1.PortName = SelectedCOMPort
            Try
                SerialPort1.Open()
                PortState = True
            Catch ex As Exception
                SerialPort1.Close()
                PortState = False
                MsgBox("Port Already Open Or Port Unavailable. Potentially try reload settings file in menu strip.")
            End Try
        Else 'If already connected then assume the user is trying to DC when pressing this again, attempt to disconnect
            Try
                SerialPort1.Close()
                PortState = False
            Catch ex As Exception
                PortState = True
                MsgBox("Port Close Failed")
            End Try
        End If
    End Sub

    'Whenever the com port says we have information
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        'This allows the input buffer to be filled, once it has `10mS later, it will push the data to receivebyte()
        Thread.Sleep(10)
        SerialPort1.Read(receiveByte, 0, 1) 'This receives new data from the serial port

        SerialPort1.DiscardInBuffer()

    End Sub



    '***************************************************
    'QY@ Board Handling
    '***************************************************



    'This is for gathering info from the QY@ board
    Private Sub QYATHandleTimer_tick(sender As Object, e As EventArgs) Handles QYATHandleTimer.Tick
        If PortState Then
            QYBoardTabHandle()
        End If
    End Sub

    'This is used to handle the QY@ board tab
    Sub QYBoardTabHandle()

        Dim SleepDelay As Integer = 25

        Try
            SerialPort1.Write({81}, 0, 1) 'Writes a 51h to the serialport
        Catch ex As Exception

        End Try

        Thread.Sleep(SleepDelay)

        'This will then attempt to convert the received left-justified data bytes from the QY@ boards analog channel 1 to usable data (0-1023)
        Try
            Dim AnaInVal1 As Integer = (Convert.ToInt32(Hex(receiveByte(0)), 16)) * 4 + (Convert.ToInt32(Hex(receiveByte(1)), 16) / 64)
            OverallTemperatureLabel.Text = CStr(Math.Round(AnaInVal1 * 5 / 1023, 2) * 100) & "ºF"
            SystemTemperatureLabel.Text = CStr(Math.Round(AnaInVal1 * 3.3 / 1023, 3)) & " V"
        Catch ex As Exception

        End Try

        Thread.Sleep(SleepDelay)

        Try
            SerialPort1.Write({82, 0}, 0, 1) 'Writes a 52h to the serialport
        Catch ex As Exception

        End Try

        Thread.Sleep(SleepDelay)

        'This will then attempt to convert the received left-justified data bytes from the QY@ boards analog channel 2 to usable data (0-1023)
        Try
            Dim AnaInVal2 As Integer = (Convert.ToInt32(Hex(receiveByte(0)), 16)) * 4 + (Convert.ToInt32(Hex(receiveByte(1)), 16) / 64)
            'SystemTemperatureLabel.Text = CStr(Math.Round(AnaInVal2 * 2.178 / 1023, 2) * 100) & "ºF"
        Catch ex As Exception

        End Try

        Thread.Sleep(SleepDelay)

        Try
            Dim FinalDec As Integer 'This holds onto all weighted data for digital indicators

            If SafteyInterlockIndicator Then FinalDec = FinalDec + 1
            If HeatingElementIndicator Then FinalDec = FinalDec + 2
            If CoolingElementIndicator Then FinalDec = FinalDec + 4
            If SystemFanIndicator Then FinalDec = FinalDec + 8

            SerialPort1.Write({48, 32, FinalDec}, 0, 3) 'Writes a 30h & 20h & IndicatorDecimal to the serialport
        Catch ex As Exception

        End Try

        Thread.Sleep(SleepDelay)

        'This will then attempt to convert the received left-justified data bytes from the QY@ boards analog channel 1 to usable data (0-1023)
        Try
            Dim DigInVal As Integer = (Convert.ToInt32(Hex(receiveByte(0)), 16))
            If DigInVal >= 128 Then DigInVal -= 128
            If DigInVal >= 64 Then DigInVal -= 64
            If DigInVal >= 32 Then DigInVal -= 32
            If DigInVal >= 16 Then DigInVal -= 16
            If DigInVal >= 8 Then SafteyInterlockIndicator = False : DigInVal -= 8 Else SafteyInterlockIndicator = True
            If DigInVal >= 4 Then HeatingElementIndicator = False : DigInVal -= 4 Else HeatingElementIndicator = True
            If DigInVal >= 2 Then CoolingElementIndicator = False : DigInVal -= 2 Else CoolingElementIndicator = True
            If DigInVal >= 1 Then SystemFanIndicator = False : DigInVal -= 1 Else SystemFanIndicator = True
        Catch ex As Exception

        End Try

        Thread.Sleep(SleepDelay)
    End Sub

    'This is called a lot so it was put into a sub. This will close the serial port and set all appropriate parameters
    Private Sub PortIsBad()
        SerialPort1.Close()
        PortState = False
        MsgBox("Please configure and open serial port to procede") 'Failure if port is not open
    End Sub



    '***************************************************
End Class
