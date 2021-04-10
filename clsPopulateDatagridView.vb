Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports GeneratorClassLibrary.clsConstant

Public Class clsPopulateDatagridView


   Public Shared Sub PopulateGridView(ByVal dgvKundenInfo As DataGridView, ByVal tvRechnung As TreeView)
      ' LOKALE VARIABLEN DEKLARIEREN:
      Dim strQueryLogin As String      ' SqlAbfrage festlegen.
      Dim strorderInTreeview As String

      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
      Dim sqlcmdManager As SqlCommand           ' Sql-Befehle ausführen.
      Dim sqlconManager As SqlConnection        ' Die Verbindung einer Datenbank herstellen.
      Dim dtDatatable As DataTable              ' die Tabellen erstellen
      Dim sqladDataAdapter As SqlDataAdapter    ' füllen die Tabellen einer Datenbank
      'Dim cdbmManager As New ClsDbManager


      ' Connectionstring-Objekt instanzieren.
      sqlconManager = New SqlConnection
      ' Die Verbindung einer Datenbank festlegen.
      sqlconManager.ConnectionString = GeneratorClassLibrary.clsSetting.Getconnection
      ' Sql-command Objekt instanzieren.
      sqlcmdManager = New SqlCommand
      ' Sql-Command zuweisen.
      sqlcmdManager.Connection = sqlconManager
      ' die Selektierte Knoten des TreeViews.
      strorderInTreeview = tvRechnung.SelectedNode.Text

      Using clsDbcmdGeneral As GeneratorClassLibrary.ClsDbManager = New GeneratorClassLibrary.ClsDbManager

         Try
            ' Verbindung öffnen.
            sqlconManager.Open()
            'sqlcmdManager = cdbmManager.Getcommand(False)
            ' sql-Befehle zusammensetzen.
            strQueryLogin = String.Format("SELECT {0}.{2},{0}.{4},{0}.{5},{0}.{6},{0}.{7} FROM {0},{1} WHERE {1}.{8}=@1",
                                          STR_TBL_KUNDE,
                                          STR_TBL_BESTELLUNG,
                                          STR_FN_ID_KUNDECODE,
                                          STR_FN_POSITION,
                                          STR_FN_KONTAKTPERSON,
                                          STR_FN_LAND,
                                          STR_FN_TELEFON,
                                          STR_FN_TELEFAX,
                                          STR_FN_ID_BESTELLNR)
            With sqlcmdManager
               ' Parameters-collection leeren.
               .Parameters.Clear()
               ' Parameters collection einfügen.
               .Parameters.AddWithValue("@1", strorderInTreeview.Trim)

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
            dgvKundenInfo.DataSource = dtDatatable

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

End Class
