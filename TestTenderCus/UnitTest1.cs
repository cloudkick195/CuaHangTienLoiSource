using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using DTO;

namespace TestTenderCus
{
    [TestClass]
    public class TestTenderCus
    {
        Tender_CusBUS Tender_CusBUS = new Tender_CusBUS();

        Customer cs1;
        CustomerBUS customerBus = new CustomerBUS();
        [TestInitialize]
        public void setUp()
        {
            cs1 = new Customer("CS001", "Dinh Truong Hoang", "TPHCM", "0123456780");
        }

        [TestMethod]
        public void TestTender()
        {
            var test = customerBus.Insert(cs1);
            Assert.AreEqual(true, test);

            Customer cus = Tender_CusBUS.GetCustomer("CS002");
            Assert.AreEqual("",cus.cusName);

             cus = Tender_CusBUS.GetCustomer("CS001");
            Assert.AreEqual("Dinh Truong Hoang", cus.cusName);

            int testDel = customerBus.Delete("CS001");
            Assert.AreEqual(1, testDel);

            cus = Tender_CusBUS.GetCustomer("CS001");
            Assert.AreEqual("", cus.cusName);
        }
    }
}
