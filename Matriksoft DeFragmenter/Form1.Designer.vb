<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtwórzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WybierzFolderDocelowyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZakończToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PomocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OProgramieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AkcjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefragmentujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WłaściwościToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SchowajDoZasobnikaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PokażToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZakończToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlikToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WybierzFolderDocelowyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DefragmentujToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WłaściwościToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.OProgramieToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlikToolStripMenuItem, Me.PomocToolStripMenuItem, Me.AkcjaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlikToolStripMenuItem
        '
        Me.PlikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtwórzToolStripMenuItem, Me.WybierzFolderDocelowyToolStripMenuItem, Me.ToolStripMenuItem1, Me.ZakończToolStripMenuItem})
        Me.PlikToolStripMenuItem.Name = "PlikToolStripMenuItem"
        Me.PlikToolStripMenuItem.Size = New System.Drawing.Size(34, 20)
        Me.PlikToolStripMenuItem.Text = "&Plik"
        '
        'OtwórzToolStripMenuItem
        '
        Me.OtwórzToolStripMenuItem.Name = "OtwórzToolStripMenuItem"
        Me.OtwórzToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OtwórzToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.OtwórzToolStripMenuItem.Text = "&Otwórz..."
        '
        'WybierzFolderDocelowyToolStripMenuItem
        '
        Me.WybierzFolderDocelowyToolStripMenuItem.Name = "WybierzFolderDocelowyToolStripMenuItem"
        Me.WybierzFolderDocelowyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.WybierzFolderDocelowyToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.WybierzFolderDocelowyToolStripMenuItem.Text = "Wybierz folder docelowy"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(234, 6)
        '
        'ZakończToolStripMenuItem
        '
        Me.ZakończToolStripMenuItem.Name = "ZakończToolStripMenuItem"
        Me.ZakończToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ZakończToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ZakończToolStripMenuItem.Text = "&Zakończ"
        '
        'PomocToolStripMenuItem
        '
        Me.PomocToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PomocToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OProgramieToolStripMenuItem})
        Me.PomocToolStripMenuItem.Name = "PomocToolStripMenuItem"
        Me.PomocToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PomocToolStripMenuItem.Text = "Pomo&c"
        '
        'OProgramieToolStripMenuItem
        '
        Me.OProgramieToolStripMenuItem.Name = "OProgramieToolStripMenuItem"
        Me.OProgramieToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.OProgramieToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.OProgramieToolStripMenuItem.Text = "&O programie..."
        '
        'AkcjaToolStripMenuItem
        '
        Me.AkcjaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefragmentujToolStripMenuItem, Me.WłaściwościToolStripMenuItem, Me.ToolStripMenuItem2, Me.SchowajDoZasobnikaToolStripMenuItem})
        Me.AkcjaToolStripMenuItem.Name = "AkcjaToolStripMenuItem"
        Me.AkcjaToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.AkcjaToolStripMenuItem.Text = "&Akcja"
        '
        'DefragmentujToolStripMenuItem
        '
        Me.DefragmentujToolStripMenuItem.Name = "DefragmentujToolStripMenuItem"
        Me.DefragmentujToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.DefragmentujToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.DefragmentujToolStripMenuItem.Text = "&Defragmentuj"
        '
        'WłaściwościToolStripMenuItem
        '
        Me.WłaściwościToolStripMenuItem.Name = "WłaściwościToolStripMenuItem"
        Me.WłaściwościToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.WłaściwościToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.WłaściwościToolStripMenuItem.Text = "&Właściwości"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(242, 6)
        '
        'SchowajDoZasobnikaToolStripMenuItem
        '
        Me.SchowajDoZasobnikaToolStripMenuItem.Name = "SchowajDoZasobnikaToolStripMenuItem"
        Me.SchowajDoZasobnikaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.SchowajDoZasobnikaToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.SchowajDoZasobnikaToolStripMenuItem.Text = "&Schowaj do zasobnika"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Opis pliku pofragmentowanego Matriksoft (*.mfd)|*.mfd|Wszystkie pliki (*.*)|*.*"
        Me.OpenFileDialog1.InitialDirectory = "%homedrive%"
        Me.OpenFileDialog1.Title = "Otwieranie Opisu pliku pofragmentowanego Matriksoft"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Wybierz folder docelowy dla pliku wynikowego:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 24)
        Me.ProgressBar1.Maximum = 256
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(292, 22)
        Me.ProgressBar1.TabIndex = 1
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Matriksoft DeFragmenter"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PokażToolStripMenuItem, Me.ZakończToolStripMenuItem1, Me.ToolStripMenuItem3, Me.PlikToolStripMenuItem1, Me.WybierzFolderDocelowyToolStripMenuItem1, Me.ToolStripMenuItem4, Me.DefragmentujToolStripMenuItem1, Me.WłaściwościToolStripMenuItem1, Me.ToolStripMenuItem5, Me.OProgramieToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(204, 198)
        '
        'PokażToolStripMenuItem
        '
        Me.PokażToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PokażToolStripMenuItem.Name = "PokażToolStripMenuItem"
        Me.PokażToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.PokażToolStripMenuItem.Text = "&Pokaż"
        '
        'ZakończToolStripMenuItem1
        '
        Me.ZakończToolStripMenuItem1.Name = "ZakończToolStripMenuItem1"
        Me.ZakończToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ZakończToolStripMenuItem1.Text = "&Zakończ"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(200, 6)
        '
        'PlikToolStripMenuItem1
        '
        Me.PlikToolStripMenuItem1.Name = "PlikToolStripMenuItem1"
        Me.PlikToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.PlikToolStripMenuItem1.Text = "&Otwórz..."
        '
        'WybierzFolderDocelowyToolStripMenuItem1
        '
        Me.WybierzFolderDocelowyToolStripMenuItem1.Name = "WybierzFolderDocelowyToolStripMenuItem1"
        Me.WybierzFolderDocelowyToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.WybierzFolderDocelowyToolStripMenuItem1.Text = "W&ybierz folder docelowy"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(200, 6)
        '
        'DefragmentujToolStripMenuItem1
        '
        Me.DefragmentujToolStripMenuItem1.Name = "DefragmentujToolStripMenuItem1"
        Me.DefragmentujToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.DefragmentujToolStripMenuItem1.Text = "&Defragmentuj"
        '
        'WłaściwościToolStripMenuItem1
        '
        Me.WłaściwościToolStripMenuItem1.Name = "WłaściwościToolStripMenuItem1"
        Me.WłaściwościToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.WłaściwościToolStripMenuItem1.Text = "&Właściwości"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(200, 6)
        '
        'OProgramieToolStripMenuItem1
        '
        Me.OProgramieToolStripMenuItem1.Name = "OProgramieToolStripMenuItem1"
        Me.OProgramieToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.OProgramieToolStripMenuItem1.Text = "O p&rogramie..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 46)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 80)
        Me.MinimumSize = New System.Drawing.Size(150, 80)
        Me.Name = "Form1"
        Me.Text = "Matriksoft DeFragmenter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtwórzToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZakończToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PomocToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OProgramieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AkcjaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefragmentujToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents WłaściwościToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SchowajDoZasobnikaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PokażToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PlikToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DefragmentujToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WłaściwościToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OProgramieToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZakończToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WybierzFolderDocelowyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WybierzFolderDocelowyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
