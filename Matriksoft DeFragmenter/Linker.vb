Public Class Linker
    Private FileBuffer As Byte
    Private ResultOffset As ULong = 0
    Public Property Err As Boolean = False
    Public Property Temp As String

    Public Sub Link(ByVal List As FragmentList, ByVal ResultPath As String)
        Dim FM As New FileManager
        Dim Result As System.IO.FileStream
        FM.CreateTempDir(Temp)
        'FM.CreateFile(ResultPath)

        Result = System.IO.File.OpenWrite(ResultPath)
        Dim HttpClient1 As New HttpClient
        Dim FtpClient1 As New FtpClient
        Dim RW As New ReadWrite
        RW.Result = Result
        Dim j As Byte = 0
        For Each iFragment As Fragment In List.Fragments
            If Form1.Linker1.Err Then Exit For
            If j = List.Count() Then Exit For
            RW.I = j
            If iFragment.Protocol = 1 Then
                HttpClient1.Url = iFragment.Name
                HttpClient1.FileName = String.Format("{0}\mdfrg{1}.mff", Me.Temp, j.ToString)
                HttpClient1.Download()
                If Form1.Linker1.Err Then Exit For
                iFragment.Length = New System.IO.FileInfo(HttpClient1.FileName).Length
                RW.Fragment = iFragment
                RW.Path = HttpClient1.FileName
                RW.ReadWrite()
            ElseIf iFragment.Protocol = 2 Then
                FtpClient1.Url = iFragment.Name
                FtpClient1.FileName = String.Format("{0}\mdfrg{1}.mff", Me.Temp, j.ToString)
                FtpClient1.Download()
                If Form1.Linker1.Err Then Exit For
                iFragment.Length = New System.IO.FileInfo(FtpClient1.FileName).Length
                RW.Fragment = iFragment
                RW.Path = FtpClient1.FileName
                RW.ReadWrite()
            Else
                RW.Fragment = iFragment
                RW.Path = iFragment.Name
                RW.ReadWrite()
            End If
            If j = 255 Then
                Me.Err = True
                Exit For
            End If
            j = j + 1
            Form1.ProgressBar1.Value = j / List.Count * 256
        Next
        Result.Close()
        System.IO.Directory.Delete(Me.Temp)
    End Sub
End Class
