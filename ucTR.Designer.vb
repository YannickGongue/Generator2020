<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTR
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
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.grpProtokoltyp = New System.Windows.Forms.GroupBox()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.pnlProtocolTyp = New System.Windows.Forms.Panel()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.grpPrüfergebnis = New System.Windows.Forms.GroupBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Button8 = New System.Windows.Forms.Button()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.pnl = New System.Windows.Forms.Panel()
		Me.pnlAttachement = New System.Windows.Forms.Panel()
		Me.grpProtokoltyp.SuspendLayout()
		Me.pnlProtocolTyp.SuspendLayout()
		Me.grpPrüfergebnis.SuspendLayout()
		Me.SuspendLayout()
		'
		'ListView1
		'
		Me.ListView1.HideSelection = False
		Me.ListView1.Location = New System.Drawing.Point(6, 19)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(204, 133)
		Me.ListView1.TabIndex = 0
		Me.ListView1.UseCompatibleStateImageBehavior = False
		'
		'Button1
		'
		Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Button1.Location = New System.Drawing.Point(211, 19)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "hinzufügen"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Button2.Location = New System.Drawing.Point(211, 41)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 30)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Button3.Location = New System.Drawing.Point(211, 68)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 30)
		Me.Button3.TabIndex = 3
		Me.Button3.Text = "Button3"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Button4.Location = New System.Drawing.Point(211, 97)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 29)
		Me.Button4.TabIndex = 4
		Me.Button4.Text = "Button4"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'grpProtokoltyp
		'
		Me.grpProtokoltyp.Controls.Add(Me.Button5)
		Me.grpProtokoltyp.Controls.Add(Me.ListView1)
		Me.grpProtokoltyp.Controls.Add(Me.Button4)
		Me.grpProtokoltyp.Controls.Add(Me.Button1)
		Me.grpProtokoltyp.Controls.Add(Me.Button3)
		Me.grpProtokoltyp.Controls.Add(Me.Button2)
		Me.grpProtokoltyp.Location = New System.Drawing.Point(287, 3)
		Me.grpProtokoltyp.Name = "grpProtokoltyp"
		Me.grpProtokoltyp.Size = New System.Drawing.Size(288, 157)
		Me.grpProtokoltyp.TabIndex = 1
		Me.grpProtokoltyp.TabStop = False
		Me.grpProtokoltyp.Text = "Protocoltyp"
		'
		'Button5
		'
		Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Button5.Location = New System.Drawing.Point(211, 127)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(75, 25)
		Me.Button5.TabIndex = 3
		Me.Button5.Text = "Button5"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'pnlProtocolTyp
		'
		Me.pnlProtocolTyp.Controls.Add(Me.GroupBox1)
		Me.pnlProtocolTyp.Controls.Add(Me.grpProtokoltyp)
		Me.pnlProtocolTyp.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlProtocolTyp.Location = New System.Drawing.Point(0, 0)
		Me.pnlProtocolTyp.Name = "pnlProtocolTyp"
		Me.pnlProtocolTyp.Size = New System.Drawing.Size(584, 167)
		Me.pnlProtocolTyp.TabIndex = 2
		'
		'GroupBox1
		'
		Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(278, 152)
		Me.GroupBox1.TabIndex = 4
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Bemerkungen"
		'
		'grpPrüfergebnis
		'
		Me.grpPrüfergebnis.Controls.Add(Me.Label4)
		Me.grpPrüfergebnis.Controls.Add(Me.Label3)
		Me.grpPrüfergebnis.Controls.Add(Me.Label2)
		Me.grpPrüfergebnis.Controls.Add(Me.Label1)
		Me.grpPrüfergebnis.Controls.Add(Me.CheckBox1)
		Me.grpPrüfergebnis.Controls.Add(Me.Button8)
		Me.grpPrüfergebnis.Controls.Add(Me.Button7)
		Me.grpPrüfergebnis.Controls.Add(Me.Button6)
		Me.grpPrüfergebnis.Controls.Add(Me.TextBox4)
		Me.grpPrüfergebnis.Controls.Add(Me.TextBox3)
		Me.grpPrüfergebnis.Controls.Add(Me.TextBox2)
		Me.grpPrüfergebnis.Controls.Add(Me.TextBox1)
		Me.grpPrüfergebnis.Dock = System.Windows.Forms.DockStyle.Top
		Me.grpPrüfergebnis.Location = New System.Drawing.Point(0, 167)
		Me.grpPrüfergebnis.Name = "grpPrüfergebnis"
		Me.grpPrüfergebnis.Size = New System.Drawing.Size(584, 123)
		Me.grpPrüfergebnis.TabIndex = 3
		Me.grpPrüfergebnis.TabStop = False
		Me.grpPrüfergebnis.Text = "Prüfergebnis"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(15, 100)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(39, 13)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Label4"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(15, 78)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(39, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Label3"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(15, 52)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(39, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Label2"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(15, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Label1"
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(271, 22)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
		Me.CheckBox1.TabIndex = 7
		Me.CheckBox1.Text = "CheckBox1"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Button8
		'
		Me.Button8.Location = New System.Drawing.Point(480, 60)
		Me.Button8.Name = "Button8"
		Me.Button8.Size = New System.Drawing.Size(92, 57)
		Me.Button8.TabIndex = 6
		Me.Button8.Text = "Button8"
		Me.Button8.UseVisualStyleBackColor = True
		'
		'Button7
		'
		Me.Button7.Location = New System.Drawing.Point(374, 60)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(100, 57)
		Me.Button7.TabIndex = 5
		Me.Button7.Text = "Button7"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Location = New System.Drawing.Point(271, 60)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(97, 57)
		Me.Button6.TabIndex = 4
		Me.Button6.Text = "Button6"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(104, 97)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(134, 20)
		Me.TextBox4.TabIndex = 3
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(104, 45)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(70, 20)
		Me.TextBox3.TabIndex = 2
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(104, 71)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(97, 20)
		Me.TextBox2.TabIndex = 1
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(104, 19)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(21, 20)
		Me.TextBox1.TabIndex = 0
		'
		'pnl
		'
		Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnl.Location = New System.Drawing.Point(0, 290)
		Me.pnl.Name = "pnl"
		Me.pnl.Size = New System.Drawing.Size(584, 267)
		Me.pnl.TabIndex = 4
		'
		'pnlAttachement
		'
		Me.pnlAttachement.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.pnlAttachement.Location = New System.Drawing.Point(0, 444)
		Me.pnlAttachement.Name = "pnlAttachement"
		Me.pnlAttachement.Size = New System.Drawing.Size(584, 113)
		Me.pnlAttachement.TabIndex = 5
		'
		'ucTR
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.HighlightText
		Me.Controls.Add(Me.pnlAttachement)
		Me.Controls.Add(Me.pnl)
		Me.Controls.Add(Me.grpPrüfergebnis)
		Me.Controls.Add(Me.pnlProtocolTyp)
		Me.Name = "ucTR"
		Me.Size = New System.Drawing.Size(584, 557)
		Me.grpProtokoltyp.ResumeLayout(False)
		Me.pnlProtocolTyp.ResumeLayout(False)
		Me.grpPrüfergebnis.ResumeLayout(False)
		Me.grpPrüfergebnis.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents grpProtokoltyp As GroupBox
	Friend WithEvents Button5 As Button
	Friend WithEvents ListView1 As ListView
	Friend WithEvents Button4 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents pnlProtocolTyp As Panel
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents grpPrüfergebnis As GroupBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Button8 As Button
	Friend WithEvents Button7 As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents pnl As Panel
	Friend WithEvents pnlAttachement As Panel
End Class
