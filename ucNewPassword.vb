Imports System.Data.SqlClient
Imports GeneratorClassLibrary.clsConstant

Public Class ucNewPassword
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
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
                If tbNewPassword.Text = "" And tbNewUsername.Text = "" Then
                    MessageBox.Show(My.Resources.Resource.strErrorLogin)
                Else
                    ' Verbindung öffnen.
                    sqlconManager.Open()
               ' sql-Befehle zusammensetzen.
               strQueryUpdate = String.Format("UPDATE {0} SET {1} = @1 ,{2} = @2 WHERE {1} = @3 AND {2} = @4 ",
                                                        STR_TBL_USER,
                                                        STR_FN_BENUTZERNAME,
                                                        STR_FN_PASSWORT)
               With sqlcmdManager
                        ' Parameters-collection leeren.
                        .Parameters.Clear()
                        ' Parameters collection einfügen.
                        .Parameters.AddWithValue("@1", tbNewUsername.Text.Trim)
                        .Parameters.AddWithValue("@2", tbNewPassword.Text.Trim)

                        ' Sql-Abfrage festlegen.
                        .CommandType = CommandType.Text
                        .CommandText = strQueryUpdate
                    End With
                    ' sql-Befehle ausführen.
                    iCount = sqlcmdManager.ExecuteNonQuery
                    ' ist die Passwort gleich.
                    If tbNewPassword.Text = tbPasswordConfirm.Text Then
                        ' ist die Datensatz eigefügt?
                        If iCount = 1 Then
                            MessageBox.Show(My.Resources.Resource.strUserUpdate)
                        End If
                    Else
                        MessageBox.Show(My.Resources.Resource.strPasswordNoConfirm)
                    End If

                    ' Die Verbindung schließen.
                    sqlconManager.Close()
                End If
            Catch ex As Exception
                ' Fehlermeldung
                MessageBox.Show(ex.Message)
            End Try
        End Using

        ' Textfelder leeren.
        tbNewUsername.Text = ""
        tbNewPassword.Text = ""
        tbPasswordConfirm.Text = ""

    End Sub

    ''' <summary>
    '''   Durch die Ausführung dieses Ereignis wird die Passwort verschlüßeln
    ''' </summary>
    ''' <remarks>Diese Ereignis wird durchgeführt,wenn der checkBox gehackt wird </remarks>
    Private Sub tbNewPassword_TextChanged(sender As Object, e As EventArgs) Handles tbNewPassword.TextChanged
        Dim strZeichen As String
        ' alle Zeichen der Password verschlüssen.
        For Each strZeichen In tbNewPassword.ToString
            tbNewPassword.UseSystemPasswordChar = True
        Next
    End Sub

    ''' <summary>
    '''   Durch die Ausführung dieses Ereignis wird die Passwort verschlüßeln
    ''' </summary>
    ''' <remarks>Diese Ereignis wird durchgeführt,wenn der checkBox gehackt wird </remarks>
    Private Sub tbPasswordConfirm_TextChanged(sender As Object, e As EventArgs) Handles tbPasswordConfirm.TextChanged
        Dim strZeichen As String
        ' alle Zeichen der Password verschlüssen.
        For Each strZeichen In tbPasswordConfirm.ToString
            tbPasswordConfirm.UseSystemPasswordChar = True
        Next
    End Sub

    ''' <summary>
    '''   Durch die Ausführung dieses Ereignis wird die Passwort entschlüßeln
    ''' </summary>
    ''' <remarks> Diese Ereignis wird durchgeführt,wenn der checkBox gehackt wird </remarks>
    Private Sub cbShowNewPasword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowNewPasword.CheckedChanged
        If cbShowNewPasword.Checked = True Then
            tbNewPassword.UseSystemPasswordChar = False
            tbPasswordConfirm.UseSystemPasswordChar = False
        Else
            tbNewPassword.UseSystemPasswordChar = True
            tbPasswordConfirm.UseSystemPasswordChar = True

        End If
    End Sub

   Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
      Me.Visible = False
   End Sub
End Class
