using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines classes that have the ability to affect blobs' health
    /// </summary>
    public interface IHealthEffect
    {
        //The effect that the object has on blobs' health
        double HealthEffect { get; }
    }
}
