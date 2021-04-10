<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRegistrationInGenerator
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
		Me.lblNachname = New System.Windows.Forms.Label()
		Me.lblVorname = New System.Windows.Forms.Label()
		Me.lblPlz = New System.Windows.Forms.Label()
		Me.lblstrace = New System.Windows.Forms.Label()
		Me.lblBirthday = New System.Windows.Forms.Label()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.tbFirstName = New System.Windows.Forms.TextBox()
		Me.tbLastName = New System.Windows.Forms.TextBox()
		Me.lblCity = New System.Windows.Forms.Label()
		Me.tbCity = New System.Windows.Forms.TextBox()
		Me.tbPlz = New System.Windows.Forms.TextBox()
		Me.lblNr = New System.Windows.Forms.Label()
		Me.tbNr = New System.Windows.Forms.TextBox()
		Me.tbStreet = New System.Windows.Forms.TextBox()
		Me.tbEmail = New System.Windows.Forms.TextBox()
		Me.tbTelephon = New System.Windows.Forms.TextBox()
		Me.LblCallNumber = New System.Windows.Forms.Label()
		Me.rbMann = New System.Windows.Forms.RadioButton()
		Me.rbFrau = New System.Windows.Forms.RadioButton()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.lblBenutzername = New System.Windows.Forms.Label()
		Me.tbPassword = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.tbUsername = New System.Windows.Forms.TextBox()
		Me.tbConfirm = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
		Me.lblUser_Id = New System.Windows.Forms.Label()
		Me.tbUser_ID = New System.Windows.Forms.TextBox()
		Me.gbGender = New System.Windows.Forms.GroupBox()
		Me.gbSicherheitsInfo = New System.Windows.Forms.GroupBox()
		Me.lblQuestion1 = New System.Windows.Forms.Label()
		Me.tbAnswer3 = New System.Windows.Forms.TextBox()
		Me.tbAnswer2 = New System.Windows.Forms.TextBox()
		Me.tbAnswer1 = New System.Windows.Forms.TextBox()
		Me.cbQuestion3 = New System.Windows.Forms.ComboBox()
		Me.cbQuestion2 = New System.Windows.Forms.ComboBox()
		Me.cbQuestion1 = New System.Windows.Forms.ComboBox()
		Me.lblAnswer3 = New System.Windows.Forms.Label()
		Me.lblQuestion2 = New System.Windows.Forms.Label()
		Me.lblAnswer2 = New System.Windows.Forms.Label()
		Me.lblQuestion3 = New System.Windows.Forms.Label()
		Me.lblAnswer1 = New System.Windows.Forms.Label()
		Me.cbShowPassword = New System.Windows.Forms.CheckBox()
		Me.pnlUserRegistration = New System.Windows.Forms.Panel()
		Me.gbGender.SuspendLayout()
		Me.gbSicherheitsInfo.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblNachname
		'
		Me.lblNachname.AutoSize = True
		Me.lblNachname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNachname.Location = New System.Drawing.Point(14, 49)
		Me.lblNachname.Name = "lblNachname"
		Me.lblNachname.Size = New System.Drawing.Size(80, 13)
		Me.lblNachname.TabIndex = 0
		Me.lblNachname.Text = "Nachname *:"
		'
		'lblVorname
		'
		Me.lblVorname.AutoSize = True
		Me.lblVorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVorname.Location = New System.Drawing.Point(293, 42)
		Me.lblVorname.Name = "lblVorname"
		Me.lblVorname.Size = New System.Drawing.Size(64, 13)
		Me.lblVorname.TabIndex = 1
		Me.lblVorname.Text = "Vorname :"
		'
		'lblPlz
		'
		Me.lblPlz.AutoSize = True
		Me.lblPlz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlz.Location = New System.Drawing.Point(14, 149)
		Me.lblPlz.Name = "lblPlz"
		Me.lblPlz.Size = New System.Drawing.Size(37, 13)
		Me.lblPlz.TabIndex = 2
		Me.lblPlz.Text = "Plz* :"
		'
		'lblstrace
		'
		Me.lblstrace.AutoSize = True
		Me.lblstrace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblstrace.Location = New System.Drawing.Point(14, 108)
		Me.lblstrace.Name = "lblstrace"
		Me.lblstrace.Size = New System.Drawing.Size(57, 13)
		Me.lblstrace.TabIndex = 3
		Me.lblstrace.Text = "Straße* :"
		'
		'lblBirthday
		'
		Me.lblBirthday.AutoSize = True
		Me.lblBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBirthday.Location = New System.Drawing.Point(14, 77)
		Me.lblBirthday.Name = "lblBirthday"
		Me.lblBirthday.Size = New System.Drawing.Size(98, 13)
		Me.lblBirthday.TabIndex = 4
		Me.lblBirthday.Text = "Geburtsdatum* :"
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEmail.Location = New System.Drawing.Point(11, 176)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(46, 13)
		Me.lblEmail.TabIndex = 5
		Me.lblEmail.Text = "Email*:"
		'
		'tbFirstName
		'
		Me.tbFirstName.Location = New System.Drawing.Point(100, 42)
		Me.tbFirstName.Name = "tbFirstName"
		Me.tbFirstName.Size = New System.Drawing.Size(178, 20)
		Me.tbFirstName.TabIndex = 8
		'
		'tbLastName
		'
		Me.tbLastName.Location = New System.Drawing.Point(363, 39)
		Me.tbLastName.Name = "tbLastName"
		Me.tbLastName.Size = New System.Drawing.Size(160, 20)
		Me.tbLastName.TabIndex = 9
		'
		'lblCity
		'
		Me.lblCity.AutoSize = True
		Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCity.Location = New System.Drawing.Point(237, 149)
		Me.lblCity.Name = "lblCity"
		Me.lblCity.Size = New System.Drawing.Size(50, 13)
		Me.lblCity.TabIndex = 15
		Me.lblCity.Text = "Stadt* :"
		'
		'tbCity
		'
		Me.tbCity.Location = New System.Drawing.Point(293, 142)
		Me.tbCity.Name = "tbCity"
		Me.tbCity.Size = New System.Drawing.Size(174, 20)
		Me.tbCity.TabIndex = 14
		'
		'tbPlz
		'
		Me.tbPlz.Location = New System.Drawing.Point(74, 142)
		Me.tbPlz.Name = "tbPlz"
		Me.tbPlz.Size = New System.Drawing.Size(135, 20)
		Me.tbPlz.TabIndex = 13
		'
		'lblNr
		'
		Me.lblNr.AutoSize = True
		Me.lblNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNr.Location = New System.Drawing.Point(234, 108)
		Me.lblNr.Name = "lblNr"
		Me.lblNr.Size = New System.Drawing.Size(33, 13)
		Me.lblNr.TabIndex = 12
		Me.lblNr.Text = "Nr* :"
		'
		'tbNr
		'
		Me.tbNr.Location = New System.Drawing.Point(274, 101)
		Me.tbNr.Name = "tbNr"
		Me.tbNr.Size = New System.Drawing.Size(44, 20)
		Me.tbNr.TabIndex = 11
		'
		'tbStreet
		'
		Me.tbStreet.Location = New System.Drawing.Point(74, 108)
		Me.tbStreet.Name = "tbStreet"
		Me.tbStreet.Size = New System.Drawing.Size(132, 20)
		Me.tbStreet.TabIndex = 10
		'
		'tbEmail
		'
		Me.tbEmail.Location = New System.Drawing.Point(74, 176)
		Me.tbEmail.Name = "tbEmail"
		Me.tbEmail.Size = New System.Drawing.Size(224, 20)
		Me.tbEmail.TabIndex = 17
		'
		'tbTelephon
		'
		Me.tbTelephon.Location = New System.Drawing.Point(363, 173)
		Me.tbTelephon.Name = "tbTelephon"
		Me.tbTelephon.Size = New System.Drawing.Size(160, 20)
		Me.tbTelephon.TabIndex = 18
		'
		'LblCallNumber
		'
		Me.LblCallNumber.AutoSize = True
		Me.LblCallNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblCallNumber.Location = New System.Drawing.Point(304, 179)
		Me.LblCallNumber.Name = "LblCallNumber"
		Me.LblCallNumber.Size = New System.Drawing.Size(59, 13)
		Me.LblCallNumber.TabIndex = 19
		Me.LblCallNumber.Text = "Telefon*:"
		'
		'rbMann
		'
		Me.rbMann.AutoSize = True
		Me.rbMann.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbMann.Location = New System.Drawing.Point(6, 12)
		Me.rbMann.Name = "rbMann"
		Me.rbMann.Size = New System.Drawing.Size(35, 17)
		Me.rbMann.TabIndex = 20
		Me.rbMann.TabStop = True
		Me.rbMann.Text = "M"
		Me.rbMann.UseVisualStyleBackColor = True
		'
		'rbFrau
		'
		Me.rbFrau.AutoSize = True
		Me.rbFrau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbFrau.Location = New System.Drawing.Point(65, 10)
		Me.rbFrau.Name = "rbFrau"
		Me.rbFrau.Size = New System.Drawing.Size(33, 19)
		Me.rbFrau.TabIndex = 21
		Me.rbFrau.TabStop = True
		Me.rbFrau.Text = "F"
		Me.rbFrau.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(14, 19)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(84, 13)
		Me.Label2.TabIndex = 22
		Me.Label2.Text = "Geschlecht* :"
		'
		'btnExit
		'
		Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(434, 546)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(92, 23)
		Me.btnExit.TabIndex = 23
		Me.btnExit.Text = "Abbrechen"
		Me.btnExit.UseVisualStyleBackColor = False
		'
		'btnSave
		'
		Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.Location = New System.Drawing.Point(307, 546)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(89, 23)
		Me.btnSave.TabIndex = 24
		Me.btnSave.Text = "Speichern"
		Me.btnSave.UseVisualStyleBackColor = False
		'
		'lblBenutzername
		'
		Me.lblBenutzername.AutoSize = True
		Me.lblBenutzername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBenutzername.Location = New System.Drawing.Point(11, 239)
		Me.lblBenutzername.Name = "lblBenutzername"
		Me.lblBenutzername.Size = New System.Drawing.Size(110, 15)
		Me.lblBenutzername.TabIndex = 25
		Me.lblBenutzername.Text = "Benutzername*:"
		'
		'tbPassword
		'
		Me.tbPassword.Location = New System.Drawing.Point(122, 266)
		Me.tbPassword.Name = "tbPassword"
		Me.tbPassword.Size = New System.Drawing.Size(401, 20)
		Me.tbPassword.TabIndex = 26
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(11, 266)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(75, 15)
		Me.Label3.TabIndex = 28
		Me.Label3.Text = "Passwort*:"
		'
		'tbUsername
		'
		Me.tbUsername.Location = New System.Drawing.Point(127, 240)
		Me.tbUsername.Name = "tbUsername"
		Me.tbUsername.Size = New System.Drawing.Size(396, 20)
		Me.tbUsername.TabIndex = 29
		'
		'tbConfirm
		'
		Me.tbConfirm.Location = New System.Drawing.Point(122, 292)
		Me.tbConfirm.Name = "tbConfirm"
		Me.tbConfirm.Size = New System.Drawing.Size(401, 20)
		Me.tbConfirm.TabIndex = 30
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(11, 293)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(93, 15)
		Me.Label4.TabIndex = 31
		Me.Label4.Text = "Bestätigung*:"
		'
		'dtpBirthday
		'
		Me.dtpBirthday.Location = New System.Drawing.Point(118, 71)
		Me.dtpBirthday.Name = "dtpBirthday"
		Me.dtpBirthday.Size = New System.Drawing.Size(200, 20)
		Me.dtpBirthday.TabIndex = 32
		'
		'lblUser_Id
		'
		Me.lblUser_Id.AutoSize = True
		Me.lblUser_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUser_Id.Location = New System.Drawing.Point(11, 214)
		Me.lblUser_Id.Name = "lblUser_Id"
		Me.lblUser_Id.Size = New System.Drawing.Size(69, 15)
		Me.lblUser_Id.TabIndex = 33
		Me.lblUser_Id.Text = "User_ID*:"
		'
		'tbUser_ID
		'
		Me.tbUser_ID.Location = New System.Drawing.Point(125, 213)
		Me.tbUser_ID.Name = "tbUser_ID"
		Me.tbUser_ID.Size = New System.Drawing.Size(142, 20)
		Me.tbUser_ID.TabIndex = 34
		'
		'gbGender
		'
		Me.gbGender.Controls.Add(Me.rbFrau)
		Me.gbGender.Controls.Add(Me.rbMann)
		Me.gbGender.Location = New System.Drawing.Point(109, 3)
		Me.gbGender.Name = "gbGender"
		Me.gbGender.Size = New System.Drawing.Size(112, 33)
		Me.gbGender.TabIndex = 35
		Me.gbGender.TabStop = False
		Me.gbGender.Text = "Geschlecht"
		'
		'gbSicherheitsInfo
		'
		Me.gbSicherheitsInfo.Controls.Add(Me.lblQuestion1)
		Me.gbSicherheitsInfo.Controls.Add(Me.tbAnswer3)
		Me.gbSicherheitsInfo.Controls.Add(Me.tbAnswer2)
		Me.gbSicherheitsInfo.Controls.Add(Me.tbAnswer1)
		Me.gbSicherheitsInfo.Controls.Add(Me.cbQuestion3)
		Me.gbSicherheitsInfo.Controls.Add(Me.cbQuestion2)
		Me.gbSicherheitsInfo.Controls.Add(Me.cbQuestion1)
		Me.gbSicherheitsInfo.Controls.Add(Me.lblAnswer3)
		Me.gbSicherheitsInfo.Controls.Add(Me.lblQuestion2)
		Me.gbSicherheitsInfo.Controls.Add(Me.lblAnswer2)
		Me.gbSicherheitsInfo.Controls.Add(Me.lblQuestion3)
		Me.gbSicherheitsInfo.Controls.Add(Me.lblAnswer1)
		Me.gbSicherheitsInfo.Location = New System.Drawing.Point(17, 353)
		Me.gbSicherheitsInfo.Name = "gbSicherheitsInfo"
		Me.gbSicherheitsInfo.Size = New System.Drawing.Size(523, 187)
		Me.gbSicherheitsInfo.TabIndex = 36
		Me.gbSicherheitsInfo.TabStop = False
		Me.gbSicherheitsInfo.Text = "SicherheitsInfo"
		'
		'lblQuestion1
		'
		Me.lblQuestion1.AutoSize = True
		Me.lblQuestion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQuestion1.Location = New System.Drawing.Point(18, 16)
		Me.lblQuestion1.Name = "lblQuestion1"
		Me.lblQuestion1.Size = New System.Drawing.Size(64, 15)
		Me.lblQuestion1.TabIndex = 44
		Me.lblQuestion1.Text = "Frage1#:"
		'
		'tbAnswer3
		'
		Me.tbAnswer3.Location = New System.Drawing.Point(95, 154)
		Me.tbAnswer3.Name = "tbAnswer3"
		Me.tbAnswer3.Size = New System.Drawing.Size(414, 20)
		Me.tbAnswer3.TabIndex = 43
		'
		'tbAnswer2
		'
		Me.tbAnswer2.Location = New System.Drawing.Point(95, 92)
		Me.tbAnswer2.Name = "tbAnswer2"
		Me.tbAnswer2.Size = New System.Drawing.Size(414, 20)
		Me.tbAnswer2.TabIndex = 42
		'
		'tbAnswer1
		'
		Me.tbAnswer1.Location = New System.Drawing.Point(95, 39)
		Me.tbAnswer1.Name = "tbAnswer1"
		Me.tbAnswer1.Size = New System.Drawing.Size(414, 20)
		Me.tbAnswer1.TabIndex = 41
		'
		'cbQuestion3
		'
		Me.cbQuestion3.FormattingEnabled = True
		Me.cbQuestion3.Items.AddRange(New Object() {"In what city did you meet your spouse", " In what city or town did your father or Mother meet ", " In what city or town was your first job ", " what is the name of your favorite childhood friend", " what is the name of your first grade teacher ", " what is your favorite color", " what is your mothers'maider name", " what street did you grow up on ", " what was the make of your first car "})
		Me.cbQuestion3.Location = New System.Drawing.Point(95, 127)
		Me.cbQuestion3.Name = "cbQuestion3"
		Me.cbQuestion3.Size = New System.Drawing.Size(414, 21)
		Me.cbQuestion3.TabIndex = 40
		'
		'cbQuestion2
		'
		Me.cbQuestion2.FormattingEnabled = True
		Me.cbQuestion2.Items.AddRange(New Object() {"In what city did you meet your spouse", " In what city or town did your father or Mother meet ", " In what city or town was your first job ", " what is the name of your favorite childhood friend", " what is the name of your first grade teacher ", " what is your favorite color", " what is your mothers'maider name", " what street did you grow up on ", " what was the make of your first car "})
		Me.cbQuestion2.Location = New System.Drawing.Point(95, 65)
		Me.cbQuestion2.Name = "cbQuestion2"
		Me.cbQuestion2.Size = New System.Drawing.Size(414, 21)
		Me.cbQuestion2.TabIndex = 39
		'
		'cbQuestion1
		'
		Me.cbQuestion1.FormattingEnabled = True
		Me.cbQuestion1.Items.AddRange(New Object() {"In what city did you meet your spouse", " In what city or town did your father or Mother meet ", " In what city or town was your first job ", " what is the name of your favorite childhood friend", " what is the name of your first grade teacher ", " what is your favorite color", " what is your mothers'maider name", " what street did you grow up on ", " what was the make of your first car "})
		Me.cbQuestion1.Location = New System.Drawing.Point(95, 13)
		Me.cbQuestion1.Name = "cbQuestion1"
		Me.cbQuestion1.Size = New System.Drawing.Size(414, 21)
		Me.cbQuestion1.TabIndex = 38
		'
		'lblAnswer3
		'
		Me.lblAnswer3.AutoSize = True
		Me.lblAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAnswer3.Location = New System.Drawing.Point(16, 154)
		Me.lblAnswer3.Name = "lblAnswer3"
		Me.lblAnswer3.Size = New System.Drawing.Size(58, 15)
		Me.lblAnswer3.TabIndex = 37
		Me.lblAnswer3.Text = "Antwort:"
		'
		'lblQuestion2
		'
		Me.lblQuestion2.AutoSize = True
		Me.lblQuestion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQuestion2.Location = New System.Drawing.Point(16, 65)
		Me.lblQuestion2.Name = "lblQuestion2"
		Me.lblQuestion2.Size = New System.Drawing.Size(64, 15)
		Me.lblQuestion2.TabIndex = 4
		Me.lblQuestion2.Text = "Frage2#:"
		'
		'lblAnswer2
		'
		Me.lblAnswer2.AutoSize = True
		Me.lblAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAnswer2.Location = New System.Drawing.Point(18, 92)
		Me.lblAnswer2.Name = "lblAnswer2"
		Me.lblAnswer2.Size = New System.Drawing.Size(62, 15)
		Me.lblAnswer2.TabIndex = 3
		Me.lblAnswer2.Text = " Antwort:"
		'
		'lblQuestion3
		'
		Me.lblQuestion3.AutoSize = True
		Me.lblQuestion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQuestion3.Location = New System.Drawing.Point(18, 127)
		Me.lblQuestion3.Name = "lblQuestion3"
		Me.lblQuestion3.Size = New System.Drawing.Size(64, 15)
		Me.lblQuestion3.TabIndex = 2
		Me.lblQuestion3.Text = "Frage3#:"
		'
		'lblAnswer1
		'
		Me.lblAnswer1.AutoSize = True
		Me.lblAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAnswer1.Location = New System.Drawing.Point(22, 39)
		Me.lblAnswer1.Name = "lblAnswer1"
		Me.lblAnswer1.Size = New System.Drawing.Size(58, 15)
		Me.lblAnswer1.TabIndex = 0
		Me.lblAnswer1.Text = "Antwort:"
		'
		'cbShowPassword
		'
		Me.cbShowPassword.AutoSize = True
		Me.cbShowPassword.Location = New System.Drawing.Point(125, 330)
		Me.cbShowPassword.Name = "cbShowPassword"
		Me.cbShowPassword.Size = New System.Drawing.Size(115, 17)
		Me.cbShowPassword.TabIndex = 37
		Me.cbShowPassword.Text = "Passwort anzeigen"
		Me.cbShowPassword.UseVisualStyleBackColor = True
		'
		'pnlUserRegistration
		'
		Me.pnlUserRegistration.Location = New System.Drawing.Point(3, 0)
		Me.pnlUserRegistration.Name = "pnlUserRegistration"
		Me.pnlUserRegistration.Size = New System.Drawing.Size(580, 584)
		Me.pnlUserRegistration.TabIndex = 38
		'
		'ucRegistrationInGenerator
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.cbShowPassword)
		Me.Controls.Add(Me.gbSicherheitsInfo)
		Me.Controls.Add(Me.gbGender)
		Me.Controls.Add(Me.tbUser_ID)
		Me.Controls.Add(Me.lblUser_Id)
		Me.Controls.Add(Me.dtpBirthday)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.tbConfirm)
		Me.Controls.Add(Me.tbUsername)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.tbPassword)
		Me.Controls.Add(Me.lblBenutzername)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.LblCallNumber)
		Me.Controls.Add(Me.tbTelephon)
		Me.Controls.Add(Me.tbEmail)
		Me.Controls.Add(Me.lblEmail)
		Me.Controls.Add(Me.lblCity)
		Me.Controls.Add(Me.tbCity)
		Me.Controls.Add(Me.tbPlz)
		Me.Controls.Add(Me.lblPlz)
		Me.Controls.Add(Me.tbFirstName)
		Me.Controls.Add(Me.lblNr)
		Me.Controls.Add(Me.tbNr)
		Me.Controls.Add(Me.lblNachname)
		Me.Controls.Add(Me.tbStreet)
		Me.Controls.Add(Me.lblBirthday)
		Me.Controls.Add(Me.lblstrace)
		Me.Controls.Add(Me.tbLastName)
		Me.Controls.Add(Me.lblVorname)
		Me.Controls.Add(Me.pnlUserRegistration)
		Me.Name = "ucRegistrationInGenerator"
		Me.Size = New System.Drawing.Size(586, 584)
		Me.gbGender.ResumeLayout(False)
		Me.gbGender.PerformLayout()
		Me.gbSicherheitsInfo.ResumeLayout(False)
		Me.gbSicherheitsInfo.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblNachname As Label
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblPlz As Label
    Friend WithEvents lblstrace As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbStreet As TextBox
    Friend WithEvents lblNr As Label
    Friend WithEvents tbNr As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbPlz As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbTelephon As TextBox
    Friend WithEvents LblCallNumber As Label
    Friend WithEvents rbMann As RadioButton
    Friend WithEvents rbFrau As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbConfirm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents lblUser_Id As Label
    Friend WithEvents tbUser_ID As TextBox
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents gbSicherheitsInfo As GroupBox
    Friend WithEvents tbAnswer3 As TextBox
    Friend WithEvents tbAnswer2 As TextBox
    Friend WithEvents tbAnswer1 As TextBox
    Friend WithEvents cbQuestion3 As ComboBox
    Friend WithEvents cbQuestion2 As ComboBox
    Friend WithEvents cbQuestion1 As ComboBox
    Friend WithEvents lblAnswer3 As Label
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents lblAnswer2 As Label
    Friend WithEvents lblQuestion3 As Label
    Friend WithEvents lblAnswer1 As Label
    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents cbShowPassword As CheckBox
    Friend WithEvents pnlUserRegistration As Panel

    Public strNachname As String
    Public strVorname As String
    Public strGebursttag As String
    Public strTelefon As String
    Public strGeschlechte As String
    Public strId_User As String
    Public strEmail As String
    Public strBenutzername As String
    Public strPassword As String
End Class
