Imports MySql.Data.MySqlClient

Public Class User

    Public Shared Current As User
    Public user_id As String
    Public name As String
    Public ulevel As Integer
    Public password As String

    Public Sub parse(user_id As String, name As String, ulevel As String)
        Me.user_id = user_id
        Me.name = name
        Me.ulevel = Integer.Parse(ulevel * 1)
    End Sub

    Public Sub parse(reader As MySqlDataReader)
        While reader.Read
            Me.user_id = reader("username")
            Me.name = reader("name")
            Me.ulevel = reader("ulevel")
        End While
    End Sub

    Public Sub save()
        Database.DB.Execute("INSERT INTO user VALUES ('" & Me.user_id & "',md5('" & Me.password & "'), '" & Me.name & "','" & Me.ulevel & "'))")
    End Sub

    Public Shared Function find(ByVal user_id As String) As User
        Dim user As New User
        Dim result As MySqlDataReader = Database.DB.Execute("SELECT * FROM user WHERE username = '" & user_id & "'")
        If result.HasRows = False Then
            Return user
        Else
            While result.Read
                user.parse(result("username"), result("name"), result("ulevel"))
            End While
            Return user
        End If
    End Function

    Public Sub SetCurrent()
        User.Current = Me
    End Sub


    Public Shared Function GetCurrent() As User
        If Current Is Nothing Then
            Return New User
        Else
            Return User.Current
        End If
    End Function

    Shared Function attemptLogin(username As String, password As String) As MySqlDataReader
        Return Database.DB.Execute("SELECT * FROM user WHERE username = '" & username & "' AND password = MD5('" & password & "')")
    End Function

End Class
