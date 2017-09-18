Imports MySql.Data.MySqlClient

Public Class User_Login
    Inherits MetroFramework.Forms.MetroForm

    Private _caller As Time_Keeping
    
    Sub New(caller As Time_Keeping)
        InitializeComponent()
        _caller = caller
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
        _caller.Focus()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            _caller.Focus()
        End If
    End Sub


    Private Sub txt_user_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_user_id.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            _caller.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            ProcessLogin()
        End If
    End Sub


    Private Sub txt_pword_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pword.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            _caller.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            ProcessLogin()
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ProcessLogin()
    End Sub

    Sub ProcessLogin()
        If txt_user_id.Text = "" Or txt_pword.Text = "" Then
            Return
        End If

        Dim attempt As MySqlDataReader = User.attemptLogin(txt_user_id.Text, txt_pword.Text)

        If attempt.HasRows Then
            Dim user As New User
            user.parse(attempt)
            user.SetCurrent()
            _caller.Hide()
            Me.Hide()
            Dim list As New List
            list.Show()

        Else
            MsgBox("User Name or Password Invalid")
            txt_user_id.Text = ""
            txt_pword.Text = ""
            txt_user_id.Focus()
        End If
    End Sub
End Class