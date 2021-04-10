<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUserProfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucUserProfil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.tbFirstname = New System.Windows.Forms.TextBox()
        Me.tsUserProfil = New System.Windows.Forms.ToolStrip()
        Me.tsbUpdateProfile = New System.Windows.Forms.ToolStripButton()
        Me.tsbDeleteProfil = New System.Windows.Forms.ToolStripButton()
        Me.tstSearchProfile = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbSearch = New System.Windows.Forms.ToolStripButton()
        Me.tbLastname = New System.Windows.Forms.TextBox()
        Me.tbTelefon = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbUserId = New System.Windows.Forms.TextBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tbFax = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbNutzer = New System.Windows.Forms.GroupBox()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.lblDomain = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.tsUserProfil.SuspendLayout()
        Me.gbNutzer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nachname:"
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVorname.Location = New System.Drawing.Point(16, 74)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(68, 15)
        Me.lblVorname.TabIndex = 1
        Me.lblVorname.Text = "Vorname:"
        '
        'tbFirstname
        '
        Me.tbFirstname.Location = New System.Drawing.Point(100, 41)
        Me.tbFirstname.Name = "tbFirstname"
        Me.tbFirstname.Size = New System.Drawing.Size(186, 20)
        Me.tbFirstname.TabIndex = 2
        '
        'tsUserProfil
        '
        Me.tsUserProfil.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tsUserProfil.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbUpdateProfile, Me.tsbDeleteProfil, Me.tstSearchProfile, Me.tsbSearch})
        Me.tsUserProfil.Location = New System.Drawing.Point(0, 0)
        Me.tsUserProfil.Name = "tsUserProfil"
        Me.tsUserProfil.Size = New System.Drawing.Size(295, 25)
        Me.tsUserProfil.TabIndex = 3
        Me.tsUserProfil.Text = "ToolStrip1"
        '
        'tsbUpdateProfile
        '
        Me.tsbUpdateProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbUpdateProfile.Image = CType(resources.GetObject("tsbUpdateProfile.Image"), System.Drawing.Image)
        Me.tsbUpdateProfile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpdateProfile.Name = "tsbUpdateProfile"
        Me.tsbUpdateProfile.Size = New System.Drawing.Size(23, 22)
        Me.tsbUpdateProfile.Text = "ToolStripButton2"
        '
        'tsbDeleteProfil
        '
        Me.tsbDeleteProfil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDeleteProfil.Image = CType(resources.GetObject("tsbDeleteProfil.Image"), System.Drawing.Image)
        Me.tsbDeleteProfil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeleteProfil.Name = "tsbDeleteProfil"
        Me.tsbDeleteProfil.Size = New System.Drawing.Size(23, 22)
        Me.tsbDeleteProfil.Text = "ToolStripButton3"
        '
        'tstSearchProfile
        '
        Me.tstSearchProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstSearchProfile.Name = "tstSearchProfile"
        Me.tstSearchProfile.Size = New System.Drawing.Size(100, 25)
        '
        'tsbSearch
        '
        Me.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSearch.Image = CType(resources.GetObject("tsbSearch.Image"), System.Drawing.Image)
        Me.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSearch.Name = "tsbSearch"
        Me.tsbSearch.Size = New System.Drawing.Size(23, 22)
        Me.tsbSearch.Text = "ToolStripButton1"
        '
        'tbLastname
        '
        Me.tbLastname.Location = New System.Drawing.Point(100, 71)
        Me.tbLastname.Name = "tbLastname"
        Me.tbLastname.Size = New System.Drawing.Size(186, 20)
        Me.tbLastname.TabIndex = 4
        '
        'tbTelefon
        '
        Me.tbTelefon.Location = New System.Drawing.Point(97, 120)
        Me.tbTelefon.Name = "tbTelefon"
        Me.tbTelefon.Size = New System.Drawing.Size(186, 20)
        Me.tbTelefon.TabIndex = 5
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(97, 146)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(186, 20)
        Me.tbEmail.TabIndex = 6
        '
        'tbUserId
        '
        Me.tbUserId.Location = New System.Drawing.Point(100, 96)
        Me.tbUserId.Name = "tbUserId"
        Me.tbUserId.Size = New System.Drawing.Size(186, 20)
        Me.tbUserId.TabIndex = 7
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.Location = New System.Drawing.Point(27, 172)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(34, 15)
        Me.lblFax.TabIndex = 8
        Me.lblFax.Text = "Fax:"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.Location = New System.Drawing.Point(16, 96)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(61, 15)
        Me.lblUserId.TabIndex = 9
        Me.lblUserId.Text = "User_Id:"
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefon.Location = New System.Drawing.Point(13, 120)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(59, 15)
        Me.lblTelefon.TabIndex = 10
        Me.lblTelefon.Text = "Telefon:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(13, 146)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 15)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email:"
        '
        'tbFax
        '
        Me.tbFax.Location = New System.Drawing.Point(97, 172)
        Me.tbFax.Name = "tbFax"
        Me.tbFax.Size = New System.Drawing.Size(186, 20)
        Me.tbFax.TabIndex = 12
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(181, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 36)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "  Abbrechen"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'gbNutzer
        '
        Me.gbNutzer.Controls.Add(Me.lstData)
        Me.gbNutzer.Controls.Add(Me.lblDomain)
        Me.gbNutzer.Controls.Add(Me.TextBox1)
        Me.gbNutzer.Controls.Add(Me.ComboBox1)
        Me.gbNutzer.Controls.Add(Me.Label2)
        Me.gbNutzer.Controls.Add(Me.tbFax)
        Me.gbNutzer.Controls.Add(Me.tbEmail)
        Me.gbNutzer.Controls.Add(Me.lblTelefon)
        Me.gbNutzer.Controls.Add(Me.lblEmail)
        Me.gbNutzer.Controls.Add(Me.lblFax)
        Me.gbNutzer.Controls.Add(Me.tbTelefon)
        Me.gbNutzer.Location = New System.Drawing.Point(3, 28)
        Me.gbNutzer.Name = "gbNutzer"
        Me.gbNutzer.Size = New System.Drawing.Size(289, 336)
        Me.gbNutzer.TabIndex = 14
        Me.gbNutzer.TabStop = False
        Me.gbNutzer.Text = "Nutzer"
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(6, 235)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(277, 95)
        Me.lstData.TabIndex = 18
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomain.Location = New System.Drawing.Point(13, 95)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(67, 15)
        Me.lblDomain.TabIndex = 17
        Me.lblDomain.Text = "Abteilung"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(97, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 20)
        Me.TextBox1.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Deutsch DE", "Engisch EN", "French FR"})
        Me.ComboBox1.Location = New System.Drawing.Point(97, 198)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Language"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(90, 370)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 36)
        Me.btnOk.TabIndex = 16
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'ucUserProfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.tbUserId)
        Me.Controls.Add(Me.tbLastname)
        Me.Controls.Add(Me.tsUserProfil)
        Me.Controls.Add(Me.tbFirstname)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbNutzer)
        Me.Name = "ucUserProfil"
        Me.Size = New System.Drawing.Size(295, 414)
        Me.tsUserProfil.ResumeLayout(False)
        Me.tsUserProfil.PerformLayout()
        Me.gbNutzer.ResumeLayout(False)
        Me.gbNutzer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblVorname As Label
    Friend WithEvents tbFirstname As TextBox
    Friend WithEvents tsUserProfil As ToolStrip
    Friend WithEvents tsbSearch As ToolStripButton
    Friend WithEvents tsbUpdateProfile As ToolStripButton
    Friend WithEvents tsbDeleteProfil As ToolStripButton
    Friend WithEvents tstSearchProfile As ToolStripTextBox
    Friend WithEvents tbLastname As TextBox
    Friend WithEvents tbTelefon As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbUserId As TextBox
    Friend WithEvents lblFax As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents lblTelefon As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbFax As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents gbNutzer As GroupBox
    Friend WithEvents lblDomain As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents lstData As ListBox
End Class
