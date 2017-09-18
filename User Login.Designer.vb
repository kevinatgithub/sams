<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Login
    Inherits MetroFramework.Forms.MetroForm

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
        Me.txt_user_id = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txt_pword = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btn_login = New MetroFramework.Controls.MetroButton()
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txt_user_id
        '
        Me.txt_user_id.Location = New System.Drawing.Point(23, 53)
        Me.txt_user_id.Name = "txt_user_id"
        Me.txt_user_id.Size = New System.Drawing.Size(259, 23)
        Me.txt_user_id.TabIndex = 13
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 31)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel4.TabIndex = 12
        Me.MetroLabel4.Text = "User ID"
        '
        'txt_pword
        '
        Me.txt_pword.Location = New System.Drawing.Point(23, 101)
        Me.txt_pword.Name = "txt_pword"
        Me.txt_pword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pword.Size = New System.Drawing.Size(259, 23)
        Me.txt_pword.TabIndex = 15
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 79)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel1.TabIndex = 14
        Me.MetroLabel1.Text = "Password"
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(126, 141)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 16
        Me.btn_login.Text = "Login"
        Me.btn_login.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(207, 141)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 17
        Me.btn_cancel.Text = "Cancel"
        '
        'User_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(302, 187)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_pword)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txt_user_id)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Movable = False
        Me.Name = "User_Login"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_user_id As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_pword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_login As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
End Class
