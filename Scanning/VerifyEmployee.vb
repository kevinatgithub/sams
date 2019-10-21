Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient

Public Class VerifyEmployee
    Inherits MetroFramework.Forms.MetroForm
    Implements DPFP.Capture.EventHandler

    Public LeftVerifier, RightVerifier As DPFP.Verification.Verification
    Public Capturer As DPFP.Capture.Capture
    Private Employees As New Collection

    Sub New()

        InitializeComponent()
        LoadTemplates()
        PrepareScanner()

        lbl_status.Text = "Place your finger on the fingerprint reader."
        FingerPrint.StartCapture(Capturer)

    End Sub

    Sub unload() Handles Me.FormClosing
        Employees = New Collection
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

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
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

                Try
                    Invoke(New FunctionCall(AddressOf _drawFinger), FingerPrint.ConvertSampleToBitmap(Sample))
                Catch ex As Exception

                End Try


            Next

        End If
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        Invoke(New FunctionCall(AddressOf _updateStatus), 4)
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        Invoke(New FunctionCall(AddressOf _updateStatus), 1)
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        Invoke(New FunctionCall(AddressOf _updateStatus), 2)
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        Invoke(New FunctionCall(AddressOf _updateStatus), 3)
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Sub _updateStatus(ByVal state As Integer)
        Select Case state
            Case 1
                lbl_status.Text = "Scanning fingerprint, Please wait.."
            Case 2
                lbl_status.Text = "Place your finger on the fingerprint reader."
            Case 3
                lbl_status.Text = "Fingerprint reader has been disconnected."
            Case 4
                lbl_status.Text = "Finger was removed from the fingerprint reader."
        End Select
    End Sub

    Sub _drawFinger(ByVal pic As Bitmap)
        pb_finger.Image = New Bitmap(pic, pb_finger.Size)
    End Sub

    Sub _updateResult(ByVal Employee As Employee)

        If Employee.ScanResult Then
            FingerPrint.StopCapture(Capturer)

            lbl_status.Text = "Employee verification succesful."

            lbl_name.Text = Employee.Fname + " " + Employee.Mname + " " + Employee.Lname
            My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)

        End If

    End Sub

    Sub _verificationFailed()
        FingerPrint.StopCapture(Capturer)
        lbl_status.Text = "Employee verification failed!"
        My.Computer.Audio.Play(My.Resources._error, AudioPlayMode.Background)
    End Sub
End Class