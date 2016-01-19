using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines all classes of type Behavior
    /// </summary>
    public interface IBehavior: IHealthEffect, IDamageEffect
    {
        //Name of behavior
        string Name { get; }

        //Keeps track of the state of the behavior
        bool IsTriggered { get; }

        //Applies the effects of the behavior on the health of the blobs
        void ApplyEffects(IBlob blob);
    }
}
