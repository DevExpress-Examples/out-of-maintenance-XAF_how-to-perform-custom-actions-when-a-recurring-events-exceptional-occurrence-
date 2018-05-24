using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace CustomSchedulerEvent.Module {
    [DefaultClassOptions]
    public class ExtendedEvent : Event {
        public ExtendedEvent(Session session) : base(session) { }

        public string Notes {
            get { return GetPropertyValue<string>("Notes"); }
            set { SetPropertyValue<string>("Notes", value); }
        }
    }

}
