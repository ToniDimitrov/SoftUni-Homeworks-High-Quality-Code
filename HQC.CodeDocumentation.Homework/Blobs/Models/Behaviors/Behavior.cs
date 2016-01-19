using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.Models.Behaviors
{
    internal abstract class Behavior : IBehavior
    {
        private string name;
        private double healthEffect;
        private double damageEffect;
        private double initialBlobHealth=-1;
        private int countTriggered = 0;

        public bool IsTriggered { get; private set; }

        protected Behavior(string name, double healthEffect, double attackEffect)
        {
            this.Name = name;
            this.HealthEffect = healthEffect;
            this.DamageEffect = attackEffect;
            this.Count = 0;
            this.IsTriggered = false;
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

        public int Count { get; private set; }

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

        public double DamageEffect
        {
            get { return this.damageEffect; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Damage effect must non-negative");
                }
                this.damageEffect = value;
            }
        }

        protected abstract void ApplyHealthEffect(IBlob blob);

        protected abstract void ApplyDamageEffect(IBlob blob);

        public void ApplyEffects(IBlob blob)
        {
            if (this.initialBlobHealth == -1)
            {
                this.initialBlobHealth = blob.Health;
            }

            if (blob.Health <= (int)this.initialBlobHealth/2)
            {
                IsTriggered = true;
                this.countTriggered++;
            }

            if (IsTriggered)
            {
                ApplyHealthEffect(blob);
                ApplyDamageEffect(blob);
                this.Count++;
            }

        }
    }
}
