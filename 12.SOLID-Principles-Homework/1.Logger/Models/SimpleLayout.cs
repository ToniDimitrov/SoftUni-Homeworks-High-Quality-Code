using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Logger.Interfaces;

namespace _1.Logger.Models
{
    public class SimpleLayout : ILayout
    {
        public string FormatMessage(params string[] arguments)
        {
            string formattedMessage = DateTime.Now + " - " + arguments[0] + " - " + arguments[1];

            return formattedMessage;
        }
    }
}
