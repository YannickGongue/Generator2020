<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSelectionBericht
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
		Me.grpNavigation = New System.Windows.Forms.GroupBox()
		Me.tvNavigation = New System.Windows.Forms.TreeView()
		Me.pnlControl = New System.Windows.Forms.Panel()
		Me.grpNavigation.SuspendLayout()
		Me.SuspendLayout()
		'
		'grpNavigation
		'
		Me.grpNavigation.Controls.Add(Me.tvNavigation)
		Me.grpNavigation.ForeColor = System.Drawing.SystemColors.HotTrack
		Me.grpNavigation.Location = New System.Drawing.Point(0, 0)
		Me.grpNavigation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.grpNavigation.Name = "grpNavigation"
		Me.grpNavigation.Size = New System.Drawing.Size(235, 576)
		Me.grpNavigation.TabIndex = 0
		Me.grpNavigation.TabStop = False
		Me.grpNavigation.Text = "Navigation"
		'
		'tvNavigation
		'
		Me.tvNavigation.CheckBoxes = True
		Me.tvNavigation.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tvNavigation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tvNavigation.Location = New System.Drawing.Point(3, 16)
		Me.tvNavigation.Name = "tvNavigation"
		Me.tvNavigation.Size = New System.Drawing.Size(229, 557)
		Me.tvNavigation.TabIndex = 0
		'
		'pnlControl
		'
		Me.pnlControl.AutoScroll = True
		Me.pnlControl.Location = New System.Drawing.Point(239, 16)
		Me.pnlControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pnlControl.Name = "pnlControl"
		Me.pnlControl.Size = New System.Drawing.Size(709, 562)
		Me.pnlControl.TabIndex = 0
		'
		'frmSelectionBericht
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLight
		Me.ClientSize = New System.Drawing.Size(953, 578)
		Me.Controls.Add(Me.grpNavigation)
		Me.Controls.Add(Me.pnlControl)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Name = "frmSelectionBericht"
		Me.Text = " Bericht"
		Me.grpNavigation.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents grpNavigation As GroupBox
	Friend WithEvents tvNavigation As TreeView
	Friend WithEvents pnlControl As Panel
End Class
