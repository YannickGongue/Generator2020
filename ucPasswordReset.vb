Imports System.Data.SqlClient
Imports GeneratorClassLibrary.clsConstant


Public Class ucPasswordReset


    ''' <summary>
    '''   Durch dieses Ereignis wird die Sicherheitsfrage des Benutzers ausgesucht.
    ''' </summary>
    ''' <remarks> Dieser Ereignis wird ausgeführt, wenn der Button btnSearch betätigt wird </remarks>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
      ' LOKALE VARIABLEN DEKLARIEREN:
      Dim strPasswordReset As String      ' SqlAbfrage festlegen.

      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
      Dim sqlcmdManager As SqlCommand          ' Sql-Befehle ausführen.
      Dim sqlconManager As SqlConnection       ' Die Verbindung einer Datenbank herstellen.
      Dim sqldrDataReader As SqlDataReader     ' Die Datensätzen aus einer Datenbank einlesen.
      'Dim cdbManager As GeneratorClassLibrary.ClsDbManager
      Dim ucQuestion As ucSecurityQuestion

      ' Connectionstring-Objekt instanzieren.
      sqlconManager = New SqlConnection
      ' Die Verbindung einer Datenbank festlegen.
      sqlconManager.ConnectionString = GeneratorClassLibrary.clsSetting.Getconnection
      ' Sql-command Objekt instanzieren.
      sqlcmdManager = New SqlCommand
      ' Sql-Command zuweisen.
      sqlcmdManager.Connection = sqlconManager
      ' Sql-command vorbereiten.
      'cdbManager = New GeneratorClassLibrary.ClsDbManager
      ' UserControl-Objekt instanzieren
      ucQuestion = New ucSecurityQuestion

      Using clsDbcmdGeneral As GeneratorClassLibrary.ClsDbManager = New GeneratorClassLibrary.ClsDbManager

         Try
            ' Verbindung öffnen.
            sqlconManager.Open()
            'sqlcmdManager = cdbManager.Getcommand(False)
            ' Ist der TextFeld leer?
            If tbSearch.Text = "" Then
               MessageBox.Show(My.Resources.Resource.strTextBoxEmpty)
               Exit Sub
            Else
               ' sql-Befehle zusammensetzen.
               strPasswordReset = String.Format("SELECT {0},{1},{2} FROM {3} WHERE {4} = @4",
                                                STR_FN_FRAGE1,
                                                STR_FN_FRAGE2,
                                                STR_FN_FRAGE3,
                                                STR_TBL_USER,
                                                STR_FN_ID_USER)
               With sqlcmdManager
                  ' Parameters-collection leeren.
                  .Parameters.Clear()
                  ' Parameters collection einfügen.
                  .Parameters.AddWithValue("@4", tbSearch.Text.Trim)

                  ' Sql-Abfrage festlegen.
                  .CommandType = CommandType.Text
                  .CommandText = strPasswordReset
               End With
               ' sql-Befehle ausführen.
               sqldrDataReader = sqlcmdManager.ExecuteReader
               ' alle Datensätze lesen.
               While sqldrDataReader.Read()
                  ucQuestion.cbQuestion1.Items.Add(sqldrDataReader.Item(STR_FN_FRAGE1))
                  ucQuestion.cbQuestion2.Items.Add(sqldrDataReader.Item(STR_FN_FRAGE2))
                  ucQuestion.cbQuestion3.Items.Add(sqldrDataReader.Item(STR_FN_FRAGE3))
               End While
               ' Die Verbindung schließen.
               sqlconManager.Close()
            End If
         Catch ex As Exception
            MessageBox.Show(ex.Message)
         End Try

         ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
         Call GeneratorClassLibrary.clsUserControl.ShowUserControl(ucQuestion, pnlSecurityQuestion)

      End Using
   End Sub


    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim ucNewPassword As ucNewPassword
        ucNewPassword = New ucNewPassword

      ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
      Call GeneratorClassLibrary.clsUserControl.ShowUserControl(ucNewPassword, pnlSecurityQuestion)

   End Sub

   Public Sub resetPassword()
      ' LOKALE VARIABLEN DEKLARIEREN:
      Dim iCount As String                 ' Anzahl der gelöschte Datensatz
      Dim strPasswordSelect As String      ' SqlAbfrage festlegen.
      Dim strPassordDelete As String

      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
      Dim sqlcmdManager As SqlCommand           ' Sql-Befehle ausführen.
      Dim sqlconManager As SqlConnection        ' Die Verbindung einer Datenbank herstellen.
      Dim dtDataTable As DataTable              ' Die Tabelle festlegen.
      Dim sqladDataAdapter As SqlDataAdapter    ' füllen die Tabellen einer Datenbank

      ' Connectionstring-Objekt instanzieren.
      sqlconManager = New SqlConnection
      ' Die Verbindung einer Datenbank festlegen.
      sqlconManager.ConnectionString = GeneratorClassLibrary.clsSetting.Getconnection
      ' Sql-command Objekt instanzieren.
      sqlcmdManager = New SqlCommand
      ' Sql-Command zuweisen.
      sqlcmdManager.Connection = sqlconManager


      Using clsDbcmdGeneral As GeneratorClassLibrary.ClsDbManager = New GeneratorClassLibrary.ClsDbManager

         Try
            ' Verbindung öffnen.
            sqlconManager.Open()
            ' sql-Befehle zusammensetzen.
            strPasswordSelect = String.Format(" SELECT {0} FROM {1} WHERE {2} = @2 ",
                                                  STR_FN_PASSWORT,
                                                  STR_TBL_USER,
                                                  STR_FN_ID_USER)
            With sqlcmdManager
               ' Parameters-collection leeren.
               .Parameters.Clear()
               ' Parameters collection einfügen.
               .Parameters.AddWithValue("@2", tbSearch.Text.Trim)

               ' Sql-Abfrage festlegen.
               .CommandType = CommandType.Text
               .CommandText = strPasswordSelect
            End With
            ' sqlDataAdapter-Objekt instanzieren
            sqladDataAdapter = New SqlDataAdapter(sqlcmdManager)
            ' DataTable-objekt instanzieren
            dtDataTable = New DataTable
            ' Tabelle einer Datenbank füllen.
            sqladDataAdapter.Fill(dtDataTable)
            ' wird die Datensätzen eingefügt?
            If dtDataTable.Rows.Count = 1 Then
               strPassordDelete = String.Format("DELETE FROM dtDataTable")
               With sqlcmdManager
                  ' Sql-Abfrage festlegen.
                  .CommandType = CommandType.Text
                  .CommandText = strPassordDelete
               End With
               iCount = sqlcmdManager.ExecuteNonQuery
               If iCount = 1 Then
                  MessageBox.Show(My.Resources.Resource.strPasswordDelete)
               End If
            End If

         Catch ex As Exception
            MessageBox.Show(ex.Message)
         End Try
      End Using
   End Sub

   Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
      Me.Visible = False
   End Sub
End Class
