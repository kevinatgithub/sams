Imports MySql.Data.MySqlClient

Public Class Database

    Public Connection As MySqlConnection
    Private Command As MySqlCommand

    Public Shared DB As New Database

    Sub OpenConnection()

        Dim config As AppConfig = CanYou.Please.ReadConfigFile

        If Connection IsNot Nothing Then
            Connection.Close()
        End If
        Connection = New MySqlConnection
        Connection.ConnectionString = "server=" & config.Host & ";userid=" & config.UserId & ";password=" & config.Password & ";database=" & config.Database
        Try
            Connection.Open()
        Catch ex As MySqlException
            MsgBox("Can't connect to database server. " & ex.Message)
        End Try
    End Sub

    Sub CloseConnection()
        Connection.Close()
        Connection.Dispose()
    End Sub

    Public Function Execute(query As String)
        'Dim db As New Database
        'db.OpenConnection()
        OpenConnection()
        Dim reader As MySqlDataReader
        Try
            Command = New MySqlCommand(query, Connection)
            reader = Command.ExecuteReader
            Return reader
        Catch ex As MySqlException
            MsgBox(ex.Message & "QUERY: " & query)
        End Try
        Return False
    End Function

    Public Function ExecuteDataSet(query As String)
        OpenConnection()
        Dim adapter As MySqlDataAdapter
        Try
            adapter = New MySqlDataAdapter(query, Connection)
            Return adapter
        Catch ex As MySqlException
            MsgBox(ex.Message & "QUERY: " & query)
        End Try
        Return False
    End Function

End Class
