<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimeCard))
        Me.wb_dtr = New System.Windows.Forms.WebBrowser()
        Me.lbl_employee_fullname = New MetroFramework.Controls.MetroLabel()
        Me.btn_print = New MetroFramework.Controls.MetroButton()
        Me.cbo_month = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cbo_year = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cbo_cutoff = New MetroFramework.Controls.MetroComboBox()
        Me.btn_generate = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout
        '
        'wb_dtr
        '
        Me.wb_dtr.Location = New System.Drawing.Point(20, 104)
        Me.wb_dtr.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb_dtr.Name = "wb_dtr"
        Me.wb_dtr.Size = New System.Drawing.Size(1090, 734)
        Me.wb_dtr.TabIndex = 0
        Me.wb_dtr.Url = New System.Uri("", System.UriKind.Relative)
        '
        'lbl_employee_fullname
        '
        Me.lbl_employee_fullname.AutoSize = True
        Me.lbl_employee_fullname.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_employee_fullname.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_employee_fullname.Location = New System.Drawing.Point(20, 28)
        Me.lbl_employee_fullname.Name = "lbl_employee_fullname"
        Me.lbl_employee_fullname.Size = New System.Drawing.Size(127, 25)
        Me.lbl_employee_fullname.Style = MetroFramework.MetroColorStyle.Blue
        Me.lbl_employee_fullname.TabIndex = 1
        Me.lbl_employee_fullname.Text = "Juan Dela Cruz"
        Me.lbl_employee_fullname.UseStyleColors = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(869, 75)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 23)
        Me.btn_print.TabIndex = 2
        Me.btn_print.Text = "Print"
        Me.btn_print.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbo_month
        '
        Me.cbo_month.FormattingEnabled = True
        Me.cbo_month.ItemHeight = 23
        Me.cbo_month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "Jully", "August", "September", "October", "November", "December"})
        Me.cbo_month.Location = New System.Drawing.Point(422, 71)
        Me.cbo_month.Name = "cbo_month"
        Me.cbo_month.Size = New System.Drawing.Size(121, 29)
        Me.cbo_month.TabIndex = 3
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(366, 77)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Month :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(196, 77)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Year :"
        '
        'cbo_year
        '
        Me.cbo_year.FormattingEnabled = True
        Me.cbo_year.ItemHeight = 23
        Me.cbo_year.Location = New System.Drawing.Point(239, 71)
        Me.cbo_year.Name = "cbo_year"
        Me.cbo_year.Size = New System.Drawing.Size(121, 29)
        Me.cbo_year.TabIndex = 6
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(549, 77)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Cut-off :"
        '
        'cbo_cutoff
        '
        Me.cbo_cutoff.FormattingEnabled = True
        Me.cbo_cutoff.ItemHeight = 23
        Me.cbo_cutoff.Items.AddRange(New Object() {"1st Cut-off", "2nd Cut-off", "Full Month"})
        Me.cbo_cutoff.Location = New System.Drawing.Point(613, 71)
        Me.cbo_cutoff.Name = "cbo_cutoff"
        Me.cbo_cutoff.Size = New System.Drawing.Size(121, 29)
        Me.cbo_cutoff.TabIndex = 7
        '
        'btn_generate
        '
        Me.btn_generate.Location = New System.Drawing.Point(764, 75)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(75, 23)
        Me.btn_generate.TabIndex = 9
        Me.btn_generate.Text = "Generate"
        '
        'TimeCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1133, 788)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.cbo_cutoff)
        Me.Controls.Add(Me.cbo_year)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cbo_month)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.lbl_employee_fullname)
        Me.Controls.Add(Me.wb_dtr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TimeCard"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents wb_dtr As System.Windows.Forms.WebBrowser
    Friend WithEvents lbl_employee_fullname As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_print As MetroFramework.Controls.MetroButton
    Friend WithEvents cbo_month As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_year As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_cutoff As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btn_generate As MetroFramework.Controls.MetroButton
End Class
