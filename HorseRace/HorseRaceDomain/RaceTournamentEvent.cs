using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorseRaceDomain.DataCollectors;

namespace HorseRaceDomain
{
    public class RaceTournamentEvent
    {
        private string _infoPath;

        public List<Horse> Horses { get; private set; }
        public List<Jockey> Jockeys { get; private set; }
        public List<Race> Races { get; set; }
        public RaceTournamentEvent(string infoPath)
        {
            _infoPath = infoPath;
        }

        public void Initialize()
        {
            HorseInfoCollector horseCollector = new HorseInfoCollector(_infoPath+"\\Horses.xml");
            this.Horses = horseCollector.GetHorses();
            JockeyInfoCollector jockeyCollector = new JockeyInfoCollector(_infoPath+"\\Jockeys.xml");
            this.Jockeys = jockeyCollector.GetJockeys();
        }

        public void GenerateRace()
        {
            Race newRace = new Race();
            newRace.AddRacer(this.Horses[0], this.Jockeys[0]);
            newRace.AddRacer(this.Horses[1], this.Jockeys[1]);
            this.Races.Add(newRace);

        }
    }
}
