﻿using System;

namespace Simple.MailServer.Logging
{
    public class MailServerDebugLogger : IMailServerLogger
    {
        public MailServerLogLevel LogLevel { get; set; }

        public MailServerDebugLogger(MailServerLogLevel logLevel)
        {
            LogLevel = logLevel;
        }

        public void Debug(string message)
        {
            if (LogLevel < MailServerLogLevel.Debug) return;
            
            System.Diagnostics.Debug.WriteLine("{0}: DEBUG - {1}", GetTimestamp(), message);
        }

        public void Info(string message)
        {
            if (LogLevel < MailServerLogLevel.Info) return;

            System.Diagnostics.Debug.WriteLine("{0}: INFO - {1}", GetTimestamp(), message);
        }

        public void Warn(string message)
        {
            if (LogLevel < MailServerLogLevel.Warn) return;

            System.Diagnostics.Debug.WriteLine("{0}: WARN - {1}", GetTimestamp(), message);
        }

        public void Error(string message)
        {
            if (LogLevel < MailServerLogLevel.Error) return;

            System.Diagnostics.Debug.WriteLine("{0}: ERROR - {1}", GetTimestamp(), message);
        }

        public void Error(Exception ex)
        {
            if (LogLevel < MailServerLogLevel.Error) return;

            System.Diagnostics.Debug.WriteLine("{0}: ERROR - Exception: {1}", GetTimestamp(), ex);
        }

        public void Error(Exception ex, string message)
        {
            if (LogLevel < MailServerLogLevel.Error) return;

            System.Diagnostics.Debug.WriteLine("{0}: ERROR - {1}, Exception: {2}", GetTimestamp(), message, ex);
        }

        private string GetTimestamp()
        {
            return DateTime.UtcNow.ToString("u");
        }
    }
}