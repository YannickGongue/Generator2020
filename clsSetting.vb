Public Class clsSetting

   Public Shared Function Getconnection() As String
      Return "Data Source=(LocalDB)\MSSQLLocalDB;
           AttachDbFilename=C:\Users\yannick\Documents\sql_projekt\Generator2020\GeneratorControlLibrary\DbHochschule.mdf;
           Integrated Security=True"
   End Function

   Public Shared Function GetFilePfad() As String
      Return "C:\Users\yannick\Documents\sql_projekt\Generator2020\Generator\obj\Release\XmlDatei.xml"
   End Function

End Class
