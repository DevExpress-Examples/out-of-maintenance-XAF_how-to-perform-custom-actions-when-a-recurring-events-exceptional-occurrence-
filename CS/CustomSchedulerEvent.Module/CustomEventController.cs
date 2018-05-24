using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Scheduler;
using DevExpress.Persistent.Validation;

namespace CustomSchedulerEvent.Module {
    public partial class CustomEventController : ViewController {
        private SchedulerListEditorBase schedulerEditor;

        public CustomEventController() {
            InitializeComponent();
            RegisterActions(components);
            this.TargetViewType = ViewType.ListView;
        }

        private void CustomEventController_Activated(object sender, EventArgs e) {
            schedulerEditor = ((ListView)View).Editor as SchedulerListEditorBase;
            if (schedulerEditor != null) {
                schedulerEditor.ExceptionEventCreated +=
                    new EventHandler<ExceptionEventCreatedEventArgs>(schedulerEditor_ExceptionEventCreated);
            }
        }

        private void CustomEventController_Deactivated(object sender, EventArgs e) {
            if (schedulerEditor != null) {
                schedulerEditor.ExceptionEventCreated -=
                    new EventHandler<ExceptionEventCreatedEventArgs>(schedulerEditor_ExceptionEventCreated);
            }
        }

        void schedulerEditor_ExceptionEventCreated(object sender, ExceptionEventCreatedEventArgs e) {
            if (e.PatternEvent is ExtendedEvent && e.ExceptionEvent is ExtendedEvent) {
                ((ExtendedEvent)e.ExceptionEvent).Notes = ((ExtendedEvent)e.PatternEvent).Notes;
                Validator.RuleSet.Validate(ObjectSpace, e.ExceptionEvent, "SchedulerValidation");
            }
        }
    }
}
