Imports GeneratorClassLibrary.clsConstant

Public Class clsKeyValuesObject

    Public Shared strKey As String
    Public Shared strValue As String

    Private Shared Property Key() As String
        Get
            Return strKey
        End Get
        Set(ByVal strValue As String)
            strKey = strValue
        End Set
    End Property

   Public Property Value() As String
      Get
         Return strValue
      End Get
      Set(ByVal value As String)
         strValue = value
      End Set
   End Property


   Sub New(ByVal key As String, ByVal Value As String)
        strKey = key
        strValue = Value
        clsConstant.dcDictionary.Add(key, Value)
    End Sub

End Class
