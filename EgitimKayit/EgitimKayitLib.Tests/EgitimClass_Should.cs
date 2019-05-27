using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimKayitLib;

namespace EgitimKayitLib.Tests
{
    [TestClass]
    public class EgitimClass_Should
    {
        [TestMethod]
        public void SetDersPropInConst()
        {
            //Arrange
            Ders ders = new Ders("Test Ders");
            Sube sube = new Sube("Test Sube");
            Ogretmen ogretmen = new Ogretmen("Test Ogretmen");
            //Act
            Egitim egitim = new Egitim(ders, ogretmen, sube);

            // Assert
            Assert.AreEqual(ders, egitim.Ders);

        }

        [TestMethod]
        public void SetSubePropInConst()
        {
            //Arrange
            Ders ders = new Ders("Test Ders");
            Sube sube = new Sube("Test Sube");
            Ogretmen ogretmen = new Ogretmen("Test Ogretmen");
            //Act
            Egitim egitim = new Egitim(ders, ogretmen, sube);

            // Assert
            Assert.AreEqual(sube, egitim.Sube);

        }

        [TestMethod]
        public void SetOgretmenPropInConst()
        {
            //Arrange
            Ders ders = new Ders("Test Ders");
            Sube sube = new Sube("Test Sube");
            Ogretmen ogretmen = new Ogretmen("Test Ogretmen");
            //Act
            Egitim egitim = new Egitim(ders, ogretmen, sube);

            // Assert
            Assert.AreEqual(ogretmen, egitim.Ogretmen);

        }

        [TestMethod]
        public void ThrowsAnExceptionIfAnyParamIsNull()
        {
            //Arrange            
            Action act = new Action(CreateEgitimInstance);

            // Act And Assert
            Assert.ThrowsException<ArgumentNullException>(act);

            //Anonim method ve lambda expression kullanarak 

            //Assert.ThrowsException<ArgumentNullException>(() => { new Egitim(null, new Ogretmen("Test Ogretmen"), null); });
        }

        private void CreateEgitimInstance()
        {
            Egitim egitim = new Egitim(null, new Ogretmen("Test Ogretmen"), null);
        }
    }
}
