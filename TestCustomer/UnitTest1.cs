using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using DTO;

namespace TestCustomer
{
    [TestClass]
    public class TestCustomer
    {
        Customer cs1, cs2, cs3, cs4, cs5;
        CustomerBUS customerBus = new CustomerBUS();
        [TestInitialize]
        public void setUp()
        {
            cs1 = new Customer("CS001", "Dinh Truong Hoang", "TPHCM", "0123456780");
            cs2 = new Customer("CS002", "Truong An Bao", "TPHCM", "0123456781");
            cs3 = new Customer("CS003", "Dinh Truong An", "TPHCM", "0123456782");
            cs4 = new Customer("CS005", "Dinh Bao Hoang", "TPHCM", "0123456783");
            cs5 = new Customer("CS001", "Truong Nhat Bao", "TPHCM", "0123456784");
        }
        [TestMethod]
        public void TestAddCustomer()
        {
            var test = customerBus.Insert(cs1);
            Assert.AreEqual(true, test);

            test = customerBus.Insert(cs1);
            Assert.AreEqual(false, test);

            test = customerBus.Insert(cs2);
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void TestEditCustomer()
        {
            var test = customerBus.Update(cs5);
            Assert.AreEqual(1, test);

        }
        [TestMethod]
        public void TestDeleteCustomer()
        {
            var test = customerBus.Insert(cs3);
            Assert.AreEqual(true, test);

            int testDel = customerBus.Delete("CS001");
            Assert.AreEqual(1, testDel);
            testDel = customerBus.Delete("CS002");
            Assert.AreEqual(1, testDel);
            testDel = customerBus.Delete("CS003");
            Assert.AreEqual(1, testDel);

            testDel = customerBus.Delete("CS001");
            Assert.AreEqual(0, testDel);
        }


    }
}
