using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKayitLib
{
    public class IsBirimi
    {
        public List<Ders> Dersler { get; set; }
        public List<Sube> Subeler { get; set; }
        public List<Ogretmen> Ogretmenler { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public List<Egitim> Egitimler { get; set; }

        public IsBirimi()
        {
            Dersler = new List<Ders>();
            Subeler = new List<Sube>();
            Ogretmenler = new List<Ogretmen>();
            Ogrenciler = new List<Ogrenci>();
            Egitimler = new List<Egitim>();

            SeedDummyData();

        }

        private void SeedDummyData()
        {
            Dersler.Add(new Ders("Matematik"));
            Dersler.Add(new Ders("Kimya"));
            Ogrenciler.Add(new Ogrenci("Serda", "akjfa", "838932982", "jkajas@skfka"));
        }

        public void OgrenciEkle(string ogrenciAdi, string ogrenciSoyadi, string telefon, string email)
        {
            Ogrenci yeniOgrenci = new Ogrenci(ogrenciAdi,ogrenciSoyadi,telefon,email);
            Ogrenciler.Add(yeniOgrenci);
        }

        public void OgrenciDuzenle(string id, string ogrenciAdi, string ogrenciSoyadi, string telefon, string email)
        {
            var duzenlenecekOgrenci = Ogrenciler.SingleOrDefault(x => x.Id == id);
            duzenlenecekOgrenci.OgrenciAdi = ogrenciAdi;
            duzenlenecekOgrenci.OgrenciSoyadi = ogrenciSoyadi;
            duzenlenecekOgrenci.Telefon = telefon;
            duzenlenecekOgrenci.Email = email;
        }

        public void SubeEkle(string subeAdi)
        {
            Sube sube = new Sube(subeAdi);
            Subeler.Add(sube);
        }

        public void SubeDuzenle(string id,string subeAdi)
        {
            var duzenlenecekSube = Subeler.SingleOrDefault(x => x.Id == id);
            duzenlenecekSube.SubeAdi = subeAdi;
        }

        public void DersEkle(string dersAdi)
        {
            Ders ders = new Ders(dersAdi);
            Dersler.Add(ders);
        }

        public void DersDuzenle(string id, string dersAdi)
        {
            var duzenlenecekDers = Dersler.SingleOrDefault(x => x.Id == id);
            duzenlenecekDers.DersAdi = dersAdi;
        }

        public void OgretmenEkle(string ogretmenAdi)
        {
            Ogretmen ogretmen = new Ogretmen(ogretmenAdi);
            Ogretmenler.Add(ogretmen);
        }

        public void OgretmenDuzenle(string id, string ogretmenAdi)
        {
            var duzenlenecekOgretmen = Ogretmenler.SingleOrDefault(x => x.Id == id);
            duzenlenecekOgretmen.OgretmenAdi = ogretmenAdi;
        }

        public void EgitimEkle(string dersId,string ogretmenId,string subeId)
        {
           var eklenecekDers=Dersler.SingleOrDefault(arananDers => arananDers.Id == dersId);
            var eklenecekOgretmen = Ogretmenler.SingleOrDefault(arananOgretmen=> arananOgretmen.Id == ogretmenId);
            var eklenecekSube = Subeler.SingleOrDefault(arananSube => arananSube.Id == subeId);
            Egitim yeniEgitim = new Egitim(eklenecekDers, eklenecekOgretmen, eklenecekSube);
          
        }


        //SingleOrDefault Metodunun çalışma mantığı
        //public Ogrenci MySıngleOrDefault(int id)
        //{
        //    foreach (var item in Ogrenciler)
        //    {
        //        if (item.Id == id)
        //        {
        //            return item;
        //        }

        //    }
        //    return default(Ogrenci);
        //}
    }

}
