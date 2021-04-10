<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSecurityQuestion
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
        Me.tbAnswer1 = New System.Windows.Forms.TextBox()
        Me.cbQuestion1 = New System.Windows.Forms.ComboBox()
        Me.cbQuestion2 = New System.Windows.Forms.ComboBox()
        Me.tbAnwort2 = New System.Windows.Forms.TextBox()
        Me.tbAnswer3 = New System.Windows.Forms.TextBox()
        Me.cbQuestion3 = New System.Windows.Forms.ComboBox()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.lblAnswer1 = New System.Windows.Forms.Label()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.tbAnswer2 = New System.Windows.Forms.Label()
        Me.lblQuestion3 = New System.Windows.Forms.Label()
        Me.lblAnswer3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbAnswer1
        '
        Me.tbAnswer1.Location = New System.Drawing.Point(103, 46)
        Me.tbAnswer1.Name = "tbAnswer1"
        Me.tbAnswer1.Size = New System.Drawing.Size(260, 20)
        Me.tbAnswer1.TabIndex = 0
        '
        'cbQuestion1
        '
        Me.cbQuestion1.FormattingEnabled = True
        Me.cbQuestion1.Location = New System.Drawing.Point(103, 19)
        Me.cbQuestion1.Name = "cbQuestion1"
        Me.cbQuestion1.Size = New System.Drawing.Size(260, 21)
        Me.cbQuestion1.TabIndex = 1
        '
        'cbQuestion2
        '
        Me.cbQuestion2.FormattingEnabled = True
        Me.cbQuestion2.Location = New System.Drawing.Point(103, 83)
        Me.cbQuestion2.Name = "cbQuestion2"
        Me.cbQuestion2.Size = New System.Drawing.Size(260, 21)
        Me.cbQuestion2.TabIndex = 2
        '
        'tbAnwort2
        '
        Me.tbAnwort2.Location = New System.Drawing.Point(103, 110)
        Me.tbAnwort2.Name = "tbAnwort2"
        Me.tbAnwort2.Size = New System.Drawing.Size(260, 20)
        Me.tbAnwort2.TabIndex = 3
        '
        'tbAnswer3
        '
        Me.tbAnswer3.Location = New System.Drawing.Point(103, 171)
        Me.tbAnswer3.Name = "tbAnswer3"
        Me.tbAnswer3.Size = New System.Drawing.Size(260, 20)
        Me.tbAnswer3.TabIndex = 4
        '
        'cbQuestion3
        '
        Me.cbQuestion3.FormattingEnabled = True
        Me.cbQuestion3.Location = New System.Drawing.Point(103, 144)
        Me.cbQuestion3.Name = "cbQuestion3"
        Me.cbQuestion3.Size = New System.Drawing.Size(260, 21)
        Me.cbQuestion3.TabIndex = 5
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion1.Location = New System.Drawing.Point(33, 25)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(64, 15)
        Me.lblQuestion1.TabIndex = 6
        Me.lblQuestion1.Text = "Frage1#:"
        '
        'lblAnswer1
        '
        Me.lblAnswer1.AutoSize = True
        Me.lblAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer1.Location = New System.Drawing.Point(33, 51)
        Me.lblAnswer1.Name = "lblAnswer1"
        Me.lblAnswer1.Size = New System.Drawing.Size(58, 15)
        Me.lblAnswer1.TabIndex = 7
        Me.lblAnswer1.Text = "Antwort:"
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion2.Location = New System.Drawing.Point(27, 89)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(64, 15)
        Me.lblQuestion2.TabIndex = 8
        Me.lblQuestion2.Text = "Frage2#:"
        '
        'tbAnswer2
        '
        Me.tbAnswer2.AutoSize = True
        Me.tbAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAnswer2.Location = New System.Drawing.Point(33, 115)
        Me.tbAnswer2.Name = "tbAnswer2"
        Me.tbAnswer2.Size = New System.Drawing.Size(58, 15)
        Me.tbAnswer2.TabIndex = 9
        Me.tbAnswer2.Text = "Antwort:"
        '
        'lblQuestion3
        '
        Me.lblQuestion3.AutoSize = True
        Me.lblQuestion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion3.Location = New System.Drawing.Point(27, 150)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(64, 15)
        Me.lblQuestion3.TabIndex = 10
        Me.lblQuestion3.Text = "Frage3#:"
        '
        'lblAnswer3
        '
        Me.lblAnswer3.AutoSize = True
        Me.lblAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer3.Location = New System.Drawing.Point(27, 176)
        Me.lblAnswer3.Name = "lblAnswer3"
        Me.lblAnswer3.Size = New System.Drawing.Size(58, 15)
        Me.lblAnswer3.TabIndex = 11
        Me.lblAnswer3.Text = "Antwort:"
        '
        'ucSecurityQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblAnswer3)
        Me.Controls.Add(Me.lblQuestion3)
        Me.Controls.Add(Me.tbAnswer2)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Controls.Add(Me.lblAnswer1)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Controls.Add(Me.cbQuestion3)
        Me.Controls.Add(Me.tbAnswer3)
        Me.Controls.Add(Me.tbAnwort2)
        Me.Controls.Add(Me.cbQuestion2)
        Me.Controls.Add(Me.cbQuestion1)
        Me.Controls.Add(Me.tbAnswer1)
        Me.Name = "ucSecurityQuestion"
        Me.Size = New System.Drawing.Size(382, 210)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbAnswer1 As TextBox
    Friend WithEvents cbQuestion1 As ComboBox
    Friend WithEvents cbQuestion2 As ComboBox
    Friend WithEvents tbAnwort2 As TextBox
    Friend WithEvents tbAnswer3 As TextBox
    Friend WithEvents cbQuestion3 As ComboBox
    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents lblAnswer1 As Label
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents tbAnswer2 As Label
    Friend WithEvents lblQuestion3 As Label
    Friend WithEvents lblAnswer3 As Label
End Class
