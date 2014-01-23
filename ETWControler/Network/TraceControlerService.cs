﻿using Microsoft.Diagnostics.Tracing.Session;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ETWControler
{
    /// <summary>
    /// Implemenation class of WCF ITraceControlerService
    /// </summary>
    public class TraceControlerService : ITraceControlerService
    {
        string ThisExeStartDirectory;

        /// <summary>
        /// Used by unit tests
        /// </summary>
        public void DummyMethod()
        {
         //   Thread.Sleep(10 * 60 * 1000); // wait 10 minutes
         //   Console.WriteLine("Hi Server was reached");
        }

        /// <summary>
        /// Execute a WPR command with specified command line args. Used e.g. to start/stop/cancel tracing. 
        /// Commands can take a long time to execute. Currently the WCF service it set to time out after 10 minutes.
        /// </summary>
        /// <param name="wpaArgs">WPR command line args</param>
        /// <returns>stdout and stderr of executed command when it has finished.</returns>
        public Tuple<int,string> ExecuteWPRCommand(string wpaArgs)
        {
            RedirectedProcess proc = new RedirectedProcess("wpr.exe", Environment.ExpandEnvironmentVariables(wpaArgs));
            var lret = proc.Start(ThisExeStartDirectory);
            return lret;
        }

        /// <summary>
        /// Get all active ETW sessions
        /// </summary>
        /// <returns>string array of with the trace session names</returns>
        public string[] GetTraceSessions()
        {
            return TraceEventSession.GetActiveSessionNames().ToArray();
        }

        public TraceControlerService()
        {
            ThisExeStartDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        }
    }
}
