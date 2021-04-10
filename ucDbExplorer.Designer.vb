<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDbExplorer
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
		Me.tvDbExplorer = New System.Windows.Forms.TreeView()
		Me.lvFileReferences = New System.Windows.Forms.ListView()
		Me.SuspendLayout()
		'
		'tvDbExplorer
		'
		Me.tvDbExplorer.Location = New System.Drawing.Point(3, 3)
		Me.tvDbExplorer.Name = "tvDbExplorer"
		Me.tvDbExplorer.Size = New System.Drawing.Size(187, 489)
		Me.tvDbExplorer.TabIndex = 1
		'
		'lvFileReferences
		'
		Me.lvFileReferences.HideSelection = False
		Me.lvFileReferences.Location = New System.Drawing.Point(196, 3)
		Me.lvFileReferences.Name = "lvFileReferences"
		Me.lvFileReferences.Size = New System.Drawing.Size(370, 489)
		Me.lvFileReferences.TabIndex = 2
		Me.lvFileReferences.UseCompatibleStateImageBehavior = False
		'
		'ucDbExplorer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.lvFileReferences)
		Me.Controls.Add(Me.tvDbExplorer)
		Me.Name = "ucDbExplorer"
		Me.Size = New System.Drawing.Size(569, 495)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tvDbExplorer As TreeView
	Friend WithEvents lvFileReferences As ListView
End Class
