using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class StandardBus : Bus
    {
        public override int Capacity { get { return 30; } }

        public bool HasToilet { get { return false; } }

    }
}
