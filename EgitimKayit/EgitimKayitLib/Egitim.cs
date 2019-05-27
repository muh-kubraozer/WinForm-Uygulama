using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKayitLib
{
    public class Egitim : KendindenGuidliSınıf
    {
        public Ders Ders { get; set; }
        public Sube Sube { get; set; }
        public Ogretmen Ogretmen { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

        public Egitim(Ders Ders, Ogretmen Ogretmen, Sube Sube)
        {
            if (Ders==null)
            {
                throw new ArgumentNullException(nameof (Ders));
            }
            if (Ogretmen == null)
            {
                throw new ArgumentNullException(nameof(Ogretmen));
            }
            if (Sube == null)
            {
                throw new ArgumentNullException(nameof(Sube));
            }
            this.Ders = Ders;
            this.Ogretmen = Ogretmen;
            this.Sube = Sube;
            Ogrenciler = new List<Ogrenci>();
        }

        public void EgitimeOgrenciEkle(Ogrenci ogrenci)
        {
            this.Ogrenciler.Add(ogrenci);
        }
    }
}
