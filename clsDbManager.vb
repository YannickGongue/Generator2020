Imports System.Data.SqlClient


''' <summary>
'''    Diese Klasse erstellt eine Vrebindung einer Datenbank.
''' </summary>
Public Class ClsDbManager
    Implements IDisposable

    ''' <summary>
    '''   Stellt die ausführung der sql-Abfrage dar.
    ''' </summary>
    Private sqlcmdManager As SqlCommand

    ''' <summary>
    '''   Stellt die Verbindung einer Datenbank dar.
    ''' </summary>
    Private sqlTran As SqlTransaction

    ''' <summary>
    '''   Stellt die Verbindung einer Datenbank
    ''' </summary>
    Private sqlConDbManager As SqlConnection

    Sub New(ByVal strConn As String)
        sqlConDbManager = New SqlConnection(strConn)
    End Sub

    Sub New()
        sqlConDbManager = New SqlConnection(GeneratorClassLibrary.ClsVariables.connectionString)
    End Sub


   ''' <summary>
   '''   erstellt eine command-objekt zum festlegen des Sql-befehle.
   ''' </summary>
   ''' <param name="bsqlTransaction"></param>
   ''' <returns> Gibt eine command-objekt zurück, wenn eine verbindung einer Datenbank erstellt wird</returns>
   Public Function Getcommand(ByVal bsqlTransaction As Boolean) As SqlCommand
      ' SqlCommand-Objekt instanzieren
      sqlcmdManager = New SqlCommand()

      ' Transaktionsobjekt als auch Verbindung zuordnen.
      sqlcmdManager.Connection = sqlConDbManager
      sqlcmdManager.Transaction = sqlTran

      If bsqlTransaction = True Then
         ' Startet eine Datenbanktransaktion.
         sqlTran = sqlConDbManager.BeginTransaction()
      End If
      ' Rückgabewert
      Return sqlcmdManager

   End Function

   ''' <summary>
   '''   Die Objekte freigeben
   ''' </summary>
   Public Sub Dispose()
        sqlcmdManager.Dispose()
        sqlConDbManager.Dispose()
        sqlTran.Dispose()
    End Sub

    ''' <summary>
    '''   Überprüft,ob die Verbindung verfügbar ist.
    ''' </summary>
    ''' <param name="strcon"> connectionstring einer Datenbank </param>
    ''' <returns> gibt ein leere String zurück sonst eine Fehlermeldung</returns>
    Public Shared Function Checkconnection(ByVal strcon As String) As String
        ' Die OBJEKTEVARIABLEN DEKLARIEREN:
        Dim clscmdDbManager As ClsDbManager

        Try
            ' Objekt-Klasse instanzieren
            clscmdDbManager = New ClsDbManager(strcon)
            ' Rückgabewert
            clscmdDbManager.Getcommand(False)

            Return String.Empty

        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try

    End Function

    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        DirectCast(sqlConDbManager, IDisposable).Dispose()
    End Sub
End Class
