using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Blobs.Core.Interfaces;
using Blobs.Models.Attacks;
using Blobs.Models.Interfaces;

namespace Blobs.Core.Factories
{
    class AttackFactory:IAttackFactory
    {
        public IAttack CreateAttack(string name)
        {
            IAttack attack;

            switch (name)
            {
                case "Blobplode":
                {
                    attack = new BlobplodeAttack();
                    break;
                }
                case "PutridFart":
                {
                    attack = new PutridFartAttack();
                    break;
                }
                default:
                {
                    throw new ArgumentException("Unknown attack type");
                }
            }

            return attack;
        }
    }
}
