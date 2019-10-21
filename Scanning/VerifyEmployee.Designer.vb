<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyEmployee
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
        Me.btn_cancel = New MetroFramework.Controls.MetroButton()
        Me.lbl_status = New MetroFramework.Controls.MetroLabel()
        Me.pb_finger = New System.Windows.Forms.PictureBox()
        Me.lbl_name = New MetroFramework.Controls.MetroLabel()
        CType(Me.pb_finger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(553, 175)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(161, 31)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(65, 19)
        Me.lbl_status.TabIndex = 6
        Me.lbl_status.Text = "Scanning "
        '
        'pb_finger
        '
        Me.pb_finger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_finger.Location = New System.Drawing.Point(23, 31)
        Me.pb_finger.Name = "pb_finger"
        Me.pb_finger.Size = New System.Drawing.Size(132, 150)
        Me.pb_finger.TabIndex = 5
        Me.pb_finger.TabStop = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(161, 69)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(0, 0)
        Me.lbl_name.TabIndex = 9
        '
        'VerifyEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 221)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.pb_finger)
        Me.Name = "VerifyEmployee"
        CType(Me.pb_finger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents lbl_status As MetroFramework.Controls.MetroLabel
    Friend WithEvents pb_finger As PictureBox
    Friend WithEvents lbl_name As MetroFramework.Controls.MetroLabel
End Class
