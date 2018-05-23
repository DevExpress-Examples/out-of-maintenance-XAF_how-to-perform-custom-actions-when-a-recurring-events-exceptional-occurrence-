Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.ExpressApp

Namespace CustomSchedulerEvent.Module.Web
	<ToolboxItemFilter("Xaf.Platform.Web")> _
	Public NotInheritable Partial Class CustomSchedulerEventAspNetModule
		Inherits ModuleBase
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
