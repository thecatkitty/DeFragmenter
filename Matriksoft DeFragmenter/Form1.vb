Imports System.Xml
Imports System.Xml.XPath

Public Class Form1
    Public FragmentList1 As New FragmentList
    Private completePath As String
    Public folderIsSelected As Boolean = False

    Private Sub OProgramieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OProgramieToolStripMenuItem.Click
        OProgramie()
    End Sub

    Private Sub OtwórzToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtwórzToolStripMenuItem.Click
        Otwórz()
    End Sub

    Private Sub ZakończToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZakończToolStripMenuItem.Click
        Zakończ()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        readMfd(Me.OpenFileDialog1.FileName)
    End Sub

    Private Sub readMfd(ByVal fileName As String)
        Dim mfdFile As New XmlDataDocument()
        Dim mfdXmlNodeList As System.Xml.XmlNodeList
        Dim mfdXmlRoot As System.Xml.XmlNode

        FragmentList1.IsActivated = True
        mfdFile.Load(fileName)
        mfdXmlNodeList = mfdFile.SelectNodes("//fragment")

        mfdXmlRoot = mfdFile.SelectSingleNode("//filename")
        FragmentList1.Filename = mfdXmlRoot.InnerText.ToString

        Dim i As Byte
        FragmentList1.Count = mfdXmlNodeList.Count
        For i = 0 To mfdXmlNodeList.Count - 1
            FragmentList1.WriteFragment(i, mfdXmlNodeList(i).InnerText.ToString,
                                        mfdXmlNodeList(i).Attributes.GetNamedItem("p").InnerText.ToString)
        Next
    End Sub


    Private Sub DefragmentujToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefragmentujToolStripMenuItem.Click
        Defragmentuj()
    End Sub

    Private Sub SchowajDoZasobnikaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchowajDoZasobnikaToolStripMenuItem.Click
        Schowaj()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Pokaż()
    End Sub

    Private Sub WłaściwościToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WłaściwościToolStripMenuItem.Click
        Właściwości()
    End Sub

    Private Sub PokażToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PokażToolStripMenuItem.Click
        Pokaż()
    End Sub

    Private Sub ZakończToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZakończToolStripMenuItem1.Click
        Zakończ()
    End Sub

    Private Sub PlikToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlikToolStripMenuItem1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub DefragmentujToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefragmentujToolStripMenuItem1.Click
        Defragmentuj()
    End Sub

    Private Sub WłaściwościToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WłaściwościToolStripMenuItem1.Click
        Właściwości()
    End Sub

    Private Sub OProgramieToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OProgramieToolStripMenuItem1.Click
        OProgramie()
    End Sub

    Private Sub Pokaż()
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Public Linker1 As New Linker
    Private Sub Defragmentuj()
        Linker1.Temp = "$mdfrg$.tmp"
        If FragmentList1.IsActivated Then
            If folderIsSelected Then
                Linker1.Link(FragmentList1, completePath)
                If Linker1.Err Then
                    MsgBox("Defragmentacja pliku zakończona niepowodzeniem!", MsgBoxStyle.Critical, "Matriksoft DeFragmenter")
                Else
                    MsgBox("Defragmentacja pliku zakończona powodzeniem!", MsgBoxStyle.Information, "Matriksoft DeFragmenter")
                End If
            Else
                MsgBox("Najpierw wybierz folder docelowy!", MsgBoxStyle.Critical, "Błąd - Matriksoft DeFragmenter")
            End If
        Else
            MsgBox("Najpierw wybierz plik MFD!", MsgBoxStyle.Critical, "Błąd - Matriksoft DeFragmenter")
        End If
    End Sub

    Private Sub WybierzFolderDocelowy()
        If FragmentList1.IsActivated Then
            FolderBrowserDialog1.ShowDialog()
            completePath = String.Format("{0}\{1}", FolderBrowserDialog1.SelectedPath, FragmentList1.Filename)
            folderIsSelected = True
        Else
            MsgBox("Najpierw wybierz plik MFD!", MsgBoxStyle.Critical, "Błąd - Matriksoft DeFragmenter")
        End If
    End Sub

    Private Sub Schowaj()
        Me.Hide()
        NotifyIcon1.Visible = True
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipText = "Jestem tutaj!"
        NotifyIcon1.BalloonTipTitle = "Matriksoft DeFragmenter"
        NotifyIcon1.ShowBalloonTip(5000)
    End Sub

    Private Sub Właściwości()
        If FragmentList1.IsActivated Then
            Properties.ShowDialog()
        Else
            MsgBox("Najpierw wybierz plik MFD!", MsgBoxStyle.Critical, "Błąd - Matriksoft DeFragmenter")
        End If
    End Sub

    Private Sub Zakończ()
        Application.Exit()
    End Sub

    Private Sub Otwórz()
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OProgramie()
        AboutBox1.ShowDialog()
    End Sub

    Private Sub WybierzFolderDocelowyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WybierzFolderDocelowyToolStripMenuItem.Click
        WybierzFolderDocelowy()
    End Sub

    Private Sub WybierzFolderDocelowyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WybierzFolderDocelowyToolStripMenuItem1.Click
        WybierzFolderDocelowy()
    End Sub
End Class
