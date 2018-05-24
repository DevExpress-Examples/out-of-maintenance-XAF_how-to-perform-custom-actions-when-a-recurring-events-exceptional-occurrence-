using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Xpo;

namespace CustomSchedulerEvent.Module {
    [DefaultClassOptions]
    public class ExtendedEvent : Event {
        public ExtendedEvent(Session session) : base(session) { }
        [RuleRequiredField("", "SchedulerValidation")]
        public string Notes {
            get { return GetPropertyValue<string>("Notes"); }
            set { SetPropertyValue<string>("Notes", value); }
        }
        protected override void OnSaving() {
            base.OnSaving();
            Validator.RuleSet.Validate(XPObjectSpace.FindObjectSpaceByObject(this), this, "SchedulerValidation");
        }
    }

}
