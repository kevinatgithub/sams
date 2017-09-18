Imports MySql.Data.MySqlClient

Public Class Time_Keeping
    Inherits MetroFramework.Forms.MetroForm
    Implements DPFP.Capture.EventHandler

    Private State As Integer = 0
    Public LeftVerifier, RightVerifier As DPFP.Verification.Verification
    Public Capturer As DPFP.Capture.Capture
    Private Employees As New Collection

    Sub New()

        InitializeComponent()
        LoadTemplates()
        PrepareScanner()

    End Sub

    Sub LoadTemplates()
        Dim result As MySqlDataReader = Database.DB.Execute("SELECT * FROM employee  WHERE (left_finger IS NOT NULL OR right_finger IS NOT NULL) and disabled_dt IS NULL")
        If result.HasRows Then
            Dim ms1, ms2 As IO.MemoryStream

            While result.Read
                Dim e As New Employee
                e.Fname = result("fname")
                e.Mname = result("mname")
                e.Lname = result("lname")
                e.Id = result("id")
                e.Employee_no = result("employee_no")
                e.Position = result("position")
                e.Office = Office.FindOfficeById(result("office"), Office.Offices)
                e.Profile_pic_img = CanYou.ConvertByteToImage(result("profile_pic"))

                e.Left_finger = CanYou.HandleDBNull(result("left_finger"))
                If (Not e.Left_finger Is Nothing) Then
                    ms1 = New IO.MemoryStream(e.Left_finger)
                    e.LeftFingerTemplate = New DPFP.Template(ms1)
                End If

                e.Right_finger = CanYou.HandleDBNull(result("right_finger"))
                If (Not e.Right_finger Is Nothing) Then
                    ms2 = New IO.MemoryStream(e.Right_finger)
                    e.RightFingerTemplate = New DPFP.Template(ms2)
                End If


                Employees.Add(e)
            End While

        End If

    End Sub

    Sub PrepareScanner()
        LeftVerifier = New DPFP.Verification.Verification
        RightVerifier = New DPFP.Verification.Verification

        Capturer = FingerPrint.InitializeCapturer(Me)

    End Sub

    Private Sub Time_Keeping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.F1 Then
            ButtonStateUpdate(1, btn_am_in)
        ElseIf e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.F2 Then
            ButtonStateUpdate(2, btn_am_out)
        ElseIf e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.F3 Then
            ButtonStateUpdate(3, btn_pm_in)
        ElseIf e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.F4 Then
            ButtonStateUpdate(4, btn_pm_out)
        ElseIf e.KeyCode = Keys.F12 Then
            Dim UserLogin As New User_Login(Me)
            UserLogin.Show()
        Else
            ReleaseKeyPressed()
        End If
    End Sub

    Private Sub btn_am_in_Click(sender As Object, e As EventArgs) Handles btn_am_in.Click
        ButtonStateUpdate(1, btn_am_in)
    End Sub

    Private Sub btn_am_out_Click(sender As Object, e As EventArgs) Handles btn_am_out.Click
        ButtonStateUpdate(2, btn_am_out)
    End Sub

    Private Sub btn_pm_in_Click(sender As Object, e As EventArgs) Handles btn_pm_in.Click
        ButtonStateUpdate(3, btn_pm_in)
    End Sub

    Private Sub btn_pm_out_Click(sender As Object, e As EventArgs) Handles btn_pm_out.Click
        ButtonStateUpdate(4, btn_pm_out)
    End Sub

    Sub ButtonStateUpdate(key As Integer, btn As Button)
        ReleaseKeyPressed()
        ClearScreen()
        If State = key Then
            FingerPrint.StopCapture(Capturer)
            State = 0
            ChangeColor(btn, False)
            lbl_mode.Text = ""
        Else
            Select Case key
                Case 1
                    lbl_mode.Text = "AM TIME IN"
                Case 2
                    lbl_mode.Text = "AM TIME OUT"
                Case 3
                    lbl_mode.Text = "PM TIME IN"
                Case 4
                    lbl_mode.Text = "PM TIME OUT"
            End Select
            My.Computer.Audio.Play(My.Resources.up_chime1, AudioPlayMode.Background)
            State = key
            ChangeColor(btn, True)

            FingerPrint.StartCapture(Capturer)
        End If
    End Sub

    Sub ReleaseKeyPressed()
        ChangeColor(btn_am_in, False)
        ChangeColor(btn_am_out, False)
        ChangeColor(btn_pm_in, False)
        ChangeColor(btn_pm_out, False)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbl_time.Text = TimeOfDay.ToString("h:mm:ss tt")
        lbl_date.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub ChangeColor(btn As Button, mode As Boolean)
        If mode Then
            btn.BackColor = Color.FromArgb(239, 114, 102)
        Else
            btn.BackColor = Color.FromArgb(234, 234, 234)
        End If
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = FingerPrint.ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)

        ' Check quality of the sample and start verification if it's good
        If Not features Is Nothing Then
            Dim i As Integer = 0
            For Each Employee As Employee In Employees
                ' Compare the feature set with our template
                Dim LeftResult As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
                Dim RightResult As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()

                If Not IsNothing(Employee.LeftFingerTemplate) Then
                    LeftVerifier.Verify(features, Employee.LeftFingerTemplate, LeftResult)
                End If

                If Not IsNothing(Employee.RightFingerTemplate) Then
                    RightVerifier.Verify(features, Employee.RightFingerTemplate, RightResult)
                End If

                If LeftResult.Verified Then
                    Employee.ScanResult = LeftResult.Verified
                    Invoke(New FunctionCall(AddressOf _updateResult), Employee)
                ElseIf RightResult.Verified Then
                    Employee.ScanResult = RightResult.Verified
                    Invoke(New FunctionCall(AddressOf _updateResult), Employee)
                Else
                    i += 1
                    If i >= Employees.Count Then
                        Invoke(New FunctionCall(AddressOf _verificationFailed), i)
                    End If
                End If



            Next

        End If
    End Sub

    Sub _updateResult(ByVal Employee As Employee)

        If Employee.ScanResult Then
            FingerPrint.StopCapture(Capturer)

            Select Case State
                Case 1
                    lbl_mode.Text = "AM TIME IN"
                Case 2
                    lbl_mode.Text = "AM TIME OUT"
                Case 3
                    lbl_mode.Text = "PM TIME IN"
                Case 4
                    lbl_mode.Text = "PM TIME OUT"
            End Select

            lbl_mode.Visible = True
            lbl_fullname.Text = Employee.Fname & " " & Employee.Mname & " " & Employee.Lname
            lbl_position.Text = Employee.Position
            lbl_office.Text = Employee.Office.Name
            lbl_time_log.Text = lbl_time.Text
            If Not Employee.Profile_pic_img Is Nothing Then
                pb_photo.Image = Employee.Profile_pic_img
                pb_photo.Visible = True
                pb_photo_default.Visible = False
            Else
                pb_photo.Image = Nothing
                pb_photo.Visible = False
                pb_photo_default.Visible = True
            End If

            Database.DB.Execute("INSERT INTO `log` VALUES (null,'" & Employee.Id & "','" & State & "',CurDate(),'" & Date.Today.Year & "','" & Date.Today.Month & "','" & Date.Today.Day & "','" & TimeOfDay.ToString("H:mm:ss") & "')")
            My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
            'Dim SAPI
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.Speak("Welcome " & Employee.Fname & " " & Employee.Mname & " " & Employee.Lname)
            State = 0
            ReleaseKeyPressed()
            Dim de As New DelayedExecution(3000, Me)

        End If

    End Sub

    Sub _verificationFailed()
        ClearScreen()
        lbl_mode.Text = "Verification Failed"
        lbl_time_log.Text = "Please Try Again"
        FingerPrint.StopCapture(Capturer)
        State = 0
        ReleaseKeyPressed()
        My.Computer.Audio.Play(My.Resources._error, AudioPlayMode.Background)
        Dim de As New DelayedExecution(3000, Me)
    End Sub

    Sub ClearScreen()
        pb_photo.Image = Nothing
        pb_photo.Visible = False
        pb_photo_default.Visible = False
        lbl_fullname.Text = ""
        lbl_position.Text = ""
        lbl_office.Text = ""
        lbl_mode.Text = ""
        lbl_time_log.Text = ""
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality

    End Sub

    Class DelayedExecution
        Dim WithEvents dt As System.Windows.Forms.Timer
        Dim caller As Object

        Sub New(interval As Integer, caller As Object)
            Me.caller = caller
            dt = New System.Windows.Forms.Timer
            dt.Interval = interval
            dt.Start()
        End Sub

        Private Sub dt_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles dt.Tick
            caller.ReleaseKeyPressed()
            caller.ClearScreen()
            dt.Stop()
        End Sub
    End Class
End Class