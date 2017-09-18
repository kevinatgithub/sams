Imports MySql.Data.MySqlClient

Public Class Office

    Public Index As Integer = Nothing
    Public ID As String = Nothing
    Public Name As String = Nothing
    Public Signatory As String = Nothing
    Public Shared Offices As Collection = Office.GetAllOffices

    Public Shared Function FindById(ByVal id As String)
        Dim result As MySqlDataReader = Database.DB.Execute("SELECT * FROM office WHERE id = '" & id & "' LIMIT 1")
        If Not result.HasRows Then
            Return Nothing
        End If

        Return Office.Parse(result)
    End Function

    Public Shared Function Parse(ByVal result As MySqlDataReader)
        Dim office As New Office

        With result.Read
            office.ID = result("id")
            office.Name = result("name")
            office.Signatory = result("signatory")
        End With
        
        Return office
    End Function

    Public Shared Function GetBlankForShowAll()
        Dim noffice As New Office
        noffice.ID = 0
        noffice.Name = "Show All"
        noffice.Signatory = ""
        Return noffice
    End Function

    Public Shared Function GetAllOffices()
        Dim offices As New Collection

        Dim offices_dr As MySqlDataReader = Database.DB.Execute("SELECT * FROM office")
        Dim i As Integer = 0

        While offices_dr.Read
            Dim office As New Office
            office.Index = i
            office.Id = offices_dr("id")
            office.Name = offices_dr("name")
            office.Signatory = offices_dr("signatory")
            offices.Add(office)
            i += 1
        End While

        Return offices
    End Function

    Public Shared Function FindOfficeByIndex(index As Integer, offices As Collection)

        For Each office In offices
            If office.Index = index Then
                Return office
            End If
        Next

        Return Nothing
    End Function

    Public Shared Function FindOfficeById(id As Integer, offices As Collection)

        For Each office In offices
            If office.Id = id Then
                Return office
            End If
        Next

        Return Nothing
    End Function

    Public Shared Sub LoadOfficesToComboBox(ByVal offices As Collection, ByVal cbo As ComboBox)
        cbo.Items.Clear()
        Dim i As Integer = 0
        For Each office In offices
            cbo.Items.Insert(i, office.Name)
            i = i + 1
        Next
    End Sub

End Class
