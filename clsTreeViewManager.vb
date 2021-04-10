Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports GeneratorClassLibrary.clsConstant
Imports System.Xml
Imports System.IO

Public Class clsTreeViewManager

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="tvRechnung"> TreeView Datei</param>
   ''' <param name="dtpDateFrom"> Datum der Bestellung</param>
   ''' <param name="dtpDateTo">Datum der Bestellung</param>
   Public Shared Sub PopulateTreeView(ByVal tvRechnung As TreeView, ByVal dtpDateFrom As DateTimePicker, ByVal dtpDateTo As DateTimePicker)
      ' LOKALE VARIABLEN DEKLARIEREN:
      Dim strQuerySelect As String      ' SqlAbfrage festlegen.      
      Dim iOrderNumber As Integer       ' Bestellungsnummer des Artikels

      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:
      Dim sqlcmdManager As SqlCommand           ' Sql-Befehle ausführen.
      Dim sqlconManager As SqlConnection        ' Die Verbindung einer Datenbank herstellen.
      Dim sqldrDataReader As SqlDataReader      ' Die Datensätzen aus einer Datenbank einlesen.
      'Dim cdbManager As ClsDbManager
      Dim tnRootNode As TreeNode                ' Stellt einen Knoten von einem Treeview dar.
      Dim tnChildNode As TreeNode
      Dim tnOrderInfo As TreeNode


      ' Connectionstring-Objekt instanzieren.
      sqlconManager = New SqlConnection
      ' Die Verbindung einer Datenbank festlegen.
      sqlconManager.ConnectionString = GeneratorClassLibrary.clsSetting.Getconnection
      ' Sql-command Objekt instanzieren.
      sqlcmdManager = New SqlCommand
      'cdbManager = New ClsDbManager

      ' Sql-Command zuweisen.
      sqlcmdManager.Connection = sqlconManager

      Using clsDbcmdGeneral As GeneratorClassLibrary.ClsDbManager = New GeneratorClassLibrary.ClsDbManager

         Try
            ' Verbindung öffnen.
            sqlconManager.Open()
            ' command-Objekt vorbereiten.
            'sqlcmdManager = cdbManager.Getcommand(False)
            ' sql-Befehle zusammensetzen.
            strQuerySelect = String.Format("SELECT  {0}, {1}, {2}, {3}, {4}, {5},{6} FROM {7} WHERE {8} BETWEEN @1 AND @2",
                                            STR_FN_ID_BESTELLNR,
                                            STR_FN_KUNDECODE_ID,
                                            STR_FN_EMPFÄNGER,
                                            STR_FN_STRASSE,
                                            STR_FN_ORT,
                                            STR_FN_BESTIMMUNGSLAND,
                                            STR_FN_FAHRKOSTEN,
                                            STR_TBL_BESTELLUNG,
                                            STR_FN_BESTELLTSDATUM)

            With sqlcmdManager
               ' Parameters-collection leeren.
               .Parameters.Clear()
               ' Parameters collection einfügen.                    
               .Parameters.Add(New SqlParameter("@1", SqlDbType.DateTime))
               .Parameters.Add(New SqlParameter("@2", SqlDbType.DateTime))
               .Parameters("@1").Value = dtpDateFrom.Value
               .Parameters("@2").Value = dtpDateTo.Value
               ' Sql-Abfrage festlegen.
               .CommandType = CommandType.Text
               .CommandText = strQuerySelect

            End With

            ' sql-Befehle ausführen.
            sqldrDataReader = sqlcmdManager.ExecuteReader
            ' eine neue Instanz der TreeNode mit dem angegebenen Bezeichnungstest.
            tnRootNode = New TreeNode("Bestellungen")
            tvRechnung.Nodes.Add(tnRootNode)
            ' schleifen auf alle Datensätzen.
            While sqldrDataReader.Read()
               ' Datensatz einlesen.
               iOrderNumber = sqldrDataReader(STR_FN_ID_BESTELLNR)
               ' Unterknote des TreeViews festlegen
               tnChildNode = New TreeNode(iOrderNumber)
               ' Ein Node einfügen.
               tnRootNode.Nodes.Add(tnChildNode)
               ' Name des Unternodes festlegen.
               tnOrderInfo = New TreeNode("Bestellungsinformationen")
               ' Ein Node einfügen.
               tnChildNode.Nodes.Add(tnOrderInfo)
               ' Ein Node einfügen.
               tnOrderInfo.Nodes.Add(sqldrDataReader(STR_FN_KUNDECODE_ID))
               tnOrderInfo.Nodes.Add(sqldrDataReader(STR_FN_EMPFÄNGER))
               tnOrderInfo.Nodes.Add(sqldrDataReader(STR_FN_STRASSE))
               tnOrderInfo.Nodes.Add(sqldrDataReader(STR_FN_ORT))
               tnOrderInfo.Nodes.Add(sqldrDataReader(STR_FN_BESTIMMUNGSLAND))
               tnOrderInfo.Nodes.Add(sqldrDataReader(STR_FN_FAHRKOSTEN))

            End While
            tvRechnung.ExpandAll()
            ' Reader schließen.
            sqldrDataReader.Close()
            ' Die Verbindung schließen.
            sqlconManager.Close()
         Catch ex As Exception
            ' Fehlermeldung
            MessageBox.Show(ex.Message)
         End Try
      End Using

   End Sub

   ''' <summary>
   '''   Diese Function erstellt das Treeview
   ''' </summary>
   ''' <param name="tvNavigation"> TreeView Datei erstellen</param>
   Public Shared Sub CreateTreeView(ByVal tvNavigation As TreeView)
      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:    
      Dim xdocXmlData As XmlDocument     ' Stellt ein XML-Dokument dar.
      Dim xnXmlNode As XmlNode           ' Stellt einen einzelnen Knote im XML-Dokument dar.
      Dim xnlNodeList As XmlNodeList     ' eine geordnete Auflistung von Knoten.
      Dim strXmlWert As String           ' Wert des Knote festlegen.
      Dim tnNode As TreeNode             ' Knoten von einem Treeview stellen.

      Try
         ' XML-Dokument instanzieren.
         xdocXmlData = New XmlDocument()
         ' Das XML-Dokument aus dem angegebenen Stream laden.
         xdocXmlData.LoadXml(My.Resources.xmlNavigationTreeView.strXml)
         ' Struktureknote aus der auflistung entfernen.
         tvNavigation.Nodes.Clear()
         ' alle Untergeordneten Knoten des Knotens abrufen.
         xnlNodeList = xdocXmlData.DocumentElement.ChildNodes
         ' Schleife auf der Auflistung des Knotens
         For Each xnXmlNode In xnlNodeList
            ' Wert des Knotens festlegen.
            strXmlWert = xnXmlNode.Attributes(STR_TREEVIEW_ID).Value & STR_TREEVIEW_KEY_DELIMETER & xnXmlNode.Attributes(STR_TREEVIEW_TYPE).Value
            tnNode = tvNavigation.Nodes.Add(strXmlWert, xnXmlNode.Attributes(STR_TREEVIEW_VALUE).Value)
            Call AddNode(xnXmlNode, tnNode)
         Next
         ' Aktualisierung des Treeviws enden.
         tvNavigation.EndUpdate()
         tvNavigation.Refresh()
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   ''' <summary>
   '''   eine untergeordnete des Knotes einfügen.
   ''' </summary>
   ''' <param name="inXmlNode"> Knoten im Xml-Dokument </param>
   ''' <param name="inTreeNode"> Knoten von einem Treeview</param>
   Public Shared Sub AddNode(ByVal inXmlNode As XmlNode, ByVal inTreeNode As TreeNode)
      ' LOKALE VARIABLEN DEKLARIEREN:  
      Dim strXmlWert As String      ' Wert des Knotens festlegen.
      Dim xnNode As XmlNode         ' Stellt einen einzelnen Knote im XML-Dokument dar.
      Dim tnGeneral As TreeNode     ' Stellt einen einzelnen Knote im XML-Dokument dar.

      ' ist ein Knote  über ein untergeordnete Knoten verfügbar?
      If inXmlNode.HasChildNodes Then
         ' Schleife über alle untergeordnete Knoten des Knotes
         For Each xnNode In inXmlNode.ChildNodes
            ' Wert des Knotens festlegen.
            strXmlWert = xnNode.Attributes(STR_TREEVIEW_ID).Value & STR_TREEVIEW_KEY_DELIMETER & xnNode.Attributes(STR_TREEVIEW_TYPE).Value
            ' einen zuvor erstellten Strukturknoten an das Ende der Auflistung Strukturknoten einfügen.
            tnGeneral = inTreeNode.Nodes.Add(strXmlWert, xnNode.Attributes(STR_TREEVIEW_VALUE).Value)
            Call AddNode(xnNode, tnGeneral)
         Next
      End If

   End Sub

End Class
