<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverrideForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OverrideForm))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_employee_fullname = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dt_date = New System.Windows.Forms.DateTimePicker()
        Me.cbo_type = New MetroFramework.Controls.MetroComboBox()
        Me.txt_h = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txt_m = New MetroFramework.Controls.MetroTextBox()
        Me.txt_reason = New MetroFramework.Controls.MetroTextBox()
        Me.btn_save = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 44)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Employee"
        Me.MetroLabel1.UseStyleColors = True
        '
        'lbl_employee_fullname
        '
        Me.lbl_employee_fullname.AutoSize = True
        Me.lbl_employee_fullname.Location = New System.Drawing.Point(110, 44)
        Me.lbl_employee_fullname.Name = "lbl_employee_fullname"
        Me.lbl_employee_fullname.Size = New System.Drawing.Size(67, 19)
        Me.lbl_employee_fullname.TabIndex = 1
        Me.lbl_employee_fullname.Text = "Employee"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(24, 76)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Date"
        Me.MetroLabel3.UseStyleColors = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(24, 106)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Type"
        Me.MetroLabel4.UseStyleColors = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(25, 140)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Time"
        Me.MetroLabel5.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(27, 175)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "Reason"
        Me.MetroLabel6.UseStyleColors = True
        '
        'dt_date
        '
        Me.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_date.Location = New System.Drawing.Point(110, 75)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(99, 20)
        Me.dt_date.TabIndex = 6
        '
        'cbo_type
        '
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.ItemHeight = 23
        Me.cbo_type.Items.AddRange(New Object() {"DPO/OB", "AM Time In", "AM Time Out", "PM Time In", "PM Time Out"})
        Me.cbo_type.Location = New System.Drawing.Point(110, 103)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(121, 29)
        Me.cbo_type.TabIndex = 7
        '
        'txt_h
        '
        Me.txt_h.Location = New System.Drawing.Point(110, 140)
        Me.txt_h.Name = "txt_h"
        Me.txt_h.Size = New System.Drawing.Size(36, 23)
        Me.txt_h.TabIndex = 8
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(152, 140)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(12, 19)
        Me.MetroLabel7.TabIndex = 9
        Me.MetroLabel7.Text = ":"
        '
        'txt_m
        '
        Me.txt_m.Location = New System.Drawing.Point(170, 140)
        Me.txt_m.Name = "txt_m"
        Me.txt_m.Size = New System.Drawing.Size(36, 23)
        Me.txt_m.TabIndex = 10
        '
        'txt_reason
        '
        Me.txt_reason.Location = New System.Drawing.Point(110, 175)
        Me.txt_reason.Multiline = True
        Me.txt_reason.Name = "txt_reason"
        Me.txt_reason.Size = New System.Drawing.Size(247, 121)
        Me.txt_reason.TabIndex = 11
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(110, 313)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 12
        Me.btn_save.Text = "Save"
        Me.btn_save.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'OverrideForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(380, 349)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_reason)
        Me.Controls.Add(Me.txt_m)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txt_h)
        Me.Controls.Add(Me.cbo_type)
        Me.Controls.Add(Me.dt_date)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lbl_employee_fullname)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OverrideForm"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Text = "OverrideForm"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_employee_fullname As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_type As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_h As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_m As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_reason As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_save As MetroFramework.Controls.MetroButton
End Class
