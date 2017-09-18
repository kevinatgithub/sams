<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Override
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Override))
        Me.lbl_employee_fullname = New MetroFramework.Controls.MetroLabel()
        Me.lbl_office_and_position = New MetroFramework.Controls.MetroLabel()
        Me.lv_overrides = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.btn_new = New MetroFramework.Controls.MetroButton()
        Me.cm_overrides = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.item_approve = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_overrides.SuspendLayout
        Me.SuspendLayout
        '
        'lbl_employee_fullname
        '
        Me.lbl_employee_fullname.AutoSize = true
        Me.lbl_employee_fullname.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_employee_fullname.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbl_employee_fullname.Location = New System.Drawing.Point(23, 30)
        Me.lbl_employee_fullname.Name = "lbl_employee_fullname"
        Me.lbl_employee_fullname.Size = New System.Drawing.Size(138, 25)
        Me.lbl_employee_fullname.TabIndex = 0
        Me.lbl_employee_fullname.Text = "Juan Dela Cruz"
        Me.lbl_employee_fullname.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lbl_employee_fullname.UseStyleColors = true
        '
        'lbl_office_and_position
        '
        Me.lbl_office_and_position.AutoSize = true
        Me.lbl_office_and_position.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_office_and_position.Location = New System.Drawing.Point(23, 55)
        Me.lbl_office_and_position.Name = "lbl_office_and_position"
        Me.lbl_office_and_position.Size = New System.Drawing.Size(218, 25)
        Me.lbl_office_and_position.Style = MetroFramework.MetroColorStyle.Teal
        Me.lbl_office_and_position.TabIndex = 1
        Me.lbl_office_and_position.Text = "NVBSP - IMU | I.T. Officer 1"
        Me.lbl_office_and_position.UseStyleColors = true
        '
        'lv_overrides
        '
        Me.lv_overrides.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lv_overrides.FullRowSelect = true
        Me.lv_overrides.GridLines = true
        Me.lv_overrides.Location = New System.Drawing.Point(23, 141)
        Me.lv_overrides.Name = "lv_overrides"
        Me.lv_overrides.Size = New System.Drawing.Size(755, 431)
        Me.lv_overrides.TabIndex = 2
        Me.lv_overrides.UseCompatibleStateImageBehavior = false
        Me.lv_overrides.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Time"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Reason"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Created By"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Approved By"
        Me.ColumnHeader7.Width = 100
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(23, 101)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(98, 23)
        Me.btn_new.TabIndex = 3
        Me.btn_new.Text = "New Override"
        '
        'cm_overrides
        '
        Me.cm_overrides.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.item_approve, Me.item_delete})
        Me.cm_overrides.Name = "cm_overrides"
        Me.cm_overrides.Size = New System.Drawing.Size(116, 48)
        '
        'item_approve
        '
        Me.item_approve.Name = "item_approve"
        Me.item_approve.Size = New System.Drawing.Size(115, 22)
        Me.item_approve.Text = "Approve"
        '
        'item_delete
        '
        Me.item_delete.Name = "item_delete"
        Me.item_delete.Size = New System.Drawing.Size(115, 22)
        Me.item_delete.Text = "Delete"
        '
        'Override
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(815, 609)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.lv_overrides)
        Me.Controls.Add(Me.lbl_office_and_position)
        Me.Controls.Add(Me.lbl_employee_fullname)
        Me.DisplayHeader = false
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Override"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = false
        Me.Text = "Override"
        Me.cm_overrides.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lbl_employee_fullname As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_office_and_position As MetroFramework.Controls.MetroLabel
    Friend WithEvents lv_overrides As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_new As MetroFramework.Controls.MetroButton
    Friend WithEvents cm_overrides As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents item_approve As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents item_delete As System.Windows.Forms.ToolStripMenuItem
End Class
