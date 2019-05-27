using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceDomain
{
    public class Racer
    {
        public int RacerNo { get; set; }
        public int GateNo { get; set; }
        public Horse Horse { get; set; }
        public Jockey Jockey { get; set; }
    }
}
