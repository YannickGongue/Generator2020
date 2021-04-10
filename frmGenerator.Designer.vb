<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGenerator
	Inherits System.Windows.Forms.Form

	'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Wird vom Windows Form-Designer benötigt.
	Private components As System.ComponentModel.IContainer

	'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
	'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
	'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.tsmiAdmin = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmLogin = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmRegister = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmProfil = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmifileOfMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MitVorlageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LeerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmuiOpen = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.tsmuiSave = New System.Windows.Forms.ToolStripMenuItem()
		Me.SpeichernunterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImportierenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExportierenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SeitenansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RückgängigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.WiederholenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.AlleauswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AnpassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FensterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InhaltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pnlUserControl = New System.Windows.Forms.Panel()
		Me.pnlUserProfil = New System.Windows.Forms.Panel()
		Me.pbWatsap = New System.Windows.Forms.PictureBox()
		Me.pbFacebook = New System.Windows.Forms.PictureBox()
		Me.pbTweeter = New System.Windows.Forms.PictureBox()
		Me.MenuStrip1.SuspendLayout()
		Me.pnlUserControl.SuspendLayout()
		CType(Me.pbWatsap, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbFacebook, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbTweeter, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAdmin, Me.tsmifileOfMenu, Me.BearbeitenToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.FensterToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.HilfeToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
		Me.MenuStrip1.TabIndex = 8
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'tsmiAdmin
		'
		Me.tsmiAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmLogin, Me.tsmRegister, Me.tsmProfil})
		Me.tsmiAdmin.Name = "tsmiAdmin"
		Me.tsmiAdmin.Size = New System.Drawing.Size(55, 20)
		Me.tsmiAdmin.Text = "Admin"
		'
		'tsmLogin
		'
		Me.tsmLogin.Image = Global.Generator.My.Resources.Resources.secrecy_icon
		Me.tsmLogin.Name = "tsmLogin"
		Me.tsmLogin.Size = New System.Drawing.Size(136, 22)
		Me.tsmLogin.Text = "Anmelden"
		'
		'tsmRegister
		'
		Me.tsmRegister.Image = Global.Generator.My.Resources.Resources.note
		Me.tsmRegister.Name = "tsmRegister"
		Me.tsmRegister.Size = New System.Drawing.Size(136, 22)
		Me.tsmRegister.Text = "Registrieren"
		'
		'tsmProfil
		'
		Me.tsmProfil.Image = Global.Generator.My.Resources.Resources.user
		Me.tsmProfil.Name = "tsmProfil"
		Me.tsmProfil.Size = New System.Drawing.Size(136, 22)
		Me.tsmProfil.Text = "Profil"
		'
		'tsmifileOfMenu
		'
		Me.tsmifileOfMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.tsmuiOpen, Me.toolStripSeparator, Me.tsmuiSave, Me.SpeichernunterToolStripMenuItem, Me.ImportierenToolStripMenuItem1, Me.ExportierenToolStripMenuItem1, Me.toolStripSeparator1, Me.SchließenToolStripMenuItem, Me.DruckenToolStripMenuItem, Me.SeitenansichtToolStripMenuItem, Me.toolStripSeparator2, Me.BeendenToolStripMenuItem})
		Me.tsmifileOfMenu.Name = "tsmifileOfMenu"
		Me.tsmifileOfMenu.Size = New System.Drawing.Size(56, 20)
		Me.tsmifileOfMenu.Text = "Bericht"
		'
		'NeuToolStripMenuItem
		'
		Me.NeuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MitVorlageToolStripMenuItem, Me.LeerenToolStripMenuItem})
		Me.NeuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
		Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.NeuToolStripMenuItem.Text = "Neu"
		'
		'MitVorlageToolStripMenuItem
		'
		Me.MitVorlageToolStripMenuItem.Name = "MitVorlageToolStripMenuItem"
		Me.MitVorlageToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.MitVorlageToolStripMenuItem.Text = "Mit Vorlage"
		'
		'LeerenToolStripMenuItem
		'
		Me.LeerenToolStripMenuItem.Name = "LeerenToolStripMenuItem"
		Me.LeerenToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.LeerenToolStripMenuItem.Text = "Leeren"
		'
		'tsmuiOpen
		'
		Me.tsmuiOpen.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsmuiOpen.Name = "tsmuiOpen"
		Me.tsmuiOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.tsmuiOpen.Size = New System.Drawing.Size(180, 22)
		Me.tsmuiOpen.Text = "Ö&ffnen"
		'
		'toolStripSeparator
		'
		Me.toolStripSeparator.Name = "toolStripSeparator"
		Me.toolStripSeparator.Size = New System.Drawing.Size(177, 6)
		'
		'tsmuiSave
		'
		Me.tsmuiSave.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsmuiSave.Name = "tsmuiSave"
		Me.tsmuiSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.tsmuiSave.Size = New System.Drawing.Size(180, 22)
		Me.tsmuiSave.Text = "&Speichern"
		'
		'SpeichernunterToolStripMenuItem
		'
		Me.SpeichernunterToolStripMenuItem.Name = "SpeichernunterToolStripMenuItem"
		Me.SpeichernunterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.SpeichernunterToolStripMenuItem.Text = "Speichern &unter"
		'
		'ImportierenToolStripMenuItem1
		'
		Me.ImportierenToolStripMenuItem1.Name = "ImportierenToolStripMenuItem1"
		Me.ImportierenToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
		Me.ImportierenToolStripMenuItem1.Text = "Importieren"
		'
		'ExportierenToolStripMenuItem1
		'
		Me.ExportierenToolStripMenuItem1.Name = "ExportierenToolStripMenuItem1"
		Me.ExportierenToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
		Me.ExportierenToolStripMenuItem1.Text = "exportieren"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(177, 6)
		'
		'SchließenToolStripMenuItem
		'
		Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
		Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.SchließenToolStripMenuItem.Text = "schließen"
		'
		'DruckenToolStripMenuItem
		'
		Me.DruckenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
		Me.DruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
		Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.DruckenToolStripMenuItem.Text = "&Drucken"
		'
		'SeitenansichtToolStripMenuItem
		'
		Me.SeitenansichtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SeitenansichtToolStripMenuItem.Name = "SeitenansichtToolStripMenuItem"
		Me.SeitenansichtToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.SeitenansichtToolStripMenuItem.Text = "&Seitenansicht"
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(177, 6)
		'
		'BeendenToolStripMenuItem
		'
		Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
		Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.BeendenToolStripMenuItem.Text = "Programm Beenden"
		'
		'BearbeitenToolStripMenuItem
		'
		Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RückgängigToolStripMenuItem, Me.WiederholenToolStripMenuItem, Me.toolStripSeparator3, Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.toolStripSeparator4, Me.AlleauswählenToolStripMenuItem, Me.ImportierenToolStripMenuItem, Me.ExportierenToolStripMenuItem})
		Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
		Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
		Me.BearbeitenToolStripMenuItem.Text = "Daten"
		'
		'RückgängigToolStripMenuItem
		'
		Me.RückgängigToolStripMenuItem.Name = "RückgängigToolStripMenuItem"
		Me.RückgängigToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
		Me.RückgängigToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.RückgängigToolStripMenuItem.Text = "&Rückgängig"
		'
		'WiederholenToolStripMenuItem
		'
		Me.WiederholenToolStripMenuItem.Name = "WiederholenToolStripMenuItem"
		Me.WiederholenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
		Me.WiederholenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.WiederholenToolStripMenuItem.Text = "Wiede&rholen"
		'
		'toolStripSeparator3
		'
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		Me.toolStripSeparator3.Size = New System.Drawing.Size(188, 6)
		'
		'AusschneidenToolStripMenuItem
		'
		Me.AusschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
		Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.AusschneidenToolStripMenuItem.Text = "&Ausschneiden"
		'
		'KopierenToolStripMenuItem
		'
		Me.KopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
		Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.KopierenToolStripMenuItem.Text = "&Kopieren"
		'
		'EinfügenToolStripMenuItem
		'
		Me.EinfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
		Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
		Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.EinfügenToolStripMenuItem.Text = "&Einfügen"
		'
		'toolStripSeparator4
		'
		Me.toolStripSeparator4.Name = "toolStripSeparator4"
		Me.toolStripSeparator4.Size = New System.Drawing.Size(188, 6)
		'
		'AlleauswählenToolStripMenuItem
		'
		Me.AlleauswählenToolStripMenuItem.Name = "AlleauswählenToolStripMenuItem"
		Me.AlleauswählenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.AlleauswählenToolStripMenuItem.Text = "&Alle auswählen"
		'
		'ImportierenToolStripMenuItem
		'
		Me.ImportierenToolStripMenuItem.Name = "ImportierenToolStripMenuItem"
		Me.ImportierenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.ImportierenToolStripMenuItem.Text = "importieren"
		'
		'ExportierenToolStripMenuItem
		'
		Me.ExportierenToolStripMenuItem.Name = "ExportierenToolStripMenuItem"
		Me.ExportierenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.ExportierenToolStripMenuItem.Text = "exportieren"
		'
		'ExtrasToolStripMenuItem
		'
		Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnpassenToolStripMenuItem, Me.OptionenToolStripMenuItem})
		Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
		Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
		Me.ExtrasToolStripMenuItem.Text = "E&xtras"
		'
		'AnpassenToolStripMenuItem
		'
		Me.AnpassenToolStripMenuItem.Name = "AnpassenToolStripMenuItem"
		Me.AnpassenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
		Me.AnpassenToolStripMenuItem.Text = "&Anpassen"
		'
		'OptionenToolStripMenuItem
		'
		Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
		Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
		Me.OptionenToolStripMenuItem.Text = "&Optionen"
		'
		'FensterToolStripMenuItem
		'
		Me.FensterToolStripMenuItem.Name = "FensterToolStripMenuItem"
		Me.FensterToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
		Me.FensterToolStripMenuItem.Text = "Fenster"
		'
		'EinstellungenToolStripMenuItem
		'
		Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
		Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
		Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
		'
		'HilfeToolStripMenuItem
		'
		Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InhaltToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SuchenToolStripMenuItem, Me.toolStripSeparator5, Me.InfoToolStripMenuItem})
		Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
		Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HilfeToolStripMenuItem.Text = "&Hilfe"
		'
		'InhaltToolStripMenuItem
		'
		Me.InhaltToolStripMenuItem.Name = "InhaltToolStripMenuItem"
		Me.InhaltToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
		Me.InhaltToolStripMenuItem.Text = "I&nhalt"
		'
		'IndexToolStripMenuItem
		'
		Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
		Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
		Me.IndexToolStripMenuItem.Text = "&Index"
		'
		'SuchenToolStripMenuItem
		'
		Me.SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
		Me.SuchenToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
		Me.SuchenToolStripMenuItem.Text = "&Suchen"
		'
		'toolStripSeparator5
		'
		Me.toolStripSeparator5.Name = "toolStripSeparator5"
		Me.toolStripSeparator5.Size = New System.Drawing.Size(110, 6)
		'
		'InfoToolStripMenuItem
		'
		Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
		Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
		Me.InfoToolStripMenuItem.Text = "Inf&o..."
		'
		'pnlUserControl
		'
		Me.pnlUserControl.BackColor = System.Drawing.SystemColors.ControlLight
		Me.pnlUserControl.Controls.Add(Me.pnlUserProfil)
		Me.pnlUserControl.Location = New System.Drawing.Point(262, 43)
		Me.pnlUserControl.Name = "pnlUserControl"
		Me.pnlUserControl.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.pnlUserControl.Size = New System.Drawing.Size(686, 602)
		Me.pnlUserControl.TabIndex = 9
		'
		'pnlUserProfil
		'
		Me.pnlUserProfil.Location = New System.Drawing.Point(229, 55)
		Me.pnlUserProfil.Name = "pnlUserProfil"
		Me.pnlUserProfil.Size = New System.Drawing.Size(299, 414)
		Me.pnlUserProfil.TabIndex = 0
		'
		'pbWatsap
		'
		Me.pbWatsap.Image = Global.Generator.My.Resources.Resources.whatsapp_logo_33F6A82887_seeklogo_com_
		Me.pbWatsap.Location = New System.Drawing.Point(680, 651)
		Me.pbWatsap.Name = "pbWatsap"
		Me.pbWatsap.Size = New System.Drawing.Size(44, 41)
		Me.pbWatsap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbWatsap.TabIndex = 12
		Me.pbWatsap.TabStop = False
		'
		'pbFacebook
		'
		Me.pbFacebook.Image = Global.Generator.My.Resources.Resources.facebook_logos_PNG19757
		Me.pbFacebook.Location = New System.Drawing.Point(603, 651)
		Me.pbFacebook.Name = "pbFacebook"
		Me.pbFacebook.Size = New System.Drawing.Size(52, 41)
		Me.pbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbFacebook.TabIndex = 11
		Me.pbFacebook.TabStop = False
		'
		'pbTweeter
		'
		Me.pbTweeter.Image = Global.Generator.My.Resources.Resources.logo_twitter_icon_symbol_0
		Me.pbTweeter.Location = New System.Drawing.Point(534, 651)
		Me.pbTweeter.Name = "pbTweeter"
		Me.pbTweeter.Size = New System.Drawing.Size(44, 41)
		Me.pbTweeter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbTweeter.TabIndex = 10
		Me.pbTweeter.TabStop = False
		'
		'frmGenerator
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLight
		Me.ClientSize = New System.Drawing.Size(1008, 704)
		Me.Controls.Add(Me.pbWatsap)
		Me.Controls.Add(Me.pbFacebook)
		Me.Controls.Add(Me.pbTweeter)
		Me.Controls.Add(Me.pnlUserControl)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "frmGenerator"
		Me.Text = "Generator"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.pnlUserControl.ResumeLayout(False)
		CType(Me.pbWatsap, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbFacebook, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbTweeter, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RückgängigToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents WiederholenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents toolStripSeparator3 As ToolStripSeparator
	Friend WithEvents AusschneidenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KopierenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EinfügenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents toolStripSeparator4 As ToolStripSeparator
	Friend WithEvents AlleauswählenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExtrasToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AnpassenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OptionenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InhaltToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SuchenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents toolStripSeparator5 As ToolStripSeparator
	Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents tsmifileOfMenu As ToolStripMenuItem
	Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents tsmuiOpen As ToolStripMenuItem
	Friend WithEvents toolStripSeparator As ToolStripSeparator
	Friend WithEvents tsmuiSave As ToolStripMenuItem
	Friend WithEvents SpeichernunterToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents toolStripSeparator1 As ToolStripSeparator
	Friend WithEvents DruckenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SeitenansichtToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents toolStripSeparator2 As ToolStripSeparator
	Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents tsmiAdmin As ToolStripMenuItem
	Friend WithEvents tsmRegister As ToolStripMenuItem
	Friend WithEvents tsmLogin As ToolStripMenuItem
	Friend WithEvents pnlUserControl As Panel
	Friend WithEvents tsmProfil As ToolStripMenuItem
	Friend WithEvents ImportierenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExportierenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FensterToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents pbTweeter As PictureBox
	Friend WithEvents pbFacebook As PictureBox
	Friend WithEvents pbWatsap As PictureBox
	Friend WithEvents pnlUserProfil As Panel
	Friend WithEvents ImportierenToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ExportierenToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents SchließenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MitVorlageToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LeerenToolStripMenuItem As ToolStripMenuItem
End Class
