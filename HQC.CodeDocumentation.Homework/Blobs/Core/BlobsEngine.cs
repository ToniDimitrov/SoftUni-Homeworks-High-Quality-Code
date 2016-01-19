using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Core.Factories;
using Blobs.Core.Interfaces;
using Blobs.Models.Blob;
using Blobs.Models.Interfaces;

namespace Blobs.Core
{
    class BlobsEngine:IEngine
    {
        private readonly IInputReader inputReader;
        private readonly IOutputWriter outputWriter;

        private readonly IBlobsData blobsData;

        private readonly IBlobFactory blobFactory;
        private readonly IAttackFactory attackFactory;
        private readonly IBehaviorFactory behaviorFactory;

        public BlobsEngine(IBlobFactory blobFactory,
            IAttackFactory attackFactory,
            IBehaviorFactory behaviorFactory,
            IBlobsData blobsData,
            IInputReader inputReader,
            IOutputWriter outputWriter)
        {
            this.blobFactory = blobFactory;
            this.attackFactory = attackFactory;
            this.behaviorFactory = behaviorFactory;
            this.blobsData = blobsData;
            this.inputReader = inputReader;
            this.outputWriter = outputWriter;
        }

        public void Run()
        {
            string[] input = this.inputReader.ReadLine().Split();
            while (input[0]!="drop")
            {
                ExecuteCommand(input);

                UpdateBlobs();
                
                input = this.inputReader.ReadLine().Split();;
            }
            Environment.Exit(0);
        }

        private void UpdateBlobs()
        {
            foreach (var blob in blobsData.Blobs)
            {
                blob.Update();
            }
        }

        private void ExecuteCommand(string[] input)
        {
            switch (input[0])
            {
                case "create":
                {
                    ExecuteCreateCommand(input);
                    break;
                }
                case "attack":
                {
                    ExecuteAttackCommand(input);
                    break;
                }
                case "pass":
                {
                    break;
                }
                case "status":
                {
                    ExecuteStatusCommand();
                    break;
                }
            }
        }

        private void ExecuteStatusCommand()
        {
            foreach (var blob in blobsData.Blobs)
            {
                this.outputWriter.Print(blob.ToString());
            }
        }

        private void ExecuteAttackCommand(string[] input)
        {
            IBlob attacker = new Blob();
            IBlob target = new Blob();
            foreach (var blob in blobsData.Blobs)
            {
                if (blob.Name == input[1])
                {
                    attacker = blob;
                }
            }
            foreach (var blob in blobsData.Blobs)
            {
                if (blob.Name == input[2])
                {
                    target = blob;
                }
            }


            attacker.Attack(target);
        }

        private void ExecuteCreateCommand(string[] input)
        {
            var behavior = behaviorFactory.CreateBehavior(input[4]);
            var attack = attackFactory.CreateAttack(input[5]);

            var blob = blobFactory.CreateBlob(input[1], int.Parse(input[2]), int.Parse(input[3]), behavior, attack);
            blobsData.AddBlob(blob);
        }
    }
}
