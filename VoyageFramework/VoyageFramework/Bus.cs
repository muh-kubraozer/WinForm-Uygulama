using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public abstract class Bus
    {
        public string Make { get; }
        private string _Plate;
        public string Plate { get; set; }
        public abstract int Capacity {get;}
        public bool HasToilet { get; }
    }
}
