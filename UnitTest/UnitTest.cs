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
            Assert.IsTrue(SonderBoUdlejning.InputCheck.PersonInputCheck.NavnCheck("iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii"));
            Assert.IsTrue(SonderBoUdlejning.InputCheck.PersonInputCheck.NavnCheck("John Hansen"));
            Assert.IsTrue(SonderBoUdlejning.InputCheck.PersonInputCheck.NavnCheck("רזו"));
        }

        [TestMethod]
        public void NavnCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.NavnCheck("John1"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.NavnCheck("$username = 1' or '1' = '1"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.NavnCheck("Timmy' OR i--"));
        }

        [TestMethod]
        public void MailCheck_Valid()
        {
            Assert.IsTrue(SonderBoUdlejning.InputCheck.PersonInputCheck.MailCheck("kaspermarks@gmail.com"));
        }

        //[TestMethod]
        public void MailCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.MailCheck("kaspermar@ks@gmail.com"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.MailCheck("kaspermarks@gmail,com"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.MailCheck("kaspermarks@gma.il.com"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.MailCheck("iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii"));
        }

        [TestMethod]
        public void TlfCheck_Valid()
        {
            Assert.IsTrue(SonderBoUdlejning.InputCheck.PersonInputCheck.TlfCheck("20202020"));
        }

        [TestMethod]
        public void TlfCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.TlfCheck("+4520202020"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.TlfCheck("0202020"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.TlfCheck("020202020"));
        }

        [TestMethod]
        public void PIdCheck_Valid()
        {
            Assert.IsTrue(SonderBoUdlejning.InputCheck.PersonInputCheck.PIdCheck("1"));
            Assert.IsTrue(SonderBoUdlejning.InputCheck.PersonInputCheck.PIdCheck("10000000000000000000000000000"));
        }

        [TestMethod]
        public void PIdCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.PIdCheck("et"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.PersonInputCheck.PIdCheck("!"));
        }


        //BoligInputCheck.cs
        [TestMethod]
        public void bIdCheck_Valid()
        {
            Assert.IsTrue(SonderBoUdlejning.InputCheck.BoligInputCheck.BIdCheck("1"));
            Assert.IsTrue(SonderBoUdlejning.InputCheck.BoligInputCheck.BIdCheck("10000000000000000000000000000"));
        }

        [TestMethod]
        public void bIdCheck_InValid()
        {
            Assert.IsFalse(SonderBoUdlejning.InputCheck.BoligInputCheck.BIdCheck("et"));
            Assert.IsFalse(SonderBoUdlejning.InputCheck.BoligInputCheck.BIdCheck("100002d"));
        }

        [TestMethod]
        public void pCreate_Valid() 
        {
            Assert.That.Equals(SonderBoUdlejning.ConnString.getConnInstance);
        }
    }
}
