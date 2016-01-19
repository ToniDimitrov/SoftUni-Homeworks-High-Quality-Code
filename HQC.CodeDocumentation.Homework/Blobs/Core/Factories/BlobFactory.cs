using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Core.Interfaces;
using Blobs.Models.Blob;
using Blobs.Models.Interfaces;

namespace Blobs.Core
{
    class BlobFactory:IBlobFactory
    {
        public IBlob CreateBlob(string name, int health, int damage, IBehavior behavior, IAttack attack)
        {
            Blob blob = new Blob(name,health,damage,behavior,attack);

            return blob;
        }
    }
}
