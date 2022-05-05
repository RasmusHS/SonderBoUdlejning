using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void NavnCheck_Valid()
        {
            //Der er 50 i'er
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.NavnCheck("iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii"));
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.NavnCheck("John Hansen"));
            Assert.IsTrue(SonderBoUdlejning.SQLBuilders.personInputCheck.NavnCheck("רזו"));
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

        [TestMethod]
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
            //Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.TlfCheck("+4520202020"));
            Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.TlfCheck("0202020"));
            //Assert.IsFalse(SonderBoUdlejning.SQLBuilders.personInputCheck.TlfCheck("020202020"));
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
    }
}
