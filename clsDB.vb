Imports System.Data.SqlClient
Imports GeneratorClassLibrary.clsConstant
Imports System.Windows.Forms

Public Class ClsDB



    'Public Shared Function AddEntryToTable() As Integer
    '    ' LOKALE VARIABLEN DEKLARIEREN:
    '    Dim iCount As Integer               ' Anzahl der Einträge
    '    Dim strQueryRegister As String      ' SqlAbfrage festlegen

    '    ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
    '    Dim sqlcmdManager As SqlCommand
    '    Dim clsDbcmdGeneral As ClsDbManager
    '    ' Command-Objekt instanzieren.
    '    sqlcmdManager = New SqlCommand()
    '    ' Objekt der Klasse ClsDbManager instanzieren.
    '    clsDbcmdGeneral = New ClsDbManager


    '    Try
    '        clsDbcmdGeneral.Getcommand(False)
    '        ' sql-Befehle zusammensetzen
    '        strQueryRegister = String.Format("INSERT INTO {0} ({1},{2},{3},{4},{5},{6},{7},{8},{9})
    '                                           VALUES(:1, :2, :3, :4, :5, :6, :7, :8, :9)",
    '                                            ,
    '                                            STR_FN_NACHNAME,
    '                                            STR_FN_VORNAME,
    '                                            STR_FN_GEBURTSDATUM,
    '                                            STR_FN_STRASSE,
    '                                            STR_FN_NUMMER,
    '                                            STR_FN_STADT,
    '                                            STR_FN_PLZ,
    '                                            STR_FN_TELEFON,
    '                                             STR_FN_EMAIL)
    '        With sqlcmdManager


    '            ' Sql-Abfrage ausführen.
    '            .CommandType = CommandType.Text
    '            .CommandText = strQueryRegister

    '        End With
    '        ' Datensätze einfügen.
    '        iCount = sqlcmdManager.ExecuteNonQuery

    '        If iCount = 1 Then
    '            MsgBox("sie sind angemeldet")
    '        End If
    '        Return iCount
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Function

    'Public Sub ReadOderLogin(ByVal strQueryLogin As String, strconnection As String)

    '    ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
    '    Dim strSqlconnection As SqlConnection
    '    Dim SqlDbGeneral As ClsDbManager
    '    Dim SqlCmdData As SqlCommand

    '    SqlCmdData = New SqlCommand()
    '    SqlDbGeneral = New ClsDbManager()
    '    strSqlconnection = New SqlConnection(strconnection)

    '    Try

    '        SqlDbGeneral.Getcommand(False)

    '        With SqlCmdData
    '            ' Sql-Abfrage ausführen.
    '            .CommandType = CommandType.Text
    '            .CommandText = strQueryLogin

    '        End With
    '        ' Datensätze einfügen.

    '        If SqlCmdData.ExecuteNonQuery() = 1 Then
    '            MsgBox("sie sind angemeldet")
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try


    'End Sub


End Class
