using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace CustomSchedulerEvent.Module.Win {
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class CustomSchedulerEventWindowsFormsModule : ModuleBase {
        public CustomSchedulerEventWindowsFormsModule() {
            InitializeComponent();
        }
    }
}
