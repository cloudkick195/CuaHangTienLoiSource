using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using DTO;
namespace TextSannerProduct
{
    [TestClass]
    public class TextSannerP
    {
        ScannerBUS ScannerBUS = new ScannerBUS();
        //01004243- cha gio tom mayonaise
        [TestMethod]
        public void TestFindP()
        {
            var test = ScannerBUS.GetBarcode("01004243");
            Assert.AreEqual(true, test);

            Product testP = ScannerBUS.GetProducts("01004243");
            Assert.AreEqual("Chả giò tôm Mayonaise", testP.proName);

            //Tim sai code
            test = ScannerBUS.GetBarcode("789798");
            Assert.AreEqual(false, test);

            testP = ScannerBUS.GetProducts("789798");
            Assert.AreEqual("", testP.proName);
        }
    }
}
