Imports System.Data.SqlClient
Imports GeneratorClassLibrary

Public Class frmRechnungBericht

	Dim dtCurrentData As DataTable
	Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
      Dim dtpDateFrom As New DateTimePicker
      Dim dtpDateTo As New DateTimePicker
      ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
      dtpDateFrom.Value = "01/07/1996"
      dtpDateTo.Value = "31/07/1996"
      Call GeneratorClassLibrary.clsTreeViewManager.PopulateTreeView(tvOrder, dtpDateFrom, dtpDateTo)

   End Sub

   Private Sub tvOrder_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvOrder.AfterSelect
      Call GeneratorClassLibrary.clsPopulateDatagridView.PopulateGridView(dgvCustomerInfo, tvOrder)
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Dim iCountLines As Integer
      Dim iCountColumns As Integer
      Dim iCounterLine As Integer
      Dim iCounterColumn As Integer
      Dim iFlag As Integer

      iCountLines = dgvCustomerInfo.Rows.Count
      iCountColumns = dgvCustomerInfo.Columns.Count

      Do While iCounterLine <= iCountLines
         If dgvCustomerInfo.Rows(iCounterLine).Cells(iCounterColumn).Value.ToString = "" Then
            If iFlag = 1 Then
               iCounterColumn = 0
            End If
            iFlag = 0
            iCounterColumn = iCounterColumn + 1

            If iCounterColumn = iCountColumns Then
               dgvCustomerInfo.Rows.RemoveAt(iCounterLine)
            End If
         Else
            iCounterLine = iCounterLine + 1
            iFlag = 1
         End If

      Loop
   End Sub


	Public Sub Undo()
		Dim uaAction As ClsUndoRedoAction
		uaAction = New ClsUndoRedoAction
		If uaAction.UndoStack.Count = 0 Then
			Exit Sub
		End If
		uaAction.UndoStack.Pop()

		Select Case uaAction.Change
			Case ClsUndoRedoAction.ChangeMode.Delete
				Call InsertRow(uaAction)
				Exit Select
			Case ClsUndoRedoAction.ChangeMode.ModifyCell
				Call UpdateCell(uaAction)
				Exit Select
			Case Else
				Throw New Exception("unknown undo action change" + uaAction.Change.ToString)

		End Select
		End Sub


	Public Sub Redo()
		Dim uaAction As ClsUndoRedoAction

		uaAction = New ClsUndoRedoAction

		If uaAction.UndoStack.Count = 0 Then
			Exit Sub
		End If
		uaAction.UndoStack.Pop()

		Select Case uaAction.Change
			Case ClsUndoRedoAction.ChangeMode.Delete
				Call InsertRow(uaAction)
			Case ClsUndoRedoAction.ChangeMode.Add
				Call DeleteRow(uaAction)
			Case ClsUndoRedoAction.ChangeMode.ModifyCell
				Call UpdateCell(uaAction)

			Case Else
				Throw New Exception("unknown undo action change" + uaAction.Change.ToString)
		End Select


	End Sub

	Private Sub UpdateCell(uaAction As ClsUndoRedoAction)
			Dim iColumnIndex As Integer
			Dim iRowIndex As Integer

			Dim objPreviousCellValue As Object
			If uaAction.Arguments Is Nothing OrElse uaAction.Arguments.Length < 3 Then
				Throw New InvalidOperationException("Invalid arguments")
			End If

			objPreviousCellValue = uaAction.Arguments(0)
			iRowIndex = CInt(uaAction.Arguments(1))
			iColumnIndex = CInt(uaAction.Arguments(2))

		Me.dgvCustomerInfo(iColumnIndex, iRowIndex).Value = objPreviousCellValue
	End Sub

	Public Sub InsertRow(uaAction As ClsUndoRedoAction)
		Dim iRowIndex As Integer

		If uaAction.Arguments Is Nothing OrElse uaAction.Arguments.Length < 1 Then
			Throw New InvalidOperationException("Invalid arguments")
		End If

		iRowIndex = CInt(uaAction.Arguments(0))
		Me.dtCurrentData.Rows.InsertAt(CType(uaAction.TrackObject, DataRow), iRowIndex)
	End Sub

	Private Sub DeleteRow(uaAction As ClsUndoRedoAction)
			Dim iRowIndex As Integer

			If uaAction.Arguments Is Nothing OrElse uaAction.Arguments.Length < 1 Then
				Throw New InvalidOperationException("Invalid arguments")
			End If

			iRowIndex = CInt(uaAction.Arguments(0))

			Me.dtCurrentData.Rows.RemoveAt(iRowIndex)
		End Sub

	Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
		Dim uaAction As ClsUndoRedoAction
		uaAction = New ClsUndoRedoAction
		Call Undo()
		uaAction.RedoStack.Push(uaAction)
	End Sub

	Private Sub btnRedo_Click(sender As Object, e As EventArgs) Handles btnRedo.Click
		Dim uaAction As ClsUndoRedoAction
		uaAction = New ClsUndoRedoAction
		Call Redo()
		uaAction.UndoStack.Push(uaAction)
	End Sub
End Class

