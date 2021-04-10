Imports System.Collections

Public Class ClsUndoRedoAction

	Private cmChange As ChangeMode
	Private objTrackObject As Object
	Private objArguments As Object()


	Public UndoStack As Stack(Of ClsUndoRedoAction)
	Public RedoStack As Stack(Of ClsUndoRedoAction)

	Public Enum ChangeMode
		None
		Add
		Delete
		ModifyCell
	End Enum

	Public Property TrackObject() As Object
		Get
			Return objTrackObject
		End Get
		Set(value As Object)
			objTrackObject = value
		End Set
	End Property

	Public Property Change() As ChangeMode
		Get
			Return cmChange
		End Get
		Set(value As ChangeMode)
			cmChange = value
		End Set
	End Property

	Public Property Arguments() As Object
		Get
			Return objArguments
		End Get
		Set(value As Object)
			objArguments = value
		End Set
	End Property


	Public Sub New()
		Me.UndoStack = New Stack(Of ClsUndoRedoAction)
		Me.RedoStack = New Stack(Of ClsUndoRedoAction)
	End Sub

	Public Sub New(objTrackObject As Object, cmChange As ChangeMode, ParamArray objArguments As Object())
		Me.TrackObject = objTrackObject
		Me.Change = cmChange
		Me.Arguments = objArguments
	End Sub

	Public Sub Push(uaAction As ClsUndoRedoAction)
		RedoStack.Clear()
		UndoStack.Push(uaAction)
		'RedoStack.Push(uaAction)
	End Sub
End Class
