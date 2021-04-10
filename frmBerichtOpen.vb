Imports System.Data.SqlClient
Imports GeneratorClassLibrary

Public Class frmBerichtöffnen



   Sub New()
      ' LOKALE VARIABLEN DEKLARIEREN:
      Dim strQueryLogin As String      ' SqlAbfrage festlegen.

      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
      Dim sqlcmdManager As SqlCommand           ' Sql-Befehle ausführen.
      Dim sqlconManager As SqlConnection        ' Die Verbindung einer Datenbank herstellen.
      Dim dtDatatable As DataTable              ' die Tabellen erstellen
      Dim sqladDataAdapter As SqlDataAdapter    ' füllen die Tabellen einer Datenbank
      Dim Constant As clsConstant
      'Dim cdbmManager As New ClsDbManager

      ' Dieser Aufruf ist für den Designer erforderlich.
      InitializeComponent()

      ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
      ' Connectionstring-Objekt instanzieren.
      sqlconManager = New SqlConnection
      ' Die Verbindung einer Datenbank festlegen.
      sqlconManager.ConnectionString = GeneratorClassLibrary.clsSetting.Getconnection
      ' Sql-command Objekt instanzieren.
      sqlcmdManager = New SqlCommand
      Constant = New clsConstant
      ' Sql-Command zuweisen.
      sqlcmdManager.Connection = sqlconManager

      Using clsDbcmdGeneral As GeneratorClassLibrary.ClsDbManager = New GeneratorClassLibrary.ClsDbManager

         Try
            ' Verbindung öffnen.
            sqlconManager.Open()
            'sqlcmdManager = cdbmManager.Getcommand(False)
            ' sql-Befehle zusammensetzen.
            strQueryLogin = String.Format("SELECT * FROM {0}",
                                          Constant.STR_TBL_REPORT)
            With sqlcmdManager
               ' Sql-Abfrage festlegen.
               .CommandType = CommandType.Text
               .CommandText = strQueryLogin

            End With

            ' sqlDataAdapter-Objekt instanzieren
            sqladDataAdapter = New SqlDataAdapter(sqlcmdManager)
            ' DataTable-objekt instanzieren
            dtDatatable = New DataTable
            ' Tabelle einer Datenbank füllen.
            sqladDataAdapter.Fill(dtDatatable)
            ' datagriview füllen.
            dgvReport.DataSource = dtDatatable

            ' Die Verbindung schließen.
            sqlconManager.Close()
            sqlcmdManager.Dispose()
            sqlconManager.Dispose()
            sqladDataAdapter.Dispose()
         Catch ex As Exception
            ' Fehlermeldung
            MessageBox.Show(ex.Message)
         End Try

      End Using

   End Sub

   Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click

      Me.Visible = False
   End Sub

End Class