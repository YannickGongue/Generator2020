Imports System.Data.SqlClient
Imports GeneratorClassLibrary.clsConstant
Imports System.Windows.Forms

Public Class ucLoginInGenerator


   Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
      'Dim strUsername As String
      'Dim strPassword As String
      Dim frmGenerator As frmRechnungBericht

      'strUsername = tbUsername.Text
      'strPassword = tbPassword.Text


      ' wird die Datensätzen eingefügt?
      If FillTable().Rows.Count = 1 Then
         MessageBox.Show(My.Resources.Resource.strUserLogin)
         frmGenerator = New frmRechnungBericht
         frmGenerator.Show()
      Else
         MessageBox.Show(My.Resources.Resource.strLoginfalse)
      End If

      ' Textfeldern leeren
      tbUsername.Text = ""
      tbPassword.Text = ""

   End Sub

   ''' <summary>
   '''   Durch dieser Ereignis wird die Application beendet
   ''' </summary>
   ''' <remarks> Diese Ereignis wird durchgeführt, wenn die Button BtnCancel betätigt wird</remarks>
   Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
      Me.Visible = False
   End Sub

   ''' <summary>
   '''   Durch dieser Ereignis wird der Passwort entschlüsselt.
   ''' </summary>
   ''' <remarks> Diese Ereignis wird durchgeführt, wenn die Button cbShowPassword gecheckt wird </remarks>
   Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
      ' wird die Button gecheckt.
      If cbShowPassword.Checked = True Then
         ' Passwort wird verschlüsselt.
         tbPassword.UseSystemPasswordChar = False
      Else
         ' Passwort wird entschlüsselt.
         tbPassword.UseSystemPasswordChar = True
      End If
   End Sub

   ''' <summary>
   '''   Durch dieser Ereignis wird jedes Zeichen der Passwort entschlüsselt
   ''' </summary>
   ''' <remarks> Diese Ereignis wird durchgeführt, wenn die Zeichen der Passwort eingegeben wird </remarks>
   Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
      ' LOKALE VARIABLEN DEKLARIEREN:
      Dim strZeichen As String     ' Die Zeichen der Passwort.

      ' Schleife auf aller Zeichen der Passwort.
      For Each strZeichen In tbPassword.ToString
         tbPassword.UseSystemPasswordChar = True
      Next
   End Sub

   ''' <summary>
   '''   Durch dieses Ereignis wird der usercontrol ucpasswordReset angerufen.
   ''' </summary>
   ''' <remarks> Diese Ereignis wird durchgeführt, wenn der LinkLabel llblPasswordForgotten betätigt wird</remarks>
   Private Sub llblPasswordForgotten_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblPasswordForgotten.LinkClicked
      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
      Dim ucSecurityQuestions As ucPasswordReset
      ' UserControl-Objekt instanzieren.
      ucSecurityQuestions = New ucPasswordReset
      ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
      Call GeneratorClassLibrary.clsUserControl.ShowUserControl(ucSecurityQuestions, pnlPasswordReset)

   End Sub

   Public Function FillTable() As DataTable
      ' LOKALE VARIABLEN DEKLARIEREN:
      Dim strQueryLogin As String      ' SqlAbfrage festlegen.

      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
      Dim sqlcmdManager As SqlCommand           ' Sql-Befehle ausführen.
      Dim sqlconManager As SqlConnection        ' Die Verbindung einer Datenbank herstellen.
      Dim dtDatatable As DataTable              ' die Tabellen erstellen
      Dim sqladDataAdapter As SqlDataAdapter    ' füllen die Tabellen einer Datenbank


      ' Connectionstring-Objekt instanzieren.
      sqlconManager = New SqlConnection
      ' Die Verbindung einer Datenbank festlegen.
      sqlconManager.ConnectionString = GeneratorClassLibrary.clsSetting.Getconnection
      ' Sql-command Objekt instanzieren.
      sqlcmdManager = New SqlCommand
      ' DataTable-objekt instanzieren
      dtDatatable = New DataTable
      ' Sql-Command zuweisen.
      sqlcmdManager.Connection = sqlconManager

      Using clsDbcmdGeneral As GeneratorClassLibrary.ClsDbManager = New GeneratorClassLibrary.ClsDbManager

         Try

            ' Verbindung öffnen.
            sqlconManager.Open()
            ' sql-Befehle zusammensetzen.
            strQueryLogin = String.Format("SELECT {1},{2} FROM {0} WHERE {1}=@1 AND {2}=@2",
                                          STR_TBL_USER,
                                          STR_FN_BENUTZERNAME,
                                          STR_FN_PASSWORT)
            With sqlcmdManager
               ' Parameters-collection leeren.
               .Parameters.Clear()
               ' Parameters collection einfügen.
               .Parameters.AddWithValue("@1", tbUsername.Text.Trim)
               .Parameters.AddWithValue("@2", tbPassword.Text.Trim)

               ' Sql-Abfrage festlegen.
               .CommandType = CommandType.Text
               .CommandText = strQueryLogin

            End With

            ' sqlDataAdapter-Objekt instanzieren
            sqladDataAdapter = New SqlDataAdapter(sqlcmdManager)

            ' Tabelle einer Datenbank füllen.
            sqladDataAdapter.Fill(dtDatatable)
            ' Objekt freigegen.
            sqlcmdManager.Dispose()
            sqlconManager.Dispose()
            sqladDataAdapter.Dispose()
            ' Die Verbindung schließen.
            sqlconManager.Close()

         Catch ex As Exception
            ' Fehlermeldung
            MessageBox.Show(ex.Message)
         End Try

      End Using

      Return dtDatatable

   End Function


End Class
