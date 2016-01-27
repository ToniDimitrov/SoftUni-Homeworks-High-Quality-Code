using _1.Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Logger.Models
{
    public abstract class Appender : IAppender
    {
        private ILayout layout;

        public Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public ILayout Layout
        {
            get { return this.layout; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "The layout cannot be null");
                }

                this.layout = value;
            }
        }
        
        public abstract void Append(params string[] arguments);
    }
}
