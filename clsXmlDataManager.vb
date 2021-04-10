Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO
Imports System.Xml.Serialization
Imports GeneratorClassLibrary


Public Class clsXmlDataManager

   ''' <summary>
   '''   XmlDatei erstellen.
   ''' </summary>
   ''' <param name="objUser"> Das zu serialisierende Objekt </param>
   ''' <param name="strFileName"> Dateiname der Xml-Datei</param>
   Public Shared Sub createUserXml(ByVal objUser As Object, ByVal strFileName As String)
      ' KLASSENOBJEKTEN DEKLARIEREN:
      Dim xsXmlSerializer As XmlSerializer     ' 
      Dim twTextWriter As TextWriter           ' Der XmlWriter wurde zum Schreiben des XML-Dokuments verwendet. 

      ' Serialisiert das angegebene Objekt.
      xsXmlSerializer = New XmlSerializer(objUser.GetType())
      '
      twTextWriter = New StreamWriter(strFileName)
      ' schreibt das XML-Dokument mit dem angegebenen TextWriter in eine Datei.
      xsXmlSerializer.Serialize(twTextWriter, objUser)

      twTextWriter.Close()

   End Sub



   Public Shared Function GetAttribute() As String
      ' LOKALE OBJEKTVARIABLEN DEKLARIEREN:    
      Dim fsFileStream As FileStream     ' Stellt ein Stream für eine Datei bereit dar,wobei die Lese und schreibvorgänge unterstuzt werden.
      Dim xdocXmlData As XmlDocument     ' Stellt ein XML-Dokument dar.
      'Dim xnXmlNode As XmlNode          ' Stellt einen einzelnen Knote im XML-Dokument dar.
      'Dim tnTreeNode As TreeNode        ' Stellt einen Knoten von einem TreeView dar.
      Dim Filename As String             ' Stellt die Pfad der Xml-Dokument.
      Dim xeElement As XmlElement
      Dim xaXmlAttribute As XmlAttribute

      ' Pfad des XML-Dokument.
      Filename = GeneratorClassLibrary.clsSetting.GetFilePfad
      ' XML-Dokument instanzieren.
      xdocXmlData = New XmlDocument()
      ' Stream instanzieren.
      fsFileStream = New FileStream(Filename, FileMode.Open, FileAccess.Read)
      ' Das XML-Dokument aus dem angegebenen Stream laden.
      xdocXmlData.Load(fsFileStream)

      xeElement = xdocXmlData.DocumentElement

      For Each xeElement In xdocXmlData
         xaXmlAttribute = xeElement.GetAttributeNode("value")
      Next

      Return xaXmlAttribute.Value

   End Function

   ''' <summary>
   '''    Name der Xmldatei festlegen
   ''' </summary>
   ''' <returns></returns>
   Public Shared Function GetFileName() As String
      Return ClsVariables.strBenutzername & "_" & ClsVariables.strId_User & ".xml"
   End Function

   Public Shared Function GetReportName() As String
      Return "Report" & "_" & "99999" & ".xml"
   End Function



End Class
