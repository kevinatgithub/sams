Imports MySql.Data.MySqlClient
Public Class Employee

    Public Id As String = Nothing
    Public Employee_no As String = Nothing
    Public Fname As String = Nothing
    Public Mname As String = Nothing
    Public Lname As String = Nothing
    Public Gender As String = Nothing
    Public Dob As String = Nothing
    Public Home_address As String = Nothing
    Public Position As String = Nothing
    Public Office As Office = Nothing
    Public Profile_pic_img As Image = Nothing
    Public Left_finger As Byte()
    Public Right_finger As Byte()
    Public Disabled_dt As String = Nothing
    Public Created_at As String = Nothing
    Public Registered_by As String = Nothing
    Public ScanResult As Boolean = False
    Public LeftFingerTemplate As DPFP.Template
    Public RightFingerTemplate As DPFP.Template
    
    Public Shared Function FindByEmployeeNo(ByVal employee_no As String)
        Dim result As MySqlDataReader = Database.DB.Execute("SELECT * FROM employee WHERE employee_no = '" & employee_no & "' LIMIT 1")
        If Not result.HasRows Then
            Return Nothing
        End If

        Return Employee.Parse(result)
    End Function

    Public Shared Function FindById(ByVal id As String)
        Dim result As MySqlDataReader = Database.DB.Execute("SELECT * FROM employee WHERE id = '" & id & "' LIMIT 1")
        If Not result.HasRows Then
            Return Nothing
        End If

        Return Employee.Parse(result)
    End Function

    Public Shared Function Parse(ByVal result As MySqlDataReader)
        Dim employee As New Employee

        With result.Read
            employee.Id = result("id")
            employee.Employee_no = result("employee_no")
            employee.Fname = result("fname")
            employee.Mname = CanYou.HandleDBNull(result("mname"))
            employee.Lname = result("lname")
            employee.Gender = CanYou.HandleDBNull(result("gender"))
            employee.Dob = CanYou.HandleDBNull(result("dob"))
            employee.Home_address = CanYou.HandleDBNull(result("home_address"))
            employee.Position = result("position")
            employee.Office = Office.FindOfficeById(result("office"), Time_Keeper.Office.Offices)
            employee.Profile_pic_img = CanYou.ConvertByteToImage(result("profile_pic"))
            employee.Left_finger = CanYou.HandleDBNull(result("left_finger"))
            employee.Right_finger = CanYou.HandleDBNull(result("right_finger"))
            employee.Disabled_dt = CanYou.HandleDBNull(result("disabled_dt"))
            employee.Created_at = result("created_at")
            employee.Registered_by = result("registered_by")
        End With
        'result.Read()


        Return employee
    End Function

    Public Shared Function GetPositions() As Collection
        Dim reader As MySqlDataReader = Database.DB.Execute("SELECT DISTINCT(position) as 'position' FROM employee ORDER BY position")
        Dim positions As New Collection
        If reader.HasRows Then
            While reader.Read
                positions.Add(reader("position"))
            End While
        End If
        Return positions
    End Function

    Public Shared Sub LoadPositionsToComboBox(ByVal positions As Collection, ByVal cbo As ComboBox)
        cbo.Items.Clear()
        Dim i As Integer = 0
        For Each _Position In positions
            cbo.Items.Insert(i, _Position)
            i = i + 1
        Next
    End Sub

End Class
