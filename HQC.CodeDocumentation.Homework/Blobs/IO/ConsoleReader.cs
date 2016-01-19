using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.IO
{
    class ConsoleReader:IInputReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}
