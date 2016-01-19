using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.Models.Attacks
{
    abstract class Attack: IAttack
    {
        private string name;
        private double attackDamageFactor;
        private double healthEffect;

        protected Attack(string name, int healthEffect, double attackDamageFactor)
        {
            this.Name = name;
            this.HealthEffect = healthEffect;
            this.AttackDamageFactor = attackDamageFactor;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name must be non-empty");
                }
                this.name = value;
            }
        }

        public double AttackDamage(IBlob blob)
        {
            double attackDamage = blob.Damage*this.AttackDamageFactor;
            return attackDamage;
        }

        public double AttackDamageFactor
        {
            get
            {
                return this.attackDamageFactor;
            }
            private set
            {
                if (value <= 0)
                {
                    throw  new ArgumentOutOfRangeException("Attack damage factor must be positive");
                }

                this.attackDamageFactor = value;
            }
        }

        public double HealthEffect
        {
            get { return this.healthEffect; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health effect must be non-negative");
                }
                this.healthEffect = value;
            }
        }
            
        protected abstract void ApplyHealthEffect(IBlob blob);

        public void ApplyAttackEffects(IBlob blob)
        {
            ApplyHealthEffect(blob);
        }

    }
}
