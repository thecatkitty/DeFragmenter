Public Class Fragment
    Public Name As String
    Public Protocol As Byte
    Private XtpLength As Long
    Public Property Length As Long
        Get
            If Me.Protocol = 0 Then
                Return New System.IO.FileInfo(Me.Name).Length
            Else
                Return Me.XtpLength
            End If
        End Get
        Set(ByVal value As Long)
            Me.XtpLength = value
        End Set
    End Property
End Class
