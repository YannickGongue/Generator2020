Imports System.Data.SqlClient
Imports GeneratorClassLibrary.clsConstant


Public Class ucUserProfil


   Sub New()

      ' Dieser Aufruf ist für den Designer erforderlich.
      InitializeComponent()

      ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

   End Sub
   ''' <summary>
   '''   Durch dieses Ereignis werden die Datensätze geändert.
   ''' </summary>
   '''<remarks> Diese Ereignis wird durchgeführt, wenn der Toolstripbutton tsbUpdateProfile betätigt wird </remarks>
   Private Sub tsbUpdateProfile_Click(sender As Object, e As EventArgs) Handles tsbUpdateProfile.Click
        ' LOKALE VARIABLEN DEKLARIEREN:
        Dim iCount As Integer             ' Anzahl der Einträge.
        Dim strQueryUpdate As String      ' SqlAbfrage festlegen.

        ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
        Dim sqlcmdManager As SqlCommand        ' Sql-Befehle ausführen.
        Dim sqlconManager As SqlConnection     ' Die Verbindung einer Datenbank herstellen.
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
                strQueryUpdate = String.Format("UPDATE {0} SET {1} = @1, {2} = @2, {3} = @3, {4} = @4  WHERE {5} = @5",
                                                    STR_TBL_USER,
                                                    STR_FN_NACHNAME,
                                                    STR_FN_VORNAME,
                                                    STR_FN_TELEFON,
                                                    STR_FN_EMAIL,
                                                    STR_FN_ID_USER)
                With sqlcmdManager
                    ' Parameters-collection leeren.
                    .Parameters.Clear()
                    ' Parameters collection einfügen.
                    .Parameters.AddWithValue("@1", tbFirstname.Text.Trim)
                    .Parameters.AddWithValue("@2", tbLastname.Text.Trim)
                    .Parameters.AddWithValue("@3", tbTelefon.Text.Trim)
                    .Parameters.AddWithValue("@4", tbEmail.Text.Trim)
                    .Parameters.AddWithValue("@5", tbUserId.Text.Trim)

                    ' Sql-Abfrage festlegen.
                    .CommandType = CommandType.Text
                    .CommandText = strQueryUpdate
                End With
                ' sql-Befehle ausführen..
                iCount = sqlcmdManager.ExecuteNonQuery
                ' ist die Datensatz eigefügt?
                If iCount = 1 Then
                    MessageBox.Show(My.Resources.Resource.strUserUpdate)
                End If

                ' Die Verbindung schließen.
                sqlconManager.Close()
            Catch ex As Exception
                ' Fehlermeldung
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    ''' <summary>
    '''   Durch dieses Ereignis werden die Datensätze angezeigt
    ''' </summary>
    '''<remarks> Diese Ereignis wird durchgeführt, wenn der Toolstripbutton tsbSearch betätigt wird</remarks>
    Private Sub tsbSearch_Click(sender As Object, e As EventArgs) Handles tsbSearch.Click
        ' LOKALE VARIABLEN DEKLARIEREN:
        Dim strQuerySearch As String      ' SqlAbfrage festlegen.

        ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
        Dim sqlcmdManager As SqlCommand          ' Sql-Befehle ausführen.
        Dim sqlconManager As SqlConnection       ' Die Verbindung einer Datenbank herstellen.
        Dim sqldrDataReader As SqlDataReader     ' Die Datensätzen aus einer Datenbank einlesen.

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
                strQuerySearch = String.Format("SELECT {1}, {2}, {3}, {4}, {5}  FROM {0} WHERE {6} LIKE '% @6 %' ",
                                                STR_TBL_USER,
                                                STR_FN_NACHNAME,
                                                STR_FN_VORNAME,
                                                STR_FN_TELEFON,
                                                STR_FN_EMAIL,
                                                STR_FN_ID_USER,
                                                STR_FN_BENUTZERNAME)
                With sqlcmdManager

                    ' Parameters-collection leeren.
                    .Parameters.Clear()
                    ' Parameters collection einfügen.                    
                    .Parameters.AddWithValue("@6", " & tstSearchProfile.Text.Trim & ")

                    ' Sql-Abfrage festlegen.
                    .CommandType = CommandType.Text
                    .CommandText = strQuerySearch

                End With

                ' sql-Befehle ausführen.
                sqldrDataReader = sqlcmdManager.ExecuteReader
                ' ist die Datensatz eingefügt?
                While sqldrDataReader.Read()
                    lstData.Items.Add(sqldrDataReader(STR_FN_NACHNAME) &
                                      sqldrDataReader(STR_FN_VORNAME))
                End While

                ' Die Verbindung schließen.
                sqlconManager.Close()
            Catch ex As Exception
                ' Fehlermeldung
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
    ''' <summary>
    '''   Durch dieses Ereignis wird die Datensätze gelöscht.
    ''' </summary>
    '''<remarks> Diese Ereignis wird durchgeführt, wenn der Toolstripbutton btnDelete betätigt wird</remarks>
    Private Sub tsbDeleteProfil_Click(sender As Object, e As EventArgs) Handles tsbDeleteProfil.Click
        ' LOKALE VARIABLEN DEKLARIEREN:
        Dim iCount As Integer            ' Anzahl der Einträge.
        Dim strQueryDelete As String     ' SqlAbfrage festlegen.

        ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
        Dim sqlcmdManager As SqlCommand        ' Sql-Befehle ausführen.
        Dim sqlconManager As SqlConnection     ' Die Verbindung einer Datenbank herstellen.
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
                If tstSearchProfile.Text = "" Then
                    MessageBox.Show(My.Resources.Resource.StrNoText)
                Else
                    ' Verbindung öffnen.
                    sqlconManager.Open()
                    ' sql-Befehle zusammensetzen.
                    strQueryDelete = String.Format("DELETE  FROM {0} WHERE {1} = @1",
                                                        STR_TBL_USER,
                                                        STR_FN_BENUTZERNAME)
                    With sqlcmdManager
                        ' Parameters-collection leeren.
                        .Parameters.Clear()
                        ' Parameters collection einfügen.                    
                        .Parameters.AddWithValue("@1", tstSearchProfile.Text.Trim)

                        ' Sql-Abfrage festlegen.
                        .CommandType = CommandType.Text
                        .CommandText = strQueryDelete
                    End With
                    ' sql-Befehle ausführen..
                    iCount = sqlcmdManager.ExecuteNonQuery
                    ' ist die Datensatz eigefügt?
                    If iCount = 1 Then
                        MessageBox.Show(My.Resources.Resource.strUserDelete)
                    End If
                End If
                ' Die Verbindung schließen.
                sqlconManager.Close()
            Catch ex As Exception
                ' Fehlermeldung
                MessageBox.Show(ex.Message)
            End Try
            ' Textfelder leeren.
            tstSearchProfile.Text = ""
        End Using
    End Sub

    ''' <summary>
    '''   durch dieses Ereignis wird die usercontrol ucUserProfil geblendet
    ''' </summary>
    ''' <remark> dieser Ereignis wird durchgeführt, wenn die Button btnCancel betätigt wird</remark>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox(My.Resources.Resource.strUserControlExit, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Visible = False
        End If
    End Sub

   ''' <summary>
   '''   durch dieses Ereignis werden die ausgewählten Datensätzei in den TextFeldern angezeigt
   ''' </summary>
   ''' <remark> dieser Ereignis wird durchgeführt, wenn die Button btnOk betätigt wird</remark>>
   Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
      ' LOKALE VARIABLEN DEKLARIEREN:
      Dim strQuerySelect As String      ' SqlAbfrage festlegen.

      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
      Dim sqlcmdManager As SqlCommand           ' Sql-Befehle ausführen.
      Dim sqlconManager As SqlConnection        ' Die Verbindung einer Datenbank herstellen.
      Dim sqldrDataReader As SqlDataReader      ' Die Datensätzen aus einer Datenbank einlesen.
      Dim ucUserLogin As ucLoginInGenerator     '

      ' Connectionstring-Objekt instanzieren.
      sqlconManager = New SqlConnection
      ' Die Verbindung einer Datenbank festlegen.
      sqlconManager.ConnectionString = GeneratorClassLibrary.clsSetting.Getconnection
      ' Sql-command Objekt instanzieren.
      sqlcmdManager = New SqlCommand
      ' Benutzersteuerelement instanzieren
      ucUserLogin = New ucLoginInGenerator
      ' Sql-Command zuweisen.
      sqlcmdManager.Connection = sqlconManager

      Using clsDbcmdGeneral As GeneratorClassLibrary.ClsDbManager = New GeneratorClassLibrary.ClsDbManager

         Try
            ' Verbindung öffnen.
            sqlconManager.Open()
            ' sql-Befehle zusammensetzen.
            strQuerySelect = String.Format("SELECT {1}, {2}, {3}, {4}, {5} FROM {0} WHERE {6} = @6 ",
                                            STR_TBL_USER,
                                            STR_FN_NACHNAME,
                                            STR_FN_VORNAME,
                                            STR_FN_TELEFON,
                                            STR_FN_EMAIL,
                                            STR_FN_ID_USER,
                                            STR_FN_BENUTZERNAME)
            With sqlcmdManager

               ' Parameters-collection leeren.
               .Parameters.Clear()
               ' Parameters collection einfügen.                    
               .Parameters.AddWithValue("@6", tstSearchProfile.Text.Trim)

               ' Sql-Abfrage festlegen.
               .CommandType = CommandType.Text
               .CommandText = strQuerySelect

            End With

            ' sql-Befehle ausführen.
            sqldrDataReader = sqlcmdManager.ExecuteReader
            ' ist die Datensatz eingefügt?
            While sqldrDataReader.Read()
               tbFirstname.Text = sqldrDataReader(STR_FN_NACHNAME)
               tbLastname.Text = sqldrDataReader(STR_FN_VORNAME)
               tbUserId.Text = sqldrDataReader(STR_FN_ID_USER)
               tbTelefon.Text = sqldrDataReader(STR_FN_TELEFON)
               tbEmail.Text = sqldrDataReader(STR_FN_EMAIL)
            End While

            ' Die Verbindung schließen.
            sqlconManager.Close()
         Catch ex As Exception
            ' Fehlermeldung
            MessageBox.Show(ex.Message)
         End Try
      End Using
      ' textfelder leeren.
      tstSearchProfile.Text = ""
   End Sub


End Class
