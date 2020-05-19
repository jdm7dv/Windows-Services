using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace SimpleWindowsService
{
    public partial class SimpleService : ServiceBase
    {
        public SimpleService()
        {
            InitializeComponent();

            // Initialize eventLogSimple 
            if (!System.Diagnostics.EventLog.SourceExists("SimpleSource")) 
                System.Diagnostics.EventLog.CreateEventSource("SimpleSource", "SimpleLog");
            eventLogSimple.Source = "SimpleSource";
            eventLogSimple.Log = "SimpleLog";

        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            eventLogSimple.WriteEntry("Hello world from Simple Service!");
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            eventLogSimple.WriteEntry("Simple Service stopped!");
        }
    }
}
