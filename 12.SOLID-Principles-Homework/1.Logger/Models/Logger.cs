using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Logger.Interfaces;

namespace _1.Logger.Models
{
    public class Logger : ILogger
    {
        private IList<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>() {};

            AddAppenders(appenders);
        }

        public void AddAppenders(IList<IAppender> appenders)
        {
            foreach (var appender in appenders)
            {
                this.Appenders.Add(appender);
            }
        }

        public IList<IAppender> Appenders
        {
            get { return this.appenders; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "The appender cannot be null");
                }

                this.appenders = value;
            }
        }

        public void Info(string message)
        {
            this.AppendWithAllAppenders(message,ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.AppendWithAllAppenders(message, ReportLevel.Warn);
        }

        public void Error(string message)
        {
            this.AppendWithAllAppenders(message, ReportLevel.Error);
        }

        public void Critical(string message)
        {
            this.AppendWithAllAppenders(message, ReportLevel.Critical);
        }

        public void Fatal(string message)
        {
            this.AppendWithAllAppenders(message, ReportLevel.Fatal);
        }

        private void AppendWithAllAppenders(string message, ReportLevel reportLevel)
        {
            string reportLevelString = reportLevel.ToString();
            foreach (var appender in Appenders)
            {
                appender.Append(reportLevelString, message);
            }
        }
    }
}
