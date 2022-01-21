using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Web;
using ProjektUpi;


namespace ProjektUpi.UnitTests
{
    [TestClass]
    public class Testovi
    {
        [TestMethod]
        public void ID_Test()
        {
            //Arrange
            string unos = "12345";
            bool validacija = false;
            //Act
            if (!unos.All(Char.IsDigit))
            {
                validacija = false;
            }
            else
                validacija = true; ;
            //Assert
            Assert.IsTrue(validacija);
        }

        [TestMethod]
        public void Unos_Imena_Test()
        {
            string ime = "Ante";
            bool provjera;
            if (ime == "" || ime.All(Char.IsDigit))
                provjera = false;
            else
                provjera = true;

            Assert.IsTrue(provjera);
        }

        [TestMethod]
        public void Unos_Mob_i_Tel_Test()
        {
            string broj = "0981234567";
            int value;
            bool provjera;
            if (int.TryParse(broj, out value))
                provjera = true;
            else
                provjera = false;

            Assert.IsTrue(provjera);
        }

        [TestMethod]
        public void LogIn_Test()
        {
            string username = "Ante";
            string password = "12345";

            bool provjera;

            string expectedUsername = "Ante";
            string expectedPassword = "12345";

            if (username == expectedUsername && password == expectedPassword || username != "" || password != "")
                provjera = true;
            else
                provjera = false;
            

            Assert.IsTrue(provjera);
        }
    }
}