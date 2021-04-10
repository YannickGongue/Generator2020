Imports GeneratorControlLibrary
Imports GeneratorClassLibrary
Imports System.Windows.Forms


Public Class frmGenerator

   Sub New()

      ' Dieser Aufruf ist für den Designer erforderlich.
      InitializeComponent()

      ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
      IsMdiContainer = True

      pnlUserControl.Visible = False
      pbFacebook.Visible = True
      pbTweeter.Visible = True
      pbWatsap.Visible = True

   End Sub

   ''' <summary>
   '''    Durch dieser Ereignis kann  der Benutzer sich registrieren.
   ''' </summary>
   ''' <remarks> dieser Ereignis wird durchgeführt,wenn der Button Anmelden des ToolStripMenu betätigt wird </remarks>
   Private Sub AnmeldenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmLogin.Click
      ' LOKALEN OBJEKTVARIABLEN DEKLARIEREN: 
      Dim ucligLogin As ucLoginInGenerator      ' Benutzersteuertelement zur Anmeldung im Generator.

      ' Steuerelement instanzieren.
      ucligLogin = New ucLoginInGenerator()

      pnlUserControl.Visible = True
      ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
      Call clsUserControl.ShowUserControl(ucligLogin, pnlUserControl)

   End Sub

   ''' <summary>
   '''   Durch dieser Ereignis kann  der Benutzer sich registrieren.
   ''' </summary>
   ''' <remarks> dieser Ereignis wird durchgeführt,wenn der Button registrieren des ToolStripMenu betätigt wird </remarks>
   Private Sub RegistrierungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmRegister.Click
      ' LOKALEN OBJEKTVARIABLEN DEKLARIEREN:
      Dim ucrigRegister As ucRegistrationInGenerator     ' Benutzersteuerelement zur Registrierung des Users.

      ' Steuerelement instanzieren.
      ucrigRegister = New ucRegistrationInGenerator()
      pnlUserControl.Visible = True
      ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
      Call clsUserControl.ShowUserControl(ucrigRegister, pnlUserControl)

   End Sub

   ''' <summary>
   '''   Durch dieser Ereignis wird die Informationen des users angezeigt.
   ''' </summary>
   '''<remarks> Diese Ereignis wird durchgeführt, wenn der MenuItem ProfilToolstrip wird betätigt </remarks>
   Private Sub ProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmProfil.Click
      ' LOKALEN OBJEKTVARIABLEN DEKLARIEREN:
      Dim ucProfil As ucUserProfil     ' Benutzersteuerelement zum Anzeigen des Profils des Users.

      ' Steuerelement instanzieren.
      ucProfil = New ucUserProfil()
      pnlUserControl.Visible = True
      pnlUserProfil.Visible = True
      ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
      Call clsUserControl.ShowUserControl(ucProfil, pnlUserProfil)

   End Sub

   ''' <summary>
   '''   Durch dieser Ereignis wird das Bericht geöffnet.
   ''' </summary>
   '''<remarks> Diese Ereignis wird durchgeführt, wenn der MenuItem tsmuiOpen wird betätigt </remarks>
   Private Sub tsmuiOpen_Click(sender As Object, e As EventArgs) Handles tsmuiOpen.Click
      ' LOKALEN OBJEKTVARIABLEN DEKLARIEREN:
      Dim frmBericht As New frmBerichtöffnen

      If ActiveChild(frmBericht) Then
         Return
      End If

      frmBericht.MdiParent = Me
      frmBericht.Dock = DockStyle.Fill
      frmBericht.Show()
      If ActiveChild(frmBericht) Then
         pnlUserControl.Visible = False
         pbFacebook.Visible = False
         pbTweeter.Visible = False
         pbWatsap.Visible = False
      End If

   End Sub

   Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuToolStripMenuItem.Click

   End Sub

   Private Sub LeerenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeerenToolStripMenuItem.Click
      ' LOKALEN OBJEKTVARIABLEN DEKLARIEREN:
      Dim frmBericht As New frmSelectionBericht

      If ActiveChild(frmBericht) Then Return
      frmBericht.MdiParent = Me
      frmBericht.Dock = DockStyle.Fill
      frmBericht.Show()

      If ActiveChild(frmBericht) Then
         pnlUserControl.Visible = False
         pbFacebook.Visible = False
         pbTweeter.Visible = False
         pbWatsap.Visible = False
      End If

   End Sub

   Private Sub tsmuiSave_Click(sender As Object, e As EventArgs) Handles tsmuiSave.Click

   End Sub

   ''' <summary>
   '''   Durch dieser Funktion wurde überprüft,ob die gleiche Form aktiv ist sonst zeigt nichts.
   ''' </summary>
   ''' <param name="Form"> ist die aktive Form</param>
   ''' <returns>True oder False</returns>
   Private Function ActiveChild(ByVal Form As Form) As Boolean
      If ActiveMdiChild IsNot Nothing Then
         With ActiveMdiChild.Name
            If .Equals(Form.Name) Then
               Return True
            End If
         End With
      End If
      Return False
   End Function

End Class