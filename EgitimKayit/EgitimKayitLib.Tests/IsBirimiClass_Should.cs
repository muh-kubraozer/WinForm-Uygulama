using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimKayitLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EgitimKayitLib.Tests
{
    [TestClass]
    public class IsBirimiClass_Should
    {
        [TestMethod]
        public void BeAbleToAddOgrenci()
        {
            //Arrange
            IsBirimi isBirimi = new IsBirimi();
            var ogrSayisi = isBirimi.Ogrenciler.Count();
            //Act
            isBirimi.OgrenciEkle("Serdar", "Ünver", "72387282", "saeafa@gklss");

            //Assert
            Assert.AreEqual(ogrSayisi +1, isBirimi.Ogrenciler.Count());
        }
        [TestMethod]
        public void GetNewAddedOgrenciFromOgrenciler()
        {
            //Arrange
            IsBirimi isBirimi = new IsBirimi();
            var ogrSayisi = isBirimi.Ogrenciler.Count();
            //Act
            isBirimi.OgrenciEkle("Serdar", "Ünver", "72387282", "saeafa@gklss");

            //Assert
            Assert.IsTrue(isBirimi.Ogrenciler.Any(x => x.OgrenciAdi == "Serdar" && x.OgrenciSoyadi == "Ünver" && x.Telefon == "72387282" && x.Email == "saeafa@gklss"));
        }
    }
}
