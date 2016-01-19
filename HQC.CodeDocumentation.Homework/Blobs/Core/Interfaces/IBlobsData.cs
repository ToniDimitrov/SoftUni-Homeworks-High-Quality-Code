using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.Blob;
using Blobs.Models.Interfaces;

namespace Blobs.Core.Interfaces
{
    /// <summary>
    /// Defines classes that have the ability to store data about blobs in the game
    /// </summary>
    interface IBlobsData
    {
        //Collection keeping all blobs in the game
        ICollection<IBlob> Blobs { get; set; }

        //Adds blob to the collection of blobs
        void AddBlob(IBlob blob);
    }
}
