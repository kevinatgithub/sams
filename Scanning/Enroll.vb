Delegate Sub CallerCallback(ByVal param, ByVal param2)

Public Class Enroll
    Inherits MetroFramework.Forms.MetroForm
    Implements DPFP.Capture.EventHandler


    Public Counter As Integer = 0
    Public Capturer As DPFP.Capture.Capture
    Public Enroller As DPFP.Processing.Enrollment
    Public Caller As Object
    Public ResponseCode As Integer
    Public PictureBox As PictureBox

    Public Event OnTemplate(ByVal template)

    Sub New(Caller As Object, ResponseCode As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Capturer = FingerPrint.InitializeCapturer(Me)
        Enroller = New DPFP.Processing.Enrollment
        Me.Caller = Caller
        Me.ResponseCode = ResponseCode
    End Sub


    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        Invoke(New FunctionCall(AddressOf _DrawPicture), FingerPrint.ConvertSampleToBitmap(Sample))
        Invoke(New FunctionCall(AddressOf _UpdateCounter), True)
        Dim features As DPFP.FeatureSet = FingerPrint.ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)

        If Not features Is Nothing Then
            Try
                Enroller.AddFeatures(features)
            Catch ex As Exception

            Finally
                ScanningComplete(FingerPrint.ConvertSampleToBitmap(Sample))
            End Try
        End If
    End Sub

    Private Sub ScanningComplete(Bmp As Bitmap)
        Select Case Enroller.TemplateStatus
            Case DPFP.Processing.Enrollment.Status.Ready
                RaiseEvent OnTemplate(Enroller.Template)
                Dim converted As Byte() = FingerPrint.templateToByte(Enroller.Template)
                Invoke(New CallerCallback(AddressOf _RunCallback), converted, Bmp)
                FingerPrint.StopCapture(Capturer)
                Invoke(New FunctionCall(AddressOf Me.Close), True)

            Case DPFP.Processing.Enrollment.Status.Failed
                Enroller.Clear()
                FingerPrint.StopCapture(Capturer)
                RaiseEvent OnTemplate(Nothing)

        End Select
    End Sub

    Private Sub _RunCallback(ByVal converted As Byte(), ByVal Bmp As Bitmap)
        Try
            Caller.OnScanComplete(ResponseCode, converted, Bmp)
        Catch ex As Exception
            MsgBox("No callback declared at Caller - " & ex.Message)
        End Try
    End Sub

    Private Sub _UpdateCounter()
        Counter += 1
        lbl_counter.Text = Counter
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        pb_finger.Image = New Bitmap(bmp, pb_finger.Size)
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

    Private Sub Enroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FingerPrint.StartCapture(Capturer)
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        FingerPrint.StopCapture(Capturer)
        Me.Close()
    End Sub
End Class