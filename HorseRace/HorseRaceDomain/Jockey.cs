using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceDomain
{
    public class Jockey
    {
        public string Name { get; set; }
        public decimal PowerFactor { get; }
        public HorseTypes FavoriteHorseType { get; }

        public Jockey(decimal powerFactor,HorseTypes favoriteHorseType)
        {
            PowerFactor = powerFactor;
            FavoriteHorseType = favoriteHorseType;
        }

        public Jockey(string name, decimal powerFactor, HorseTypes favoriteHorseType):this(powerFactor,favoriteHorseType)
        {
            Name = name;
        }
    }
}
