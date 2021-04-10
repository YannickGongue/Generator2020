<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucLoginInGenerator
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucLoginInGenerator))
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.tbPassword = New System.Windows.Forms.TextBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.cbShowPassword = New System.Windows.Forms.CheckBox()
		Me.tbUsername = New System.Windows.Forms.TextBox()
		Me.llblNewBenutzer = New System.Windows.Forms.LinkLabel()
		Me.llblPasswordForgotten = New System.Windows.Forms.LinkLabel()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.pnlPasswordReset = New System.Windows.Forms.Panel()
		Me.pnlUserLogin = New System.Windows.Forms.Panel()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassword.Location = New System.Drawing.Point(232, 49)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(104, 15)
		Me.lblPassword.TabIndex = 3
		Me.lblPassword.Text = "Benutzername:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(232, 87)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 15)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Passwort:"
		'
		'btnLogin
		'
		Me.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLogin.Location = New System.Drawing.Point(506, 40)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(84, 29)
		Me.btnLogin.TabIndex = 7
		Me.btnLogin.Text = "Anmelden"
		Me.btnLogin.UseVisualStyleBackColor = False
		'
		'tbPassword
		'
		Me.tbPassword.Location = New System.Drawing.Point(342, 87)
		Me.tbPassword.Name = "tbPassword"
		Me.tbPassword.Size = New System.Drawing.Size(130, 20)
		Me.tbPassword.TabIndex = 8
		'
		'btnCancel
		'
		Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(506, 80)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(84, 30)
		Me.btnCancel.TabIndex = 9
		Me.btnCancel.Text = "Abbrechen"
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'cbShowPassword
		'
		Me.cbShowPassword.AutoSize = True
		Me.cbShowPassword.Location = New System.Drawing.Point(235, 126)
		Me.cbShowPassword.Name = "cbShowPassword"
		Me.cbShowPassword.Size = New System.Drawing.Size(115, 17)
		Me.cbShowPassword.TabIndex = 10
		Me.cbShowPassword.Text = "Passwort anzeigen"
		Me.cbShowPassword.UseVisualStyleBackColor = True
		'
		'tbUsername
		'
		Me.tbUsername.Location = New System.Drawing.Point(342, 48)
		Me.tbUsername.Name = "tbUsername"
		Me.tbUsername.Size = New System.Drawing.Size(130, 20)
		Me.tbUsername.TabIndex = 13
		'
		'llblNewBenutzer
		'
		Me.llblNewBenutzer.AutoSize = True
		Me.llblNewBenutzer.Location = New System.Drawing.Point(277, 186)
		Me.llblNewBenutzer.Name = "llblNewBenutzer"
		Me.llblNewBenutzer.Size = New System.Drawing.Size(132, 13)
		Me.llblNewBenutzer.TabIndex = 14
		Me.llblNewBenutzer.TabStop = True
		Me.llblNewBenutzer.Text = "Neue Benutzer registrieren"
		'
		'llblPasswordForgotten
		'
		Me.llblPasswordForgotten.AutoSize = True
		Me.llblPasswordForgotten.Location = New System.Drawing.Point(503, 186)
		Me.llblPasswordForgotten.Name = "llblPasswordForgotten"
		Me.llblPasswordForgotten.Size = New System.Drawing.Size(102, 13)
		Me.llblPasswordForgotten.TabIndex = 15
		Me.llblPasswordForgotten.TabStop = True
		Me.llblPasswordForgotten.Text = "Passwort vergessen"
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(17, 3)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(200, 230)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 5
		Me.PictureBox2.TabStop = False
		'
		'pnlPasswordReset
		'
		Me.pnlPasswordReset.BackColor = System.Drawing.SystemColors.ControlLight
		Me.pnlPasswordReset.Location = New System.Drawing.Point(152, 239)
		Me.pnlPasswordReset.Name = "pnlPasswordReset"
		Me.pnlPasswordReset.Size = New System.Drawing.Size(502, 376)
		Me.pnlPasswordReset.TabIndex = 16
		'
		'pnlUserLogin
		'
		Me.pnlUserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlUserLogin.Location = New System.Drawing.Point(3, 0)
		Me.pnlUserLogin.Name = "pnlUserLogin"
		Me.pnlUserLogin.Size = New System.Drawing.Size(720, 626)
		Me.pnlUserLogin.TabIndex = 17
		'
		'ucLoginInGenerator
		'
		Me.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Controls.Add(Me.pnlPasswordReset)
		Me.Controls.Add(Me.llblPasswordForgotten)
		Me.Controls.Add(Me.llblNewBenutzer)
		Me.Controls.Add(Me.tbUsername)
		Me.Controls.Add(Me.cbShowPassword)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.tbPassword)
		Me.Controls.Add(Me.btnLogin)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.lblPassword)
		Me.Controls.Add(Me.pnlUserLogin)
		Me.Name = "ucLoginInGenerator"
		Me.Size = New System.Drawing.Size(723, 629)
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblPasswort As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbShowPassword As CheckBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents llblNewBenutzer As LinkLabel
    Friend WithEvents llblPasswordForgotten As LinkLabel
    Friend WithEvents pnlPasswordReset As Panel
    Friend WithEvents pnlUserLogin As Panel
End Class
