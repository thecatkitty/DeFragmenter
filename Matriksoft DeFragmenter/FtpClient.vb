Public Class FtpClient
    Public Property Url As String
    Public Property FileName As String
    Private ServerUri As Uri


    Public Function Download() As Boolean
        System.Uri.TryCreate(Me.Url, UriKind.Absolute, Me.ServerUri)
        If Me.ServerUri.Scheme <> Uri.UriSchemeFtp Then
            Return False
        End If

        Dim request As New System.Net.WebClient()

        MsgBox(String.Format("Dla pliku{0}{1}{0}potrzebne jest zalogowanie na konto FTP.", vbNewLine, Me.Url), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Logownaie do FTP - Matriksoft DeFragmenter")
        LoginForm1.ShowDialog()

        request.Credentials = New System.Net.NetworkCredential(LoginForm1.UsernameTextBox.Text, LoginForm1.PasswordTextBox.Text)
        Try
            request.DownloadFile(Me.ServerUri, Me.FileName)
        Catch e As System.Net.WebException
            MsgBox(String.Format("Wystąpił wyjątek podczas połączenia FTP:{0}{0}{1}", vbNewLine, e.ToString), MsgBoxStyle.Critical, "Wyjątek - Matriksoft DeFragmenter")
            Form1.Linker1.Err = True
        End Try
        Return True
    End Function
End Class
