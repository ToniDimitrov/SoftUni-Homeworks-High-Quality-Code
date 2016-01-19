using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines classes that have the ability to print output
    /// </summary>
    interface IOutputWriter
    {
        //Prints output
        void Print(string message);
    }
}
