Imports GeneratorClassLibrary.clsListView


Public Class ucDbExplorer
	Private Sub lvFileReferences_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvFileReferences.SelectedIndexChanged

		initializeRecycleListView(lvFileReferences)

	End Sub
End Class
