using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines classes that can change their characteristics over time
    /// </summary>
    public interface IUpdateable
    {
        //Changes the objects characteristics
        void Update();
    }
}
