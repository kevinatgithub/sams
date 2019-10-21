Public Class TimeCardManager

    Dim employee As Employee

    Public Sub New(parent, employee)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.employee = employee
    End Sub
End Class