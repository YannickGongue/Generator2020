
Imports GeneratorClassLibrary.clsConstant
Public Class clsListView

	Shared Sub initializeRecycleListView(ByRef lvFileReferenceFiles As Windows.Forms.ListView)
		With lvFileReferenceFiles
			' Inhalt löschen 
			.Items.Clear()
			' Alte Überschriften löschen
			.Columns.Clear()
			' Drag & Drop auf dieser Ansicht nicht möglich. 
			.AllowDrop = False
			' Spalten einfügen.
			.Columns.Add(kvoFilename.Value, 150, Windows.Forms.HorizontalAlignment.Left)
			.Columns.Add(kvoBoschPartNo.Value, 100, Windows.Forms.HorizontalAlignment.Left)
			.Columns.Add(kvoReportNo.Value, 50, Windows.Forms.HorizontalAlignment.Left)
			.Columns.Add(kvoFiling.Value, 100, Windows.Forms.HorizontalAlignment.Left)
			.Columns.Add(kvoFilingType.Value, 100, Windows.Forms.HorizontalAlignment.Left)
			.Columns.Add(kvoFilesize.Value, 90, Windows.Forms.HorizontalAlignment.Left)
			.Columns.Add(kvoFileTimeStamp.Value, 160, Windows.Forms.HorizontalAlignment.Left)
			.Columns.Add(kvoUserId.Value, 90, Windows.Forms.HorizontalAlignment.Left)
			.Columns.Add(kvoDeleteTimeStamp.Value, 160, Windows.Forms.HorizontalAlignment.Left)

		End With
	End Sub

End Class
