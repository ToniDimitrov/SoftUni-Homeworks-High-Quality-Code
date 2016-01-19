using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines objects that can 'die'
    /// </summary>
    public interface IDestroyable
    {
        //Health of the object
        double Health { get; set; }

        //State of the object
        bool IsAlive { get; set; }
    }
}
