using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Core.Interfaces;
using Blobs.Models.Behaviors;
using Blobs.Models.Interfaces;

namespace Blobs.Core.Factories
{
    class BehaviorFactory:IBehaviorFactory
    {
        public IBehavior CreateBehavior(string name)
        {
            IBehavior behavior;
            switch (name)
            {
                case "Aggressive":
                {
                    behavior = new AggresiveBehavior();
                    break;
                }
                case "Inflated":
                {
                    behavior = new InflatedBehavior();
                    break;
                }
                default:
                {
                    throw new ArgumentException("Unknown behavior type");
                }
            }
            return behavior;
        }
    }
}
