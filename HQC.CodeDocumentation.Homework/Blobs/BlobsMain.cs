using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Core;
using Blobs.Core.Factories;
using Blobs.Core.Interfaces;
using Blobs.IO;
using Blobs.Models.Interfaces;

namespace Blobs
{
    class BlobsMain
    {
        private static void Main(string[] args)
        {
            IInputReader inputReader = new ConsoleReader();
            IOutputWriter outputWriter = new ConsoleWriter();

            IBlobsData blobsData = new BlobsData();

            IBlobFactory blobFactory = new BlobFactory();
            IAttackFactory attackFactory = new AttackFactory();
            IBehaviorFactory behaviorFactory = new BehaviorFactory();

            IEngine engine = new BlobsEngine(blobFactory,attackFactory,behaviorFactory,blobsData,inputReader,outputWriter);
            engine.Run();
        }
    }
}
