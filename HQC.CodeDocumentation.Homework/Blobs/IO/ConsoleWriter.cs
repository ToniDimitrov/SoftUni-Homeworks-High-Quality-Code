using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.IO
{
    class ConsoleWriter:IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
