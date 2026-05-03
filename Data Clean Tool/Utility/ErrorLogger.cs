using System;
using System.Diagnostics;

namespace Data_Clean_Tool.Utility
{
    public static class ErrorLogger
    {
        private const string Source = "DataCleanTool";
        private const string LogName = "Application";

        public static void LogError(Exception ex, string context)
        {
            try
            {
                if (!EventLog.SourceExists(Source))
                {
                    EventLog.CreateEventSource(Source, LogName);
                }

                string message =
                    $"{context}{Environment.NewLine}" +
                    $"{ex.GetType().FullName}: {ex.Message}{Environment.NewLine}" +
                    $"{ex.StackTrace}";

                EventLog.WriteEntry(Source, message, EventLogEntryType.Error);
            }
            catch
            {
                // Never let logging crash the app
            }
        }
    }
}