Public Class FileManager
    Public Sub CreateTempDir(ByVal Path As String)
        If System.IO.Directory.Exists(Path) Then
        Else
            System.IO.Directory.CreateDirectory(Path)
        End If
    End Sub

    Public Sub CreateFile(ByVal Path As String)
        If System.IO.File.Exists(Path) Then
        Else
            Try
                System.IO.File.Create(Path)
            Catch ex As Exception
                MsgBox(String.Format("Wystąpił wyjątek podczas tworzenia pliku:{0}{0}{1}", vbNewLine, ex.ToString), MsgBoxStyle.Critical, "Wyjątek - Matriksoft DeFragmenter")
            End Try
        End If
    End Sub
End Class
