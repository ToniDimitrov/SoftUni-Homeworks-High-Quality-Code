using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines all classes that can affect the damage of blobs
    /// </summary>
    public interface IDamageEffect
    {
        //The effect that the object has on the blobs' damage
        double DamageEffect { get; }
    }
}
