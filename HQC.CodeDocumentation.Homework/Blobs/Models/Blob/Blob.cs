using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.Models.Blob
{
    internal class Blob : IBlob
    {
        private double damage;
        private string name;
        public bool IsAlive { get; set; }

        public Blob(string name, int health, int damage, IBehavior behaviorType, IAttack attackType)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.BehaviorType = behaviorType;
            this.AttackType = attackType;
            this.IsAlive = true;
        }

        public Blob()
        {
        }

        public double Health { get; set; }


        public double Damage
        {
            get { return this.damage; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Damage must be positive");
                }
                this.damage = value;
            }
        }

        public void Update()
        {
            if (this.IsAlive)
            {
                this.BehaviorType.ApplyEffects(this);
            }
            else
            {
                this.IsAlive = false;
            }
        }

        public void Attack(IBlob targetBlob)
        {
            if (this.IsAlive)
            {
                targetBlob.Health -= this.AttackType.AttackDamage(this);
                this.AttackType.ApplyAttackEffects(this);
                if (targetBlob.Health <= 0)
                {
                    targetBlob.Health = 0;
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name must be non-empty");
                }
                this.name = value;
            }
        }

        public IBehavior BehaviorType { get; private set; }

        public IAttack AttackType { get; private set; }

        public override string ToString()
        {
            return this.IsAlive ? string.Format("Blob {0}: {1} HP, {2} Damage", this.Name, Math.Ceiling(this.Health), Math.Ceiling(this.Damage)) : string.Format("Blob {0} KILLED", this.name);
        }
    }
}
