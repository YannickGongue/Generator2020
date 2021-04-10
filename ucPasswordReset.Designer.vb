<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucPasswordReset
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
		Me.lblUser_Id = New System.Windows.Forms.Label()
		Me.tbSearch = New System.Windows.Forms.TextBox()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.pnlSecurityQuestion = New System.Windows.Forms.Panel()
		Me.btnResetPassword = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblUser_Id
		'
		Me.lblUser_Id.AutoSize = True
		Me.lblUser_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUser_Id.Location = New System.Drawing.Point(19, 38)
		Me.lblUser_Id.Name = "lblUser_Id"
		Me.lblUser_Id.Size = New System.Drawing.Size(63, 15)
		Me.lblUser_Id.TabIndex = 1
		Me.lblUser_Id.Text = "User_ID:"
		'
		'tbSearch
		'
		Me.tbSearch.Location = New System.Drawing.Point(88, 33)
		Me.tbSearch.Name = "tbSearch"
		Me.tbSearch.Size = New System.Drawing.Size(214, 20)
		Me.tbSearch.TabIndex = 2
		'
		'btnSearch
		'
		Me.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearch.Location = New System.Drawing.Point(327, 17)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(92, 36)
		Me.btnSearch.TabIndex = 3
		Me.btnSearch.Text = "Suchen"
		Me.btnSearch.UseVisualStyleBackColor = False
		'
		'pnlSecurityQuestion
		'
		Me.pnlSecurityQuestion.Location = New System.Drawing.Point(22, 75)
		Me.pnlSecurityQuestion.Name = "pnlSecurityQuestion"
		Me.pnlSecurityQuestion.Size = New System.Drawing.Size(397, 217)
		Me.pnlSecurityQuestion.TabIndex = 4
		'
		'btnResetPassword
		'
		Me.btnResetPassword.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnResetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnResetPassword.Location = New System.Drawing.Point(301, 298)
		Me.btnResetPassword.Name = "btnResetPassword"
		Me.btnResetPassword.Size = New System.Drawing.Size(118, 43)
		Me.btnResetPassword.TabIndex = 6
		Me.btnResetPassword.Text = "Reset Passwort"
		Me.btnResetPassword.UseVisualStyleBackColor = False
		'
		'btnCancel
		'
		Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(163, 298)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(101, 43)
		Me.btnCancel.TabIndex = 7
		Me.btnCancel.Text = "Abbrechen"
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'ucPasswordReset
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnResetPassword)
		Me.Controls.Add(Me.pnlSecurityQuestion)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.tbSearch)
		Me.Controls.Add(Me.lblUser_Id)
		Me.Name = "ucPasswordReset"
		Me.Size = New System.Drawing.Size(465, 347)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblUser_Id As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents pnlSecurityQuestion As Panel
    Friend WithEvents btnResetPassword As Button
	Friend WithEvents btnCancel As Button
End Class
