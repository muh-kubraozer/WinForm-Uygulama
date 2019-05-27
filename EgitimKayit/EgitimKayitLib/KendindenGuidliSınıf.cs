using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKayitLib
{
    public abstract class KendindenGuidliSınıf
    {
        public string Id { get;}

        public KendindenGuidliSınıf()
        {
           this.Id = Guid.NewGuid().ToString();           
        }
    }
}
