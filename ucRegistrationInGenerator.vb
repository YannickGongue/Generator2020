Imports System.Data.SqlClient
Imports System.Xml
Imports GeneratorClassLibrary.clsConstant



''' <summary>
'''    user anmeden und die Anmeldeung informationen in einer Datenbank zu speichern.
''' </summary>
Public Class ucRegistrationInGenerator

    ''' <summary>
    '''   Durch die Ausführung dieses Ereignis werden die Datensätzen in einer Datenbank eintragen.
    ''' </summary>
    ''' <remarks> Diese Ereignis wird ausgeführt,wenn die Button BtnSave betätigt wird </remarks>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' LOKALE VARIABLEN DEKLARIEREN:
        Dim iCount As Integer               ' Anzahl der Einträge.
        Dim strQueryRegister As String      ' SqlAbfrage festlegen.

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
            strQueryRegister = String.Format("INSERT INTO {0} ({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19})
                                             VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19)",
                                             STR_TBL_USER,
                                             STR_FN_NACHNAME,
                                             STR_FN_VORNAME,
                                             STR_FN_GEBURTSDATUM,
                                             STR_FN_STRASSE,
                                             STR_FN_NUMMER,
                                             STR_FN_STADT,
                                             STR_FN_PLZ,
                                             STR_FN_TELEFON,
                                             STR_FN_EMAIL,
                                             STR_FN_BENUTZERNAME,
                                             STR_FN_PASSWORT,
                                             STR_FN_ID_USER,
                                             STR_FN_GESCHLECHTE,
                                             STR_FN_FRAGE1,
                                             STR_FN_FRAGE2,
                                             STR_FN_FRAGE3,
                                             STR_FN_ANTWORT1,
                                             STR_FN_ANTWORT2,
                                             STR_FN_ANTWORT3)
            With sqlcmdManager
                    ' Parameters-collection leeren.
                    .Parameters.Clear()
                    ' Parameters collection einfügen.
                    .Parameters.AddWithValue("@1", tbFirstName.Text.Trim)
                    .Parameters.AddWithValue("@2", tbLastName.Text.Trim)
                    .Parameters.AddWithValue("@3", dtpBirthday.Text.Trim)
                    .Parameters.AddWithValue("@4", tbStreet.Text.Trim)
                    .Parameters.AddWithValue("@5", tbNr.Text.Trim)
                    .Parameters.AddWithValue("@6", tbCity.Text.Trim)
                    .Parameters.AddWithValue("@7", tbPlz.Text.Trim)
                    .Parameters.AddWithValue("@8", tbTelephon.Text.Trim)
                    .Parameters.AddWithValue("@9", tbEmail.Text.Trim)
                    .Parameters.AddWithValue("@10", tbUsername.Text.Trim)
                    .Parameters.AddWithValue("@11", tbPassword.Text.Trim)
                    .Parameters.AddWithValue("@12", tbUser_ID.Text.Trim)
                    .Parameters.AddWithValue("@13", GeneratorClassLibrary.ClsVariables.strGender.Trim)
                    .Parameters.AddWithValue("@14", cbQuestion1.Text.Trim)
                    .Parameters.AddWithValue("@15", cbQuestion2.Text.Trim)
                    .Parameters.AddWithValue("@16", cbQuestion3.Text.Trim)
                    .Parameters.AddWithValue("@17", tbAnswer1.Text.Trim)
                    .Parameters.AddWithValue("@18", tbAnswer2.Text.Trim)
                    .Parameters.AddWithValue("@19", tbAnswer3.Text.Trim)

                    ' Sql-Abfrage festlegen.
                    .CommandType = CommandType.Text
                    .CommandText = strQueryRegister
                End With
                ' sql-Befehle ausführen..
                iCount = sqlcmdManager.ExecuteNonQuery
                ' ist die Datensatz eigefügt?
                If iCount = 1 Then
                    MessageBox.Show(My.Resources.Resource.strUserRegister)
                End If

                ' Xml Datei erstellen.
                Call XmlData()

                ' Die Verbindung schließen.
                sqlconManager.Close()
            Catch ex As Exception
            ' Fehlermeldung.
            MessageBox.Show(ex.Message)
            End Try
        End Using

    End Sub

    '''<summary>
    '''  Durch die Ausführung dieses Ereignis wird das string M eintragen.
    '''</summary>
    '''<remarks> Diese Ereignis wird ausgeführt,wenn die RadioButton betätigt wird </remarks>
    Private Sub rbMann_CheckedChanged(sender As Object, e As EventArgs) Handles rbMann.CheckedChanged
        GeneratorClassLibrary.ClsVariables.strGender = "M"
    End Sub
    '''<summary>
    '''  Durch die Ausführung dieses Ereignis wird das string F eintragen.
    '''</summary>
    '''<remarks> Diese Ereignis wird ausgeführt,wenn die RadioButton betätigt wird </remarks>
    Private Sub rbFrau_CheckedChanged(sender As Object, e As EventArgs) Handles rbFrau.CheckedChanged
        GeneratorClassLibrary.ClsVariables.strGender = "F"
    End Sub

    '''<summary>
    '''  Durch die Ausführung dieses Ereignis wird die Applikation beendet.
    '''</summary>
    '''<remarks> Diese Ereingnis wird durchgeführt, wenn die Button btnExit betätigt wird </remarks> 
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      If MsgBox(My.Resources.Resource.strUserControlExit, MessageBoxButtons.YesNo) = DialogResult.Yes Then
         Me.Visible = False
      End If
   End Sub

    ''' <summary>
    '''   Durch die Ausführung dieses Ereignis wird die Passwort entschlüßeln
    ''' </summary>
    ''' <remarks> Diese Ereignis wird durchgeführt,wenn der checkBox gehackt wird </remarks>
    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked = True Then
            tbPassword.UseSystemPasswordChar = False
            tbConfirm.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
            tbConfirm.UseSystemPasswordChar = True

        End If
    End Sub

    ''' <summary>
    '''   Durch die Ausführung dieses Ereignis wird die Passwort verschlüßeln
    ''' </summary>
    ''' <remarks>Diese Ereignis wird durchgeführt,wenn der checkBox gehackt wird </remarks>
    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        Dim strZeichen As String
        ' alle Zeichen der Password verschlüssen.
        For Each strZeichen In tbPassword.ToString
            tbPassword.UseSystemPasswordChar = True
        Next
    End Sub
    ''' <summary>
    '''   Durch die Ausführung dieses Ereignis wird die Passwort verschlüßeln
    ''' </summary>
    ''' <remarks>Diese Ereignis wird durchgeführt,wenn der checkBox gehackt wird </remarks>
    Private Sub tbConfirm_TextChanged(sender As Object, e As EventArgs) Handles tbConfirm.TextChanged
        Dim strZeichen As String
        ' alle Zeichen der Password verschlüssen.
        For Each strZeichen In tbConfirm.ToString
            tbConfirm.UseSystemPasswordChar = True
        Next
    End Sub

    ''' <summary>
    '''   erstellt eine XML-Datei.
    ''' </summary>
    Public Sub XmlData()

      ' KLASSENOBJEKTEN DEKLARIEREN:
      'Dim xtwUserFile As XmlTextWriter                            ' Zum Erstellen einer neuen XML-Datei.
      Dim cvUserdata As New GeneratorClassLibrary.ClsVariables     ' Objekt-Klassen Variablen erzeugen

      ' TextBox-Daten aus dem Screem-Formular holen.
      cvUserdata.Benutzername = tbUsername.Text
      cvUserdata.Passwort = tbPassword.Text
      cvUserdata.Nachname = tbFirstName.Text
      cvUserdata.Vorname = tbLastName.Text
      cvUserdata.GeburstDatum = dtpBirthday.Text
      cvUserdata.Geschlechte = GeneratorClassLibrary.ClsVariables.strGender
      cvUserdata.Id_User = tbUser_ID.Text
      cvUserdata.Telefon = tbTelephon.Text
      cvUserdata.Email = tbEmail.Text

      Call GeneratorClassLibrary.clsXmlDataManager.createUserXml(cvUserdata, GeneratorClassLibrary.clsXmlDataManager.GetFileName)

   End Sub


End Class
