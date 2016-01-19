using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.Models.Behaviors
{
    internal class InflatedBehavior : Behavior
    {
        private const string inflatedBehaviorName = "Inflated";
        private const double inflatedBehaviorHealthEffect = 50;
        private const double inflatedBehaviorDamageEffect = 0;

        public InflatedBehavior()
            : base(inflatedBehaviorName, inflatedBehaviorHealthEffect, inflatedBehaviorDamageEffect)
        {
        }

        protected override void ApplyHealthEffect(IBlob blob)
        {
            if (this.Count == 0)
            {
                blob.Health += this.HealthEffect;
            }
            else if(this.Count >= 1)
            {
                blob.Health -= 10;

                if (blob.Health <= 0)
                {
                    blob.IsAlive = false;
                    blob.Health = -1;
                }
            }
        }

        protected override void ApplyDamageEffect(IBlob blob)
        {
            blob.Damage += this.DamageEffect;
        }
    }
}
