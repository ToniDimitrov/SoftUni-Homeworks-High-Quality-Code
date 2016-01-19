using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.Core.Interfaces
{
    /// <summary>
    /// Defines classes that can create objects of type Blob
    /// </summary>
    interface IBlobFactory
    {
        //Creates blob object with given parameters
        IBlob CreateBlob(string name, int health, int damage, IBehavior behavior, IAttack attack);
    }
}
