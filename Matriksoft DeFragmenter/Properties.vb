Imports System.Windows.Forms

Public Class Properties

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Properties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileName.Text = Form1.OpenFileDialog1.FileName.ToString
        CompleteFile.Text = Form1.FragmentList1.Filename
        Fragments.Text = Form1.FragmentList1.Count.ToString
    End Sub
End Class
