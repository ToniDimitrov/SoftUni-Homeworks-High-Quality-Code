using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines all classes of type Blob
    /// </summary>
    public interface IBlob: IDestroyable, IAttacker,IUpdateable
    {
        //Name of the blob
        string Name { get; set; }

        //Keeps the behavior that the blob has
        IBehavior BehaviorType { get; }

        //Keeps the attack type that the blob has
        IAttack AttackType { get; }
    }
}
