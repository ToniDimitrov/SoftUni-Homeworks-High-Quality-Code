using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines all classes of type Attack
    /// </summary>
    public interface IAttack : IHealthEffect
    {
        //Name of attack
        string Name { get; }

        //The amount of damage the attack is going to inflict
        double AttackDamage(IBlob blob);

        //The effect that the attack has on the blobs' damage
        double AttackDamageFactor { get; }

        //Applies effects of attack on the health of the blobs
        void ApplyAttackEffects(IBlob blob);

    }
}
