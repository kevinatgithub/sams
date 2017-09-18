Public Class Update_Employee_3

    Inherits MetroFramework.Forms.MetroForm

    Public CurrentEmployee As Employee
    Public PreviousStep As Update_Employee_2

    Sub New(PreviousStep As Update_Employee_2, CurrentEmployee As Employee)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PreviousStep = PreviousStep
        Me.CurrentEmployee = CurrentEmployee
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        PreviousStep.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        PreviousStep.PreviousStep.Caller.Focus()
        Me.Close()
    End Sub

    Private Sub Bye(sender As Object, e As EventArgs) Handles Me.FormClosed
        PreviousStep.PreviousStep.Caller.Focus()
    End Sub



    Public Sub OnScanComplete(ByVal ResponseCode As Integer, ByVal Converted As Byte(), Bmp As Bitmap)
        Select Case ResponseCode
            Case 1
                CurrentEmployee.Left_finger = Converted
                pb_left.Image = Bmp
            Case 2
                CurrentEmployee.Right_finger = Converted
                pb_right.Image = Bmp
        End Select
    End Sub

    Private Sub btn_scan_left_Click(sender As Object, e As EventArgs) Handles btn_scan_left.Click
        Dim scanner As New Enroll(Me, 1)
        scanner.Show()
    End Sub

    Private Sub btn_scan_right_Click(sender As Object, e As EventArgs) Handles btn_scan_right.Click
        Dim scanner As New Enroll(Me, 2)
        scanner.Show()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        Dim NextStep As New Update_Employee_4(Me, CurrentEmployee)
        NextStep.Show()
        Me.Hide()

    End Sub

End Class