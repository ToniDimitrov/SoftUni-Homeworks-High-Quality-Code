using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines objects that have the ability to attack and reduce other objects' healths
    /// </summary>
    public interface IAttacker
    {
        //Amount of damage attack does
        double Damage { get; set; }

        //Attack action
        void Attack(IBlob targetBlob);
    }
}
