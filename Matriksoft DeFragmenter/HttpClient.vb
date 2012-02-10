Public Class HttpClient
    Public Property Url As String
    Public Property FileName As String

    Public Sub Download()
        Dim WebClient As New System.Net.WebClient
        Try
            WebClient.DownloadFile(Me.Url, Me.FileName)
        Catch e As System.Net.WebException
            MsgBox(String.Format("Wystąpił wyjątek podczas połączenia HTTP:{0}{0}{1}", vbNewLine, e.ToString), MsgBoxStyle.Critical, "Wyjątek - Matriksoft DeFragmenter")
            Form1.Linker1.Err = True
        End Try
    End Sub
End Class
