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
        Me.pb_photo = New System.Windows.Forms.PictureBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        CType(Me.pb_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(284, 166)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_cancel.UseSelectable = True
        '
        'pb_photo
        '
        Me.pb_photo.Location = New System.Drawing.Point(23, 51)
        Me.pb_photo.Name = "pb_photo"
        Me.pb_photo.Size = New System.Drawing.Size(124, 138)
        Me.pb_photo.TabIndex = 1
        Me.pb_photo.TabStop = False
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(170, 51)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(39, 13)
        Me.lbl_status.TabIndex = 2
        Me.lbl_status.Text = "Label1"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(170, 75)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(39, 13)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "Label1"
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.Location = New System.Drawing.Point(170, 98)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(39, 13)
        Me.lbl_position.TabIndex = 4
        Me.lbl_position.Text = "Label1"
        '
        'VerifyEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 203)
        Me.Controls.Add(Me.lbl_position)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.pb_photo)
        Me.Controls.Add(Me.btn_cancel)
        Me.Name = "VerifyEmployee"
        Me.Resizable = False
        CType(Me.pb_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents pb_photo As PictureBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_position As Label
End Class
