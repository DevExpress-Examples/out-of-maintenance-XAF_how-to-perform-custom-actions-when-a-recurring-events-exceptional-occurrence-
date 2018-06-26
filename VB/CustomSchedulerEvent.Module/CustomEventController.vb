Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Scheduler
Imports DevExpress.Persistent.Validation

Namespace CustomSchedulerEvent.Module
    Partial Public Class CustomEventController
        Inherits ViewController

        Private schedulerEditor As SchedulerListEditorBase

        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
            Me.TargetViewType = ViewType.ListView
        End Sub

        Private Sub CustomEventController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
            schedulerEditor = TryCast(CType(View, ListView).Editor, SchedulerListEditorBase)
            If schedulerEditor IsNot Nothing Then
                AddHandler schedulerEditor.ExceptionEventCreated, AddressOf schedulerEditor_ExceptionEventCreated
            End If
        End Sub

        Private Sub CustomEventController_Deactivated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Deactivated
            If schedulerEditor IsNot Nothing Then
                RemoveHandler schedulerEditor.ExceptionEventCreated, AddressOf schedulerEditor_ExceptionEventCreated
            End If
        End Sub

        Private Sub schedulerEditor_ExceptionEventCreated(ByVal sender As Object, ByVal e As ExceptionEventCreatedEventArgs)
            If TypeOf e.PatternEvent Is ExtendedEvent AndAlso TypeOf e.ExceptionEvent Is ExtendedEvent Then
                CType(e.ExceptionEvent, ExtendedEvent).Notes = CType(e.PatternEvent, ExtendedEvent).Notes
                Validator.RuleSet.Validate(ObjectSpace, e.ExceptionEvent, "SchedulerValidation")
            End If
        End Sub
    End Class
End Namespace
