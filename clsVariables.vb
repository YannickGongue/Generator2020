Public Class ClsVariables

    ' KLASSENVARIABLEN DEKLARIEREN:
    Public Shared strNachname As String
    Public Shared strVorname As String
    Public Shared strGebursttag As String
    Public Shared strTelefon As String
    Public Shared strGeschlechte As String
    Public Shared strId_User As String
    Public Shared strEmail As String
    Public Shared strBenutzername As String
    Public Shared strPassword As String

    Public Shared strGender As String
    Public Shared strQuestion As String


    Private Shared strcon As String
    Public Shared Property connectionString() As String
        Get
            Return strcon
        End Get
        Set(ByVal strValue As String)
            strcon = strValue
        End Set
    End Property

    Public Property Nachname() As String
        Get
            Return strNachname
        End Get
        Set(strValue As String)
            strNachname = strValue
        End Set
    End Property

    Public Property Vorname() As String
        Get
            Return strVorname
        End Get
        Set(strValue As String)
            strVorname = strValue
        End Set
    End Property

    Public Property Telefon() As String
        Get
            Return strTelefon
        End Get
        Set(strValue As String)
            strTelefon = strValue
        End Set
    End Property

    Public Property GeburstDatum() As String
        Get
            Return strGebursttag
        End Get
        Set(strValue As String)
            strGebursttag = strValue
        End Set
    End Property
    Public Property Geschlechte() As String
        Get
            Return strGeschlechte
        End Get
        Set(strValue As String)
            strGeschlechte = strValue
        End Set
    End Property

    Public Property Id_User() As String
        Get
            Return strId_User
        End Get
        Set(strValue As String)
            strId_User = strValue
        End Set
    End Property

    Public Property Benutzername() As String
        Get
            Return strBenutzername
        End Get
        Set(strValue As String)
            strBenutzername = strValue
        End Set
    End Property

    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(strValue As String)
            strEmail = strValue
        End Set
    End Property

    Public Property Passwort() As String
        Get
            Return strPassword
        End Get
        Set(strValue As String)
            strPassword = strValue
        End Set
    End Property

End Class
