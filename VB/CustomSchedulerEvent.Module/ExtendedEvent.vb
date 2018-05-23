Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace CustomSchedulerEvent.Module
	<DefaultClassOptions> _
	Public Class ExtendedEvent
        Inherits DevExpress.Persistent.BaseImpl.Event
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Property Notes() As String
			Get
                Return GetPropertyValue(Of String)("Notes")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Notes", value)
			End Set
		End Property
	End Class

End Namespace
