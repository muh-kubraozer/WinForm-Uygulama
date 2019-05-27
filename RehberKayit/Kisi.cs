using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberDuzenlenmis
{

   class Kisi
    {
        public Kisi(string Ad,string Soyad,string Telefon,string Adres)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Telefon = Telefon;
            this.Adres = Adres;
        }

        public string Ad;
        public string Soyad;
        public string Telefon;
        public string Adres;
        public string AdSoyad
        {
            get { return String.Format("{0} {1}", this.Ad, this.Soyad); }
        }
    }
}
