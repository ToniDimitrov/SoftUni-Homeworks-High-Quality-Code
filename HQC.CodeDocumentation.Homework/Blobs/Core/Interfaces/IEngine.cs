﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Interfaces
{
    /// <summary>
    /// Defines classes that can be run
    /// </summary>
    interface IEngine
    {
        //The main loop of the game
        void Run();
    }
}
