
Public Class clsConstant

   Public Shared dcDictionary As New Dictionary(Of String, String)

   Public Shared kvoUsername As New clsKeyValuesObject("STR_FN_BENUTZERNAME", "Benutzername")
   Public Shared KvoPassword As New clsKeyValuesObject("STR_FN_PASSWORT", "Passwort")
   Public Shared KvoIdKundeCode As New clsKeyValuesObject("STR_FN_ID_KUNDECODE", "ID_KundeCode")
   Public Shared kvoVersandDatum As New clsKeyValuesObject("STR_FN_VERSANDDATUM", "Versanddatum")
   Public Shared kvoBestellDatum As New clsKeyValuesObject("STR_FN_BESTELLTSDATUM", "Bestelldatum")
   Public Shared kvoLieferDatum As New clsKeyValuesObject("STR_FN_LIEFERDATUM", "Lieferdatum")
   Public Shared kvoArtikelname As New clsKeyValuesObject("STR_FN_ARTIKELNAME", "Artikelname")
   Public Shared kvoBestellteEinheiten As New clsKeyValuesObject("STR_FN_BESTELLEINHEIT", "BestellteEinheiten")
   Public Shared kvoEinzelpreis As New clsKeyValuesObject("STR_FN_EINZEILNEPREIS", "Einzelpreis")
   Public Shared kvoliefeinheit As New clsKeyValuesObject("STR_FN_LIEFEINHEIT", "Liefereinheit")
   Public Shared kvolagerbestand As New clsKeyValuesObject("STR_FN_LAGERBESTAND", "Lagebestand")
   Public Shared kvoIdBestellnr As New clsKeyValuesObject("STR_FN_ID_BESTELLNR", "ID_BestellNr")
   Public Shared kvoKundeCodeId As New clsKeyValuesObject("STR_FN_KUNDECODE_ID", "KundeCode_ID")
   Public Shared kvofahrtkosten As New clsKeyValuesObject("STR_FN_FAHRKOSTEN", "Fahrtkosten")
   Public Shared kvoEmpfänger As New clsKeyValuesObject("STR_FN_EMPFÄNGER", "Empfänger")
   Public Shared kvoStraße As New clsKeyValuesObject("STR_FN_STRASSE", "Straße")
   Public Shared kvoOrt As New clsKeyValuesObject("STR_FN_ORT", "Ort")
   Public Shared kvoPlz As New clsKeyValuesObject("STR_FN_PLZ", "Plz")
   Public Shared kvoBestimmungsland As New clsKeyValuesObject("STR_FN_BESTIMMUNGSLAND", "Bestimmungsland")
   Public Shared kvoFilename As New clsKeyValuesObject("STR_FILENAME", "FILENAME")
   Public Shared kvoBoschPartNo As New clsKeyValuesObject("STR_FN_BOSCHPARTNO", "BOSCHPARTNO")
   Public Shared kvoReportNo As New clsKeyValuesObject("STR_FN_REPORTNO", "ReportNo")
   Public Shared kvoFiling As New clsKeyValuesObject("STR_FN_FILING", "FILING")
   Public Shared kvoFilingType As New clsKeyValuesObject("STR_FN_FILINGTYPE", "FilingType")
   Public Shared kvoFilesize As New clsKeyValuesObject("STR_FN_FILESIZE", "Filesize")
   Public Shared kvoFileTimeStamp As New clsKeyValuesObject("STR_FN_FILETIMESTAMP", "FileTimeStamp")
   Public Shared kvoUserId As New clsKeyValuesObject("STR_FN_USERID", "UserId")
   Public Shared kvoDeleteTimeStamp As New clsKeyValuesObject("STR_FN_DELETETIMESTAMP", "DeleteTimeStamp")


   ' LOKALE KONSTANTEN VARIABLEN DEKLARIEREN:
   ' Spaltename der Datenbank.
   Public Const STR_FN_ANTWORT1 As String = "Antwort1"
   Public Const STR_FN_ANTWORT2 As String = "Antwort2"
   Public Const STR_FN_ANTWORT3 As String = "Antwort3"
   Public Const STR_FN_ARTIKELNAME As String = "Artikelname"
   Public Const STR_FN_BENUTZERNAME As String = "Benutzername"
   Public Const STR_FN_BESTELLTSDATUM As String = "Bestelldatum"
   Public Const STR_FN_BESTELLEINHEIT As String = "BestellteEinheiten"
   Public Const STR_FN_BESTIMMUNGSLAND As String = "Bestimmungsland"
   Public Const STR_FN_EMAIL As String = "Email"
   Public Const STR_FN_EMPFÄNGER As String = "Empfänger"
   Public Const STR_FN_EINZELPREIS As String = "Einzelpreis"
   Public Const STR_FN_FAHRKOSTEN As String = "Fahrtkosten"
   Public Const STR_FN_FIRMA As String = "Firma"
   Public Const STR_FN_FRAGE1 As String = "Frage1"
   Public Const STR_FN_FRAGE2 As String = "Frage2"
   Public Const STR_FN_FRAGE3 As String = "Frage3"
   Public Const STR_FN_GEBURTSDATUM As String = "Geburtsdatum"
   Public Const STR_FN_GESCHLECHTE As String = "Geschlecht"
   Public Const STR_FN_ID_BESTELLNR As String = "ID_BestellNr"
   Public Const STR_FN_ID_FIRMENNR As String = "ID_FirmenNR"
   Public Const STR_FN_ID_KUNDECODE As String = "ID_KundenCode"
   Public Const STR_FN_ID_USER As String = "ID_User"
   Public Const STR_FN_KONTAKTPERSON As String = "Kontaktperson"
   Public Const STR_FN_KUNDECODE_ID As String = "KundenCode_ID"
   Public Const STR_FN_LAND As String = "Land"
   Public Const STR_FN_LAGERBESTAND As String = "Lagerbestand"
   Public Const STR_FN_LIEFEINHEIT As String = "Liefereinheit"
   Public Const STR_FN_LIEFERDATUM As String = "Lieferdatum"
   Public Const STR_FN_LIEFERANTNR_ID As String = "LieferantNr_ID"
   Public Const STR_FN_NACHNAME As String = "Nachname"
   Public Const STR_FN_NUMMER As String = "Nummer"
   Public Const STR_FN_ORT As String = "Ort"
   Public Const STR_FN_POSITION As String = "Position"
   Public Const STR_FN_PERSONALNR_ID As String = "PersonalNr_ID"
   Public Const STR_FN_PASSWORT As String = "Passwort"
   Public Const STR_FN_PLZ As String = "Plz"
   Public Const STR_FN_STRASSE As String = "Straße"
   Public Const STR_FN_STADT As String = "Stadt"
   Public Const STR_FN_TELEFON As String = "Telefon"
   Public Const STR_FN_TELEFAX As String = "Telefax"
   Public Const STR_FN_VERSANDDATUM As String = "Versanddatum"
   Public Const STR_FN_VORNAME As String = "Vorname"

   ' Tabellename der Datenbank
   Public Const STR_TBL_ARTIKEL As String = "TBL_ARTIKEL"
   Public Const STR_TBL_BESTELLUNG As String = "TBL_BESTELLUNG"
   Public Const STR_TBL_BESTELLTSDETAIL As String = "TBL_BESTELLTSDETAIL"
   Public Const STR_TBL_KUNDE As String = "TBL_KUNDE"
   Public Const STR_TBL_LIEFERANT As String = "LIEFERANT"
   Public Const STR_TBL_LOGIN As String = "TBL_LOGIN"
   Public Const STR_TBL_PERSONAL As String = "TBL_PERSONAL"
   Public STR_TBL_REPORT As String = "TBL_REPORT"
   Public Const STR_TBL_USER As String = "TBL_USER"
   Public Const STR_TBL_VERSANDFIRMA As String = "TBL_VERSANDFIRMA"

   Public Const STR_TREEVIEW_KEY_DELIMETER = "/"
   Public Const STR_TREEVIEW_ID = "id"
   Public Const STR_TREEVIEW_VALUE = "value"
   Public Const STR_TREEVIEW_TYPE = "type"



End Class
