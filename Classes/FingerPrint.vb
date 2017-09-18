Public Class FingerPrint

    Public Shared Function InitializeCapturer(EventHandler As Object)
        Dim Capturer As DPFP.Capture.Capture = Nothing
        Try
            Capturer = New DPFP.Capture.Capture

            If Not Capturer Is Nothing Then
                Capturer.EventHandler = EventHandler
            Else
                MsgBox("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MsgBox("Can't initiate capture operation!")
        End Try

        Return Capturer
    End Function

    Public Shared Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing                          ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)              ' TODO: return bitmap as a result
        Return bitmap
    End Function

    Public Shared Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()        ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        Try
            extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        Catch ex As Exception

        End Try

        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    Public Shared Sub StartCapture(Capturer As DPFP.Capture.Capture)
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StartCapture()
                'MsgBox("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As Exception
                MsgBox("Can't initiate capture!")
            End Try
        End If
    End Sub

    Public Shared Sub StopCapture(Capturer As DPFP.Capture.Capture)
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
            Catch ex As Exception
                MsgBox("Can't terminate capture!")
            End Try
        End If
    End Sub

    Public Shared Function templateToByte(template As DPFP.Template) As Byte()


        'pucha pano mag convert from Template to blob
        Dim str As New IO.MemoryStream

        template.Serialize(str)
        Dim serializedTemplate As Byte() = str.ToArray()

        Return serializedTemplate
    End Function

End Class
