using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
   public class LuxuryBus : Bus
    {
        public override int Capacity { get { return 20; } }

        public bool HasToilet { get { return true; ; } }
    }
}
