<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNewPassword
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
		Me.tbNewPassword = New System.Windows.Forms.TextBox()
		Me.tbPasswordConfirm = New System.Windows.Forms.TextBox()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.lblConfirm = New System.Windows.Forms.Label()
		Me.lblNewPassword = New System.Windows.Forms.Label()
		Me.tbNewUsername = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cbShowNewPasword = New System.Windows.Forms.CheckBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'tbNewPassword
		'
		Me.tbNewPassword.Location = New System.Drawing.Point(161, 58)
		Me.tbNewPassword.Name = "tbNewPassword"
		Me.tbNewPassword.Size = New System.Drawing.Size(188, 20)
		Me.tbNewPassword.TabIndex = 0
		'
		'tbPasswordConfirm
		'
		Me.tbPasswordConfirm.Location = New System.Drawing.Point(161, 84)
		Me.tbPasswordConfirm.Name = "tbPasswordConfirm"
		Me.tbPasswordConfirm.Size = New System.Drawing.Size(188, 20)
		Me.tbPasswordConfirm.TabIndex = 1
		'
		'btnOk
		'
		Me.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOk.Location = New System.Drawing.Point(274, 130)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 38)
		Me.btnOk.TabIndex = 3
		Me.btnOk.Text = "Ok"
		Me.btnOk.UseVisualStyleBackColor = False
		'
		'lblConfirm
		'
		Me.lblConfirm.AutoSize = True
		Me.lblConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfirm.Location = New System.Drawing.Point(6, 89)
		Me.lblConfirm.Name = "lblConfirm"
		Me.lblConfirm.Size = New System.Drawing.Size(87, 15)
		Me.lblConfirm.TabIndex = 4
		Me.lblConfirm.Text = "Bestätigung:"
		'
		'lblNewPassword
		'
		Me.lblNewPassword.AutoSize = True
		Me.lblNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewPassword.Location = New System.Drawing.Point(6, 63)
		Me.lblNewPassword.Name = "lblNewPassword"
		Me.lblNewPassword.Size = New System.Drawing.Size(107, 15)
		Me.lblNewPassword.TabIndex = 5
		Me.lblNewPassword.Text = "Neue Passwort:"
		'
		'tbNewUsername
		'
		Me.tbNewUsername.Location = New System.Drawing.Point(161, 23)
		Me.tbNewUsername.Name = "tbNewUsername"
		Me.tbNewUsername.Size = New System.Drawing.Size(188, 20)
		Me.tbNewUsername.TabIndex = 6
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(0, 13)
		Me.Label1.TabIndex = 7
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(1, 23)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(142, 15)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Neue Benutzername:"
		'
		'cbShowNewPasword
		'
		Me.cbShowNewPasword.AutoSize = True
		Me.cbShowNewPasword.Location = New System.Drawing.Point(161, 110)
		Me.cbShowNewPasword.Name = "cbShowNewPasword"
		Me.cbShowNewPasword.Size = New System.Drawing.Size(15, 14)
		Me.cbShowNewPasword.TabIndex = 9
		Me.cbShowNewPasword.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(173, 130)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(86, 38)
		Me.btnCancel.TabIndex = 10
		Me.btnCancel.Text = "Abbrechen"
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'ucNewPassword
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.cbShowNewPasword)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.tbNewUsername)
		Me.Controls.Add(Me.lblNewPassword)
		Me.Controls.Add(Me.lblConfirm)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.tbPasswordConfirm)
		Me.Controls.Add(Me.tbNewPassword)
		Me.Name = "ucNewPassword"
		Me.Size = New System.Drawing.Size(363, 174)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tbNewPassword As TextBox
    Friend WithEvents tbPasswordConfirm As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents lblConfirm As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents tbNewUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbShowNewPasword As CheckBox
	Friend WithEvents btnCancel As Button
End Class
