using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Blob;
using Blobs.Models.Interfaces;

namespace Blobs.Core.Interfaces
{
    public class BlobsData:IBlobsData
    {
        public ICollection<IBlob> Blobs { get; set; }

        public BlobsData()
        {
            this.Blobs = new List<IBlob>();
        }

        public void AddBlob(IBlob blob)
        {
            if (blob == null)
            {
                throw new ArgumentNullException("Blob cannot be null");
            }

            this.Blobs.Add(blob);
        }
    }
}
