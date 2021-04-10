Imports GeneratorControlLibrary
Imports GeneratorClassLibrary
Public Class frmSelectionBericht

   Sub New()
      ' LOKALEN OBJEKTVARIABLEN DEKLARIEREN: 
      Dim ucÜbersicht As ucOverView      ' Benutzersteuertelement zur Anmeldung im Generator.
      ' Dieser Aufruf ist für den Designer erforderlich.
      InitializeComponent()

      ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
      ' IsMdiContainer = True
      Call GeneratorClassLibrary.clsTreeViewManager.CreateTreeView(tvNavigation)
      tvNavigation.ExpandAll()
      'tvNavigation.Enabled = False

      ucÜbersicht = New ucOverView
      pnlControl.Visible = True
      ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
      Call clsUserControl.ShowUserControl(ucÜbersicht, pnlControl)

   End Sub

   Private Sub tvNavigation_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvNavigation.AfterSelect
      ' LOKALEN OBJEKTVARIABLEN DEKLARIEREN:
      Dim strIdAndType() As String

      strIdAndType = Split(e.Node.Name, clsConstant.STR_TREEVIEW_KEY_DELIMETER)

      OpenUserControl(strIdAndType(0), strIdAndType(1))

   End Sub

   Private Sub tvNavigation_BeforeSelect(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles tvNavigation.BeforeSelect
      ' LOKALEN OBJEKTVARIABLEN DEKLARIEREN:

   End Sub


   Public Sub OpenUserControl(ByVal strUserControlName As String, ByVal strUserControlType As String)
      ' LOKALEN OBJEKTVARIABLEN DEKLARIEREN:
      Dim ucÜbersicht As ucOverView
      Dim ucExplorer As ucDbExplorer
      Dim ucContents As ucContent
      Dim ucGenerals As ucGeneral
      Dim ucPod As ucPOD
      Dim ucTr As ucTR


      If Me.pnlControl.Controls(strUserControlName) Is Nothing Then

         Select Case strUserControlType
            Case "ucContent"
               ucContents = New ucContent
               Call clsUserControl.ShowUserControl(ucContents, pnlControl)
            Case "ucDbExplorer"
               ucExplorer = New ucDbExplorer
               ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
               Call clsUserControl.ShowUserControl(ucExplorer, pnlControl)
            Case "ucGeneral"
               ucGenerals = New ucGeneral
               ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
               Call clsUserControl.ShowUserControl(ucGenerals, pnlControl)
            Case "ucOverView"
               ucÜbersicht = New ucOverView
               ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
               Call clsUserControl.ShowUserControl(ucÜbersicht, pnlControl)
            Case "ucPOD"
               ucPod = New ucPOD
               Call clsUserControl.ShowUserControl(ucPod, pnlControl)
            Case "ucTR"
               ucTr = New ucTR
               Call clsUserControl.ShowUserControl(ucTr, pnlControl)
            Case Else
               MessageBox.Show("")
               Exit Sub
         End Select
         Me.pnlControl.Controls(strUserControlType).Dock = DockStyle.Fill
         Me.pnlControl.Controls(strUserControlType).Name = strUserControlName
      Else
         Me.pnlControl.Controls(strUserControlName).Visible = True
      End If





   End Sub


End Class