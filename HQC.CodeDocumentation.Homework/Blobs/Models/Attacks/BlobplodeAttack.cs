using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Interfaces;

namespace Blobs.Models.Attacks
{
    class BlobplodeAttack:Attack
    {
       
        private const string blobplodeName = "Blobplode";
        private const int blobplodeHealthEffect = 0;
        private const int blobplodeAttackDamageFactor = 2;

        public BlobplodeAttack()
            : base(blobplodeName, blobplodeHealthEffect, blobplodeAttackDamageFactor)
        {
        }

        protected override void ApplyHealthEffect(IBlob blob)
        {
            if (blob.Health/2 >= 1)
            {
                blob.Health /= 2;
            }
            else blob.Health = 1;
        }
    }
}
