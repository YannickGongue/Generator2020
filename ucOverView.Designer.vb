<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOverView
	Inherits System.Windows.Forms.UserControl

	'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

	'Wird vom Windows Form-Designer benötigt.
	Private components As System.ComponentModel.IContainer

	'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
	'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
	'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim mtbOrdernummer As System.Windows.Forms.MaskedTextBox
		Me.gbClient = New System.Windows.Forms.GroupBox()
		Me.mtbReleaseDate = New System.Windows.Forms.MaskedTextBox()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.tbCustomer = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.cbReleaseStatut = New System.Windows.Forms.ComboBox()
		Me.tbCount = New System.Windows.Forms.TextBox()
		Me.tbCustomerHardware = New System.Windows.Forms.TextBox()
		Me.tbCustomeChangeNr = New System.Windows.Forms.TextBox()
		Me.tbWorkPlace = New System.Windows.Forms.TextBox()
		Me.tbCustomerSoftware = New System.Windows.Forms.TextBox()
		Me.cbCustomerFirm = New System.Windows.Forms.ComboBox()
		Me.cbCustomerId = New System.Windows.Forms.ComboBox()
		Me.pnlUseControl = New System.Windows.Forms.Panel()
		Me.tvNavigation = New System.Windows.Forms.TreeView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.cbCategoriSort = New System.Windows.Forms.ComboBox()
		Me.cbReportSort = New System.Windows.Forms.ComboBox()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.tbLastUser = New System.Windows.Forms.TextBox()
		Me.tbChangedate = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.tbRemark = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.tbHardware = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.cbCustomer = New System.Windows.Forms.ComboBox()
		Me.tbReportnr = New System.Windows.Forms.TextBox()
		Me.tbSenddate = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lbl = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.mtbChangeNummer = New System.Windows.Forms.MaskedTextBox()
		Me.mtbSoftware = New System.Windows.Forms.MaskedTextBox()
		Me.mtbOrderDate = New System.Windows.Forms.MaskedTextBox()
		Me.mtbDeliverDate = New System.Windows.Forms.MaskedTextBox()
		Me.mtbRecieverdate = New System.Windows.Forms.MaskedTextBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		mtbOrdernummer = New System.Windows.Forms.MaskedTextBox()
		Me.gbClient.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'mtbOrdernummer
		'
		mtbOrdernummer.Location = New System.Drawing.Point(106, 19)
		mtbOrdernummer.Mask = "00/00/0000"
		mtbOrdernummer.Name = "mtbOrdernummer"
		mtbOrdernummer.Size = New System.Drawing.Size(67, 20)
		mtbOrdernummer.TabIndex = 15
		mtbOrdernummer.ValidatingType = GetType(Date)
		'
		'gbClient
		'
		Me.gbClient.Controls.Add(Me.mtbReleaseDate)
		Me.gbClient.Controls.Add(Me.Label20)
		Me.gbClient.Controls.Add(Me.Label19)
		Me.gbClient.Controls.Add(Me.Label18)
		Me.gbClient.Controls.Add(Me.tbCustomer)
		Me.gbClient.Controls.Add(Me.Label17)
		Me.gbClient.Controls.Add(Me.Label16)
		Me.gbClient.Controls.Add(Me.Label15)
		Me.gbClient.Controls.Add(Me.Label14)
		Me.gbClient.Controls.Add(Me.Label13)
		Me.gbClient.Controls.Add(Me.Label12)
		Me.gbClient.Controls.Add(Me.Label11)
		Me.gbClient.Controls.Add(Me.cbReleaseStatut)
		Me.gbClient.Controls.Add(Me.tbCount)
		Me.gbClient.Controls.Add(Me.tbCustomerHardware)
		Me.gbClient.Controls.Add(Me.tbCustomeChangeNr)
		Me.gbClient.Controls.Add(Me.tbWorkPlace)
		Me.gbClient.Controls.Add(Me.tbCustomerSoftware)
		Me.gbClient.Controls.Add(Me.cbCustomerFirm)
		Me.gbClient.Controls.Add(Me.cbCustomerId)
		Me.gbClient.Controls.Add(Me.pnlUseControl)
		Me.gbClient.ForeColor = System.Drawing.SystemColors.HotTrack
		Me.gbClient.Location = New System.Drawing.Point(12, 286)
		Me.gbClient.Name = "gbClient"
		Me.gbClient.Size = New System.Drawing.Size(385, 286)
		Me.gbClient.TabIndex = 7
		Me.gbClient.TabStop = False
		Me.gbClient.Text = "Kunden"
		'
		'mtbReleaseDate
		'
		Me.mtbReleaseDate.Location = New System.Drawing.Point(109, 243)
		Me.mtbReleaseDate.Mask = "00/00/0000"
		Me.mtbReleaseDate.Name = "mtbReleaseDate"
		Me.mtbReleaseDate.Size = New System.Drawing.Size(67, 20)
		Me.mtbReleaseDate.TabIndex = 37
		Me.mtbReleaseDate.ValidatingType = GetType(Date)
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label20.Location = New System.Drawing.Point(15, 246)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(77, 13)
		Me.Label20.TabIndex = 36
		Me.Label20.Text = "Freigabedatum"
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label19.Location = New System.Drawing.Point(15, 223)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(76, 13)
		Me.Label19.TabIndex = 35
		Me.Label19.Text = "Freigabestatus"
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label18.Location = New System.Drawing.Point(15, 202)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(39, 13)
		Me.Label18.TabIndex = 34
		Me.Label18.Text = "Anzahl"
		'
		'tbCustomer
		'
		Me.tbCustomer.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.tbCustomer.Location = New System.Drawing.Point(106, 26)
		Me.tbCustomer.Name = "tbCustomer"
		Me.tbCustomer.Size = New System.Drawing.Size(158, 20)
		Me.tbCustomer.TabIndex = 18
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label17.Location = New System.Drawing.Point(15, 179)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(80, 13)
		Me.Label17.TabIndex = 33
		Me.Label17.Text = "Hardwaredaten"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Location = New System.Drawing.Point(9, 151)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(76, 13)
		Me.Label16.TabIndex = 32
		Me.Label16.Text = "Softwaredaten"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Location = New System.Drawing.Point(12, 132)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(44, 13)
		Me.Label15.TabIndex = 31
		Me.Label15.Text = "Position"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Location = New System.Drawing.Point(9, 106)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(95, 13)
		Me.Label14.TabIndex = 30
		Me.Label14.Text = "Änderungsnummer"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Location = New System.Drawing.Point(9, 52)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(63, 13)
		Me.Label13.TabIndex = 29
		Me.Label13.Text = "KundeCode"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Location = New System.Drawing.Point(10, 77)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(61, 13)
		Me.Label12.TabIndex = 28
		Me.Label12.Text = "Kundewerk"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Location = New System.Drawing.Point(12, 29)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(38, 13)
		Me.Label11.TabIndex = 27
		Me.Label11.Text = "Kunde"
		'
		'cbReleaseStatut
		'
		Me.cbReleaseStatut.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.cbReleaseStatut.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.cbReleaseStatut.FormattingEnabled = True
		Me.cbReleaseStatut.Location = New System.Drawing.Point(109, 220)
		Me.cbReleaseStatut.Name = "cbReleaseStatut"
		Me.cbReleaseStatut.Size = New System.Drawing.Size(122, 21)
		Me.cbReleaseStatut.TabIndex = 25
		'
		'tbCount
		'
		Me.tbCount.Location = New System.Drawing.Point(109, 199)
		Me.tbCount.Name = "tbCount"
		Me.tbCount.Size = New System.Drawing.Size(67, 20)
		Me.tbCount.TabIndex = 24
		'
		'tbCustomerHardware
		'
		Me.tbCustomerHardware.Location = New System.Drawing.Point(109, 176)
		Me.tbCustomerHardware.Name = "tbCustomerHardware"
		Me.tbCustomerHardware.Size = New System.Drawing.Size(155, 20)
		Me.tbCustomerHardware.TabIndex = 23
		'
		'tbCustomeChangeNr
		'
		Me.tbCustomeChangeNr.Location = New System.Drawing.Point(109, 99)
		Me.tbCustomeChangeNr.Name = "tbCustomeChangeNr"
		Me.tbCustomeChangeNr.Size = New System.Drawing.Size(158, 20)
		Me.tbCustomeChangeNr.TabIndex = 18
		'
		'tbWorkPlace
		'
		Me.tbWorkPlace.Location = New System.Drawing.Point(109, 125)
		Me.tbWorkPlace.Name = "tbWorkPlace"
		Me.tbWorkPlace.Size = New System.Drawing.Size(169, 20)
		Me.tbWorkPlace.TabIndex = 22
		'
		'tbCustomerSoftware
		'
		Me.tbCustomerSoftware.Location = New System.Drawing.Point(109, 150)
		Me.tbCustomerSoftware.Name = "tbCustomerSoftware"
		Me.tbCustomerSoftware.Size = New System.Drawing.Size(155, 20)
		Me.tbCustomerSoftware.TabIndex = 21
		'
		'cbCustomerFirm
		'
		Me.cbCustomerFirm.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.cbCustomerFirm.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.cbCustomerFirm.FormattingEnabled = True
		Me.cbCustomerFirm.Location = New System.Drawing.Point(109, 74)
		Me.cbCustomerFirm.Name = "cbCustomerFirm"
		Me.cbCustomerFirm.Size = New System.Drawing.Size(55, 21)
		Me.cbCustomerFirm.TabIndex = 20
		'
		'cbCustomerId
		'
		Me.cbCustomerId.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.cbCustomerId.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.cbCustomerId.FormattingEnabled = True
		Me.cbCustomerId.Location = New System.Drawing.Point(109, 49)
		Me.cbCustomerId.Name = "cbCustomerId"
		Me.cbCustomerId.Size = New System.Drawing.Size(55, 21)
		Me.cbCustomerId.TabIndex = 19
		'
		'pnlUseControl
		'
		Me.pnlUseControl.Location = New System.Drawing.Point(-6, -261)
		Me.pnlUseControl.Name = "pnlUseControl"
		Me.pnlUseControl.Size = New System.Drawing.Size(597, 255)
		Me.pnlUseControl.TabIndex = 38
		'
		'tvNavigation
		'
		Me.tvNavigation.CheckBoxes = True
		Me.tvNavigation.Dock = System.Windows.Forms.DockStyle.Left
		Me.tvNavigation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tvNavigation.Location = New System.Drawing.Point(3, 16)
		Me.tvNavigation.Name = "tvNavigation"
		Me.tvNavigation.Size = New System.Drawing.Size(200, 559)
		Me.tvNavigation.TabIndex = 0
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.tvNavigation)
		Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
		Me.GroupBox1.Location = New System.Drawing.Point(-124, -37)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(39, 578)
		Me.GroupBox1.TabIndex = 5
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Navigation"
		'
		'cbCategoriSort
		'
		Me.cbCategoriSort.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.cbCategoriSort.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.cbCategoriSort.FormattingEnabled = True
		Me.cbCategoriSort.Location = New System.Drawing.Point(110, 36)
		Me.cbCategoriSort.Name = "cbCategoriSort"
		Me.cbCategoriSort.Size = New System.Drawing.Size(76, 21)
		Me.cbCategoriSort.TabIndex = 13
		'
		'cbReportSort
		'
		Me.cbReportSort.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.cbReportSort.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.cbReportSort.FormattingEnabled = True
		Me.cbReportSort.Location = New System.Drawing.Point(110, 13)
		Me.cbReportSort.Name = "cbReportSort"
		Me.cbReportSort.Size = New System.Drawing.Size(76, 21)
		Me.cbReportSort.TabIndex = 14
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label21.Location = New System.Drawing.Point(15, 19)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(52, 13)
		Me.Label21.TabIndex = 15
		Me.Label21.Text = "Berichtart"
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label22.Location = New System.Drawing.Point(15, 39)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(69, 13)
		Me.Label22.TabIndex = 16
		Me.Label22.Text = "Kategoriesart"
		'
		'tbLastUser
		'
		Me.tbLastUser.Location = New System.Drawing.Point(110, 496)
		Me.tbLastUser.Name = "tbLastUser"
		Me.tbLastUser.Size = New System.Drawing.Size(158, 20)
		Me.tbLastUser.TabIndex = 19
		'
		'tbChangedate
		'
		Me.tbChangedate.Location = New System.Drawing.Point(110, 522)
		Me.tbChangedate.Name = "tbChangedate"
		Me.tbChangedate.Size = New System.Drawing.Size(158, 20)
		Me.tbChangedate.TabIndex = 20
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(110, 58)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(140, 20)
		Me.TextBox3.TabIndex = 21
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label23.Location = New System.Drawing.Point(18, 58)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(66, 13)
		Me.Label23.TabIndex = 22
		Me.Label23.Text = "Id_kategorie"
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label24.Location = New System.Drawing.Point(6, 499)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(87, 13)
		Me.Label24.TabIndex = 23
		Me.Label24.Text = "Letzte Bearbeiter"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label25.Location = New System.Drawing.Point(6, 525)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(87, 13)
		Me.Label25.TabIndex = 17
		Me.Label25.Text = "Änderungsdatum"
		'
		'tbRemark
		'
		Me.tbRemark.Location = New System.Drawing.Point(9, 97)
		Me.tbRemark.Multiline = True
		Me.tbRemark.Name = "tbRemark"
		Me.tbRemark.Size = New System.Drawing.Size(262, 392)
		Me.tbRemark.TabIndex = 24
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(6, 82)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(73, 13)
		Me.Label8.TabIndex = 25
		Me.Label8.Text = "Bemerkungen"
		'
		'tbHardware
		'
		Me.tbHardware.Location = New System.Drawing.Point(106, 113)
		Me.tbHardware.Name = "tbHardware"
		Me.tbHardware.Size = New System.Drawing.Size(178, 20)
		Me.tbHardware.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(9, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Bestellnummer :"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(7, 48)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(78, 13)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "KundenCodeId"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(6, 70)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(95, 13)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Änderungsnummer"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(4, 94)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(81, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Softwaresdaten"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(6, 116)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(80, 13)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "Hardwaredaten"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(6, 142)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(82, 13)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Berichtsnummer"
		'
		'cbCustomer
		'
		Me.cbCustomer.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.cbCustomer.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.cbCustomer.FormattingEnabled = True
		Me.cbCustomer.Location = New System.Drawing.Point(106, 41)
		Me.cbCustomer.Name = "cbCustomer"
		Me.cbCustomer.Size = New System.Drawing.Size(125, 21)
		Me.cbCustomer.TabIndex = 12
		'
		'tbReportnr
		'
		Me.tbReportnr.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.tbReportnr.ForeColor = System.Drawing.SystemColors.ScrollBar
		Me.tbReportnr.Location = New System.Drawing.Point(106, 139)
		Me.tbReportnr.Name = "tbReportnr"
		Me.tbReportnr.Size = New System.Drawing.Size(24, 20)
		Me.tbReportnr.TabIndex = 13
		'
		'tbSenddate
		'
		Me.tbSenddate.Location = New System.Drawing.Point(106, 165)
		Me.tbSenddate.Name = "tbSenddate"
		Me.tbSenddate.Size = New System.Drawing.Size(67, 20)
		Me.tbSenddate.TabIndex = 14
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(7, 165)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(69, 13)
		Me.Label4.TabIndex = 18
		Me.Label4.Text = "Versandatum"
		'
		'lbl
		'
		Me.lbl.AutoSize = True
		Me.lbl.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbl.Location = New System.Drawing.Point(6, 192)
		Me.lbl.Name = "lbl"
		Me.lbl.Size = New System.Drawing.Size(70, 13)
		Me.lbl.TabIndex = 19
		Me.lbl.Text = "Bestelltdatum"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Location = New System.Drawing.Point(9, 214)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(75, 13)
		Me.Label9.TabIndex = 20
		Me.Label9.Text = "AbLieferdatum"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Location = New System.Drawing.Point(9, 237)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(71, 13)
		Me.Label10.TabIndex = 21
		Me.Label10.Text = "Anlieferdatum"
		'
		'mtbChangeNummer
		'
		Me.mtbChangeNummer.Location = New System.Drawing.Point(106, 67)
		Me.mtbChangeNummer.Mask = "00/00/0000"
		Me.mtbChangeNummer.Name = "mtbChangeNummer"
		Me.mtbChangeNummer.Size = New System.Drawing.Size(67, 20)
		Me.mtbChangeNummer.TabIndex = 22
		Me.mtbChangeNummer.ValidatingType = GetType(Date)
		'
		'mtbSoftware
		'
		Me.mtbSoftware.Location = New System.Drawing.Point(106, 91)
		Me.mtbSoftware.Mask = "00/00/0000"
		Me.mtbSoftware.Name = "mtbSoftware"
		Me.mtbSoftware.Size = New System.Drawing.Size(67, 20)
		Me.mtbSoftware.TabIndex = 23
		Me.mtbSoftware.ValidatingType = GetType(Date)
		'
		'mtbOrderDate
		'
		Me.mtbOrderDate.Location = New System.Drawing.Point(106, 189)
		Me.mtbOrderDate.Mask = "00/00/0000"
		Me.mtbOrderDate.Name = "mtbOrderDate"
		Me.mtbOrderDate.Size = New System.Drawing.Size(67, 20)
		Me.mtbOrderDate.TabIndex = 24
		Me.mtbOrderDate.ValidatingType = GetType(Date)
		'
		'mtbDeliverDate
		'
		Me.mtbDeliverDate.Location = New System.Drawing.Point(106, 214)
		Me.mtbDeliverDate.Mask = "00/00/0000"
		Me.mtbDeliverDate.Name = "mtbDeliverDate"
		Me.mtbDeliverDate.Size = New System.Drawing.Size(67, 20)
		Me.mtbDeliverDate.TabIndex = 25
		Me.mtbDeliverDate.ValidatingType = GetType(Date)
		'
		'mtbRecieverdate
		'
		Me.mtbRecieverdate.Location = New System.Drawing.Point(106, 237)
		Me.mtbRecieverdate.Mask = "00/00/0000"
		Me.mtbRecieverdate.Name = "mtbRecieverdate"
		Me.mtbRecieverdate.Size = New System.Drawing.Size(67, 20)
		Me.mtbRecieverdate.TabIndex = 26
		Me.mtbRecieverdate.ValidatingType = GetType(Date)
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.tbHardware)
		Me.GroupBox2.Controls.Add(Me.mtbSoftware)
		Me.GroupBox2.Controls.Add(Me.mtbChangeNummer)
		Me.GroupBox2.Controls.Add(mtbOrdernummer)
		Me.GroupBox2.Controls.Add(Me.cbCustomer)
		Me.GroupBox2.Controls.Add(Me.Label10)
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.lbl)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.mtbRecieverdate)
		Me.GroupBox2.Controls.Add(Me.mtbDeliverDate)
		Me.GroupBox2.Controls.Add(Me.mtbOrderDate)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.tbSenddate)
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Controls.Add(Me.tbReportnr)
		Me.GroupBox2.Controls.Add(Me.Panel1)
		Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
		Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(385, 283)
		Me.GroupBox2.TabIndex = 27
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Personal"
		'
		'Panel1
		'
		Me.Panel1.Location = New System.Drawing.Point(-16, 308)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(406, 260)
		Me.Panel1.TabIndex = 27
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.tbRemark)
		Me.GroupBox3.Controls.Add(Me.Label24)
		Me.GroupBox3.Controls.Add(Me.tbLastUser)
		Me.GroupBox3.Controls.Add(Me.Label25)
		Me.GroupBox3.Controls.Add(Me.Label8)
		Me.GroupBox3.Controls.Add(Me.tbChangedate)
		Me.GroupBox3.Controls.Add(Me.Label23)
		Me.GroupBox3.Controls.Add(Me.cbReportSort)
		Me.GroupBox3.Controls.Add(Me.cbCategoriSort)
		Me.GroupBox3.Controls.Add(Me.Label21)
		Me.GroupBox3.Controls.Add(Me.TextBox3)
		Me.GroupBox3.Controls.Add(Me.Label22)
		Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Highlight
		Me.GroupBox3.Location = New System.Drawing.Point(417, 3)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(282, 569)
		Me.GroupBox3.TabIndex = 28
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Allgemein"
		'
		'ucOverView
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.gbClient)
		Me.Name = "ucOverView"
		Me.Size = New System.Drawing.Size(706, 586)
		Me.gbClient.ResumeLayout(False)
		Me.gbClient.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents gbClient As GroupBox
	Friend WithEvents mtbReleaseDate As MaskedTextBox
	Friend WithEvents Label20 As Label
	Friend WithEvents Label19 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents tbCustomer As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents cbReleaseStatut As ComboBox
	Friend WithEvents tbCount As TextBox
	Friend WithEvents tbCustomerHardware As TextBox
	Friend WithEvents tbCustomeChangeNr As TextBox
	Friend WithEvents tbWorkPlace As TextBox
	Friend WithEvents tbCustomerSoftware As TextBox
	Friend WithEvents cbCustomerFirm As ComboBox
	Friend WithEvents cbCustomerId As ComboBox
	Friend WithEvents pnlUseControl As Panel
	Friend WithEvents tvNavigation As TreeView
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents cbCategoriSort As ComboBox
	Friend WithEvents cbReportSort As ComboBox
	Friend WithEvents Label21 As Label
	Friend WithEvents Label22 As Label
	Friend WithEvents tbLastUser As TextBox
	Friend WithEvents tbChangedate As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label23 As Label
	Friend WithEvents Label24 As Label
	Friend WithEvents Label25 As Label
	Friend WithEvents tbRemark As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents tbHardware As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents cbCustomer As ComboBox
	Friend WithEvents tbReportnr As TextBox
	Friend WithEvents tbSenddate As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents lbl As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents mtbChangeNummer As MaskedTextBox
	Friend WithEvents mtbSoftware As MaskedTextBox
	Friend WithEvents mtbOrderDate As MaskedTextBox
	Friend WithEvents mtbDeliverDate As MaskedTextBox
	Friend WithEvents mtbRecieverdate As MaskedTextBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Panel1 As Panel
End Class
