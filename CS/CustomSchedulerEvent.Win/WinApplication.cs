using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace CustomSchedulerEvent.Win {
    public partial class CustomSchedulerEventWindowsFormsApplication : WinApplication {
        public CustomSchedulerEventWindowsFormsApplication() {
            InitializeComponent();
        }

        private void CustomSchedulerEventWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
        }
    }
}
