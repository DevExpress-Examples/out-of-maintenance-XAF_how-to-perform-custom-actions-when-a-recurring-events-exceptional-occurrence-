Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace CustomSchedulerEvent.Web
    Partial Public Class CustomSchedulerEventAspNetApplication
        Inherits WebApplication

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProviderThreadSafe(args.ConnectionString, args.Connection)
        End Sub
        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
        Private module3 As CustomSchedulerEvent.Module.CustomSchedulerEventModule
        Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
        Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private schedulerAspNetModule1 As DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule
        Private schedulerModuleBase1 As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
        Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub CustomSchedulerEventAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles Me.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub

        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
            Me.module3 = New CustomSchedulerEvent.Module.CustomSchedulerEventModule()
            Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
            Me.schedulerAspNetModule1 = New DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule()
            Me.schedulerModuleBase1 = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' module5
            ' 
            Me.module5.AllowValidationDetailsAccess = True
            ' 
            ' CustomSchedulerEventAspNetApplication
            ' 
            Me.ApplicationName = "CustomSchedulerEvent"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module6)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module5)
            Me.Modules.Add(Me.securityModule1)
            Me.Modules.Add(Me.schedulerModuleBase1)
            Me.Modules.Add(Me.schedulerAspNetModule1)
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace
