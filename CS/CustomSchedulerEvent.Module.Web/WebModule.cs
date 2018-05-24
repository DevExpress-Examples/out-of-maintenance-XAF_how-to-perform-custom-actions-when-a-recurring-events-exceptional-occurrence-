using System;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace CustomSchedulerEvent.Module.Web {
    [ToolboxItemFilter("Xaf.Platform.Web")]
    public sealed partial class CustomSchedulerEventAspNetModule : ModuleBase {
        public CustomSchedulerEventAspNetModule() {
            InitializeComponent();
        }
    }
}
