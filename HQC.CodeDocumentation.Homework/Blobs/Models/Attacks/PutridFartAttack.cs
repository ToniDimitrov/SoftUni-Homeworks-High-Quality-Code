using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.Models.Attacks
{
    class PutridFartAttack: Attack
    {
        private const string putridFartName = "PutridFart";
        private const int putridFartHealthEffect = 0;
        private const int putridFartAttackDamageFactor = 1;

        public PutridFartAttack()
            : base(putridFartName, putridFartHealthEffect, putridFartAttackDamageFactor)
        {
        }

        protected override void ApplyHealthEffect(IBlob blob)
        {
            blob.Health += this.HealthEffect;
        }

    }
}
