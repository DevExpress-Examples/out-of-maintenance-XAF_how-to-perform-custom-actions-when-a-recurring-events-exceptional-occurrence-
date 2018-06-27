Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.Xpo

Namespace CustomSchedulerEvent.Module
    <DefaultClassOptions> _
    Public Class ExtendedEvent
        Inherits [Event]

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        <RuleRequiredField("", "SchedulerValidation")> _
        Public Property Notes() As String
            Get
                Return GetPropertyValue(Of String)("Notes")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Notes", value)
            End Set
        End Property
        Protected Overrides Sub OnSaving()
            MyBase.OnSaving()
            Validator.RuleSet.Validate(XPObjectSpace.FindObjectSpaceByObject(Me), Me, "SchedulerValidation")
        End Sub
    End Class

End Namespace
