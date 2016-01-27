using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Logger.Interfaces;

namespace _1.Logger.Models
{
    public class FileAppender : Appender
    {
        private string fileName;
       
        public FileAppender(ILayout layout) : base(layout)
        {

        }

        public string File
        {
            get { return this.fileName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The file name must be non-null and non-empty");
                }

                this.fileName = value;
            }
        }

        public override void Append(params string[] arguments)
        {
            ReportLevel reportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), arguments[0]);
            if (this.ReportLevel <= reportLevel)
            {
                string logToAppend = this.Layout.FormatMessage(arguments);
                using (StreamWriter writer = new StreamWriter(this.File, true))
                {
                    writer.WriteLine(logToAppend);
                }
            }
        }
    }
}
