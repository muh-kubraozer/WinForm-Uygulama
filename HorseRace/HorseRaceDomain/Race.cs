using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceDomain
{
    public class Race
    {
        public List<Racer> Racers
        {
            get;
            private set;
        }
        public Hippodrome Hippodrome { get; set; }

        public void AddRacer(Horse horse, Jockey jockey)
        {
            Racer racer = new Racer();
            racer.Jockey = jockey;
            racer.Horse = horse;
            racer.GateNo = Racers.Count + 1;
            racer.RacerNo = Racers.Count + 1;
            if (Racers == null)
            {
                Racers = new List<Racer>();
            }
            Racers.Add(racer);

        }
    }
}
