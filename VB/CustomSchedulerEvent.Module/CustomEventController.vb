Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Scheduler

Namespace CustomSchedulerEvent.Module
	Partial Public Class CustomEventController
		Inherits ViewController
		Private schedulerEditor As SchedulerListEditorBase

		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			Me.TargetViewType = ViewType.ListView
		End Sub

		Private Sub CustomEventController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
			schedulerEditor = TryCast((CType(View, ListView)).Editor, SchedulerListEditorBase)
			If schedulerEditor IsNot Nothing Then
				AddHandler schedulerEditor.ExceptionEventCreated, AddressOf schedulerEditor_ExceptionEventCreated
			End If
		End Sub

		Private Sub CustomEventController_Deactivating(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivating
			If schedulerEditor IsNot Nothing Then
				RemoveHandler schedulerEditor.ExceptionEventCreated, AddressOf schedulerEditor_ExceptionEventCreated
			End If
		End Sub

		Private Sub schedulerEditor_ExceptionEventCreated(ByVal sender As Object, ByVal e As ExceptionEventCreatedEventArgs)
			If TypeOf e.PatternEvent Is ExtendedEvent AndAlso TypeOf e.ExceptionEvent Is ExtendedEvent Then
				CType(e.ExceptionEvent, ExtendedEvent).Notes = (CType(e.PatternEvent, ExtendedEvent)).Notes
			End If
		End Sub
	End Class
End Namespace
