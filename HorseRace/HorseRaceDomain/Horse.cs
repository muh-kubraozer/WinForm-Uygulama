using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceDomain
{
    public class Horse
    {
        public string Name { get; set; }
        public HorseTypes HorseType { get; }
        public decimal PowerFactor { get; }
        public FieldTypes FavoriteField { get; }

        public Horse(HorseTypes horseType,decimal powerFactor, FieldTypes favoriteField)
        {
            this.HorseType = horseType;
            this.FavoriteField = favoriteField;
            this.PowerFactor = powerFactor;
        }
        public Horse(string name, HorseTypes horseType, decimal powerFactor, FieldTypes favoriteField):this(horseType,powerFactor,favoriteField)
        {
            this.Name = name;
        }
    }
}
