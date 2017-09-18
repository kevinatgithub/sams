Public Class New_Employee_2
    Inherits MetroFramework.Forms.MetroForm

    Private webcam As WebCam
    Public CurrentEmployee As Employee
    Public NextStep As New_Employee_3
    Public PreviousStep As New_Employee

    Sub New(PreviousStep As New_Employee, CurrentEmployee As Employee)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PreviousStep = PreviousStep
        Me.CurrentEmployee = CurrentEmployee

    End Sub


    Private Sub New_Employee_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        webcam = New WebCam()
        webcam.InitializeWebCam(pb_pic)
        NextStep = New New_Employee_3(Me, CurrentEmployee)
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        webcam.Stop()
        CanYou.Please.OpenAnImageInPicturebox(pb_pic)

    End Sub

    Private Sub btn_start_camera_Click(sender As Object, e As EventArgs) Handles btn_start_camera.Click

        webcam.Start()
        webcam.Continue()
        btn_start_camera.Enabled = False
        btn_capture.Enabled = True
    End Sub


    Private Sub btn_capture_Click(sender As Object, e As EventArgs) Handles btn_capture.Click
        webcam.Stop()
        btn_start_camera.Enabled = True
        btn_capture.Enabled = False

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        PreviousStep.Caller.Focus()
        Me.Close()
    End Sub

    Private Sub Bye(sender As Object, e As EventArgs) Handles Me.FormClosed
        PreviousStep.Caller.Focus()
    End Sub

    Private Sub proceed_Click(sender As Object, e As EventArgs) Handles proceed.Click
        If pb_pic.Image IsNot Nothing Then
            CurrentEmployee.Profile_pic_img = pb_pic.Image
        End If
        NextStep.Show()
        Me.Hide()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        PreviousStep.Show()
    End Sub
End Class