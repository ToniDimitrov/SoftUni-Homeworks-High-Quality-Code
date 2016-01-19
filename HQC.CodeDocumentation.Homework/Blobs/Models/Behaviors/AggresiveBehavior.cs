using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.Models.Behaviors
{
    internal class AggresiveBehavior : Behavior
    {
        private const string AggressiveBehaviorName = "Aggressive";
        private const double AggressiveBehaviorHealthEffect = 0;
        private const double AggressiveBehaviorAttackEffect = 2;

        private double InitialDamage = -1;

        public AggresiveBehavior()
            : base(AggressiveBehaviorName, AggressiveBehaviorHealthEffect, AggressiveBehaviorAttackEffect)
        {
        }

        protected override void ApplyHealthEffect(IBlob blob)
        {
            blob.Health += this.HealthEffect;
        }

        protected override void ApplyDamageEffect(IBlob blob)
        {
            if (InitialDamage == -1)
            {
                this.InitialDamage = blob.Damage;
            }

            if (this.Count == 0)
            {
                blob.Damage *= this.DamageEffect;
            }

            else if (blob.Damage > this.InitialDamage)
            {
                blob.Damage -= 5;
            }
        }
    }
}