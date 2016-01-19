using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.Core.Interfaces
{
    /// <summary>
    /// Defines classes that can create objects of type Attack
    /// </summary>
    interface IAttackFactory
    {
        //Creates attack object with given name
        IAttack CreateAttack(string name);
    }
}
