using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Logger.Interfaces;

namespace _1.Logger.Models
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {

        }

        public override void Append(params string[] arguments)
        {
            ReportLevel reportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), arguments[0]);
            if(this.ReportLevel <= reportLevel)
            {
                string logToAppend = this.Layout.FormatMessage(arguments);

                Console.WriteLine(logToAppend);
            }
        }
    }
}