Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Public Class CanYou

    Private ConfigFileName As String = "c:/TimeKeeping.cfg"
    Public Shared Please As New CanYou

    Public Sub PopulateList(lv As ListView, command As String, columns As Collection)
        lv.Items.Clear()
        Dim dt As New DataTable
        Dim adapter As MySqlDataAdapter = Database.DB.ExecuteDataSet(command)
        Try
            adapter.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                With lv
                    Dim x As Integer = 1
                    Dim first_column As String = ""
                    If Not IsDBNull(dt.Rows(i)(columns.Item(x).ToString)) Then
                        first_column = CanYou.HandleDBNull(dt.Rows(i)(columns.Item(x).ToString))
                    End If
                    .Items.Add(first_column)
                    With .Items(.Items.Count() - 1).SubItems
                        x += 1
                        While x <= columns.Count()
                            Dim other_column As String = ""
                            If Not IsDBNull(dt.Rows(i)(columns.Item(x).ToString)) Then
                                other_column = CanYou.HandleDBNull(dt.Rows(i)(columns.Item(x).ToString))
                            End If
                            .Add(other_column)
                            x += 1
                        End While

                    End With
                End With
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub MakeADefaultConfigFile()
        Dim sw As New IO.StreamWriter(ConfigFileName)
        Dim config As New AppConfig
        Dim configStr As String = JsonConvert.SerializeObject(config)
        sw.WriteLine(configStr)
        sw.Close()
    End Sub

    Public Function ReadConfigFile() As AppConfig
        Dim cfg As String = ReadFile(ConfigFileName)
        If Not cfg Is Nothing Then
            Dim c As New Newtonsoft.Json.Linq.JObject
            c = JsonConvert.DeserializeObject(cfg)

            Dim o As New AppConfig

            o.Host = c.GetValue("Host").ToString
            o.UserId = c.GetValue("UserId").ToString
            o.Password = c.GetValue("Password").ToString
            o.Database = c.GetValue("Database").ToString
            o.ServerURL = c.GetValue("ServerURL").ToString

            Return o
        End If
        Return New AppConfig
    End Function

    Public Function ReadFile(filename As String) As String
        If IO.File.Exists(filename) Then
            Try
                Dim sr As New IO.StreamReader(filename)
                Dim str As String = sr.ReadLine
                Dim out As String = str
                Do While Not str Is Nothing
                    str = sr.ReadLine
                    out &= str
                Loop
                sr.Close()
                Return out
            Catch ex As Exception
                MsgBox("Error Reading File " & ex.Message)
            End Try
        Else
            MakeADefaultConfigFile()
            Return ReadFile(filename)
        End If
        Return Nothing
    End Function

    Sub OpenAnImageInPicturebox(ByRef pb As PictureBox)
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Bitmap|*.bmp|JPEG|*.jpg" 'If you like file type filters you can add them here
        'any other modifications to the dialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Try
            Dim bmp As New Bitmap(ofd.FileName)
            If Not IsNothing(pb.Image) Then pb.Image.Dispose() 'Optional if you want to destroy the previously loaded image
            pb.Image = bmp
        Catch
            MsgBox("Not a valid image file.")
        End Try
    End Sub

    Public Shared Function ConvertImageToByteArray(ByVal value As Bitmap)

        Using stream As New System.IO.MemoryStream
            Try
                value.Save(stream, value.RawFormat)

            Catch ex As Exception

            End Try
            Return stream.ToArray

        End Using
        

    End Function

    Public Shared Function ConvertImageToByteArray(ByVal value As Bitmap, ByVal Format As Object) As Byte()

        If value Is Nothing Then
            Return Nothing
        End If

        Dim imageBytes As Byte()

        Dim mstream As New System.IO.MemoryStream()

        Try
            value.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        imageBytes = mstream.GetBuffer()

        Return imageBytes

    End Function

    Public Shared Function ConvertByteToImage(ByVal byteArr() As Byte) As Drawing.Image

        If byteArr Is Nothing Then
            MsgBox("test")
            Return Nothing
        End If

        Using ImageStream As New IO.MemoryStream(byteArr)
            Dim newImage As Drawing.Image
            Try
                If byteArr.GetUpperBound(0) > 0 Then
                    newImage = System.Drawing.Image.FromStream(ImageStream)

                Else
                    newImage = Nothing
                End If
            Catch ex As Exception
                newImage = Nothing
            End Try
            Return newImage
        End Using

    End Function

    Public Sub DoThis(callback As Action)

        If Not callback Is Nothing Then
            callback()
        End If

    End Sub

    Public Shared Function HandleDBNull(ByVal value As Object)
        If Not IsDBNull(value) Then
            Return value
        Else
            Return Nothing
        End If
    End Function

End Class
