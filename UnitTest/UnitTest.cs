using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        //PersonInputCheck,cs
        [TestMethod]
        public void NavnCheck_Valid()
        {
            //Der er 50 i'er
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.NavnCheck("iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii"));
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.NavnCheck("John Hansen"));
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.NavnCheck("���"));
        }

        [TestMethod]
        public void NavnCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.NavnCheck("John1"));
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.NavnCheck("$username = 1' or '1' = '1"));
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.NavnCheck("Timmy' OR i--"));
        }

        [TestMethod]
        public void MailCheck_Valid()
        {
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.MailCheck("kaspermarks@gmail.com"));
        }

        //[TestMethod]
        public void MailCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.MailCheck("kaspermar@ks@gmail.com"));
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.MailCheck("kaspermarks@gmail,com"));
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.MailCheck("kaspermarks@gma.il.com"));
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.MailCheck("iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii"));
        }

        [TestMethod]
        public void TlfCheck_Valid()
        {
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.TlfCheck("20202020"));
        }

        [TestMethod]
        public void TlfCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.TlfCheck("+4520202020"));
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.TlfCheck("0202020"));
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.TlfCheck("020202020"));
        }

        [TestMethod]
        public void PIdCheck_Valid()
        {
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.PIdCheck("1"));
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.PIdCheck("10000000000000000000000000000"));
        }

        [TestMethod]
        public void PIdCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.PIdCheck("et"));
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.PIdCheck("!"));
        }


        //VenteListeInputCheck.cs
        [TestMethod]
        public void bIdCheck_Valid()
        {
            Assert.IsTrue(SonderBoUdlejning.InputCheck.ventelisteInputCheck.BIdCheck("1"));
            Assert.IsTrue(SonderBoUdlejning.InputCheck.ventelisteInputCheck.BIdCheck("10000000000000000000000000000"));
        }

        [TestMethod]
        public void bIdCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.BIdCheck("et"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.BIdCheck("100002d"));
        }

        [TestMethod]
        public void pCreate_Valid() 
        {
            Assert.That.Equals(SonderBoUdlejning.ConnString.getConnInstance);
        }

        [TestMethod]
        public void yearCheck_Valid() 
        {
            Assert.IsTrue(SonderBoUdlejning.InputCheck.ventelisteInputCheck.YearCheck("2022"));
            Assert.IsTrue(SonderBoUdlejning.InputCheck.ventelisteInputCheck.YearCheck("9999"));
        }

        [TestMethod]
        public void yearCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.YearCheck("21111"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.YearCheck("211"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.YearCheck("21@1"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.YearCheck("abcd"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.YearCheck("2021"));
        }

        [TestMethod]
        public void Opsigelse_Valid() 
        {
            Assert.AreEqual("2020-12-01", SonderBoUdlejning.Opsigelse.OpsigFunktioner.DateBuilder(11, "2020"));
        }

        [TestMethod]
        public void monnthCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.MonthCheck(5));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.MonthCheck(6));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.MonthCheck(7));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.ventelisteInputCheck.MonthCheck(8));
        }

        [TestMethod]
        public void monnthCheck_Valid()
        {
            Assert.IsTrue(SonderBoUdlejning.InputCheck.ventelisteInputCheck.MonthCheck(8));
        }

    }
}