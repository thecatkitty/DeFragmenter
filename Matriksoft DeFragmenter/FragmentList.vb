Public Class FragmentList
    Public Property Filename As String
    Public Property IsActivated As Boolean
    Public Property Count As Byte

    Public Fragments(256) As Fragment

    Public Sub WriteFragment(ByVal number As Byte, ByVal fileName As String, ByVal protocol As String)
        Me.Fragments(number) = New Fragment
        If protocol = "http" Then
            Me.Fragments(number).Protocol = 1
        ElseIf protocol = "ftp" Then
            Me.Fragments(number).Protocol = 2
        Else
            Me.Fragments(number).Protocol = 0
        End If
        Me.Fragments(number).Name = fileName
    End Sub

    Public Function ProtocolToString(ByVal number As Byte) As String
        If Fragments(number).Protocol = 1 Then
            ProtocolToString = "http"
        ElseIf Fragments(number).Protocol = 2 Then
            ProtocolToString = "ftp"
        Else
            ProtocolToString = "file"
        End If
    End Function
End Class
