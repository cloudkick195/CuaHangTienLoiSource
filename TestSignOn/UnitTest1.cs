using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using DTO;
namespace TestSignOn
{
    [TestClass]
    public class TestSignOn
    {

        //("1301", "Nguyễn an", "TPHCM","1234" ,"0123456780");
        //("1302", "Trần bảo", "TPHCM", "1234", "0123456781");
        SignOnBUS sn = new SignOnBUS();

        [TestMethod]
        public void TestSignOnUser()
        {
            var test = sn.SignOn_ID("1301");
            Assert.AreEqual(true, test);

            test = sn.SignOn_ID("9999");
            Assert.AreEqual(false, test);

            test = sn.SignOn_Pass("1234");
            Assert.AreEqual(true, test);

            test = sn.SignOn_Pass("7777");
            Assert.AreEqual(false, test);

            string testName = sn.getNameID("1301");
            Assert.AreEqual("Nguyễn An", testName);

        }
    }
}
