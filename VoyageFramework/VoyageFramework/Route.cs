using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class Route
    {
        
        public string Name
        {
            get
            { string BreakRoute = string.Format("{0}/{1}-{2} km'lik molalı rota", this.DepartureLocation, this.ArrivalLocation, this.Distance.ToString(), this.BreakCount);
               string ExpressRoute = string.Format("{0}-{1}/{2} km'lik express rota", this.DepartureLocation, this.ArrivalLocation, this.Distance.ToString());
                return (this.BreakCount == 0) ? BreakRoute : ExpressRoute;
            }
        }
        public string DepartureLocation { get; } //kalkış yeri
        public string ArrivalLocation { get; }  //varış yeri
        public int Distance { get; } //mesafe
        public int Duration { get
            {
                decimal distanceDuration = Math.Ceiling((decimal)Distance * 45 / 60);
                int breakDuration = (BreakCount > 0) ? 30 * BreakCount : 0;
                return (int)distanceDuration + breakDuration;
            } }//süre

        private int _breakCount;

        public Route(string v1, string v2, int distance)
        {
            Distance = distance;
        }

        public int BreakCount // mola sayısı
        {
            get { return _breakCount; }
            set
            {
                if (value <= 0)
                {
                    _breakCount = 0;
                }
                else if (value <= Distance / 200)
                {

                    _breakCount = value;
                }
                else
                    _breakCount = Distance / 200;

               
            }
        } 
        public decimal BasePrice { get
            {
                 
                decimal distance = Math.Ceiling((decimal)Distance / 25);
                decimal basePrice = (Distance > 300) ? 12 * 5 + ((distance - 12) * 4.25m) : (distance) * 5;
                return basePrice;
            }
        } 
      
    }
}
