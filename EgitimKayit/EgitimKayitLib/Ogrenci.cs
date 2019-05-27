using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKayitLib
{
    public class Ogrenci : KendindenGuidliSınıf
    {        
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public Ogrenci(string ogrenciAdi, string ogrenciSoyadi, string telefon, string email)
        {
            this.OgrenciAdi = ogrenciAdi;
            this.OgrenciSoyadi = ogrenciSoyadi;
            this.Telefon = telefon;
            this.Email = email;
        }
    }
}
