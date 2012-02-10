Public Class ReadWrite
    Public Property Fragment As Fragment
    Public Property Result As IO.FileStream
    Public Property I As Byte
    Public Property Path As String

    Private Property ReadStream As IO.FileStream
    Private Property ReadBinary As IO.BinaryReader

    Public Sub ReadWrite()
        Try
            ReadStream = New System.IO.FileStream(Path, IO.FileMode.Open)
            For i As Long = 0 To Fragment.Length - 1
                ReadBinary = New System.IO.BinaryReader(ReadStream)
                Result.WriteByte(ReadBinary.ReadByte())
            Next
            ReadStream.Close()
            If Fragment.Protocol = 0 Then

            Else
                System.IO.File.Delete(Me.Path)
            End If
        Catch ex As Exception
            MsgBox(String.Format("Wystąpił wyjątek podczas odczytu pliku nr {0}:{1}{1}{2}", I.ToString, vbNewLine, ex.ToString), MsgBoxStyle.Critical, "Wyjątek - Matriksoft DeFragmenter")
            Form1.Linker1.Err = True
        End Try
    End Sub
End Class
