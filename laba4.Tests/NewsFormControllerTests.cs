using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba4.Controllers;

namespace laba4.Tests
{
    [TestClass]
    public class NewsFormControllerTests
    {
        [TestMethod]
        public void checkQuantityL_writeAmount_Pass()
        {
            string test = "ttttttttttttttttttttttttttttttttttttttttttttttttttt";
            NewsFormController newss = new NewsFormController();
            var expect = newss.checkQuantityL(test);
            Assert.AreEqual(false, expect);
        }

        [TestMethod]
        public void checkQuantityN_writeAmount_Pass()
        {
            string test = "ttttttttttttttttttttttttttttttttttttttttttttttttttt";
            NewsFormController newss = new NewsFormController();
            var expect = newss.checkQuantityN(test);
            Assert.AreEqual(false, expect);
        }

        [TestMethod]
        public void checkQuantityD_writeAmount_Pass()
        {
            string test = "ttttttttttttttttttttttttttttttttttttttttttttttttttt";
            NewsFormController newss = new NewsFormController();
            var expect = newss.checkQuantityD(test);
            Assert.AreEqual(false, expect);
        }

        [TestMethod]
        public void checkQuantityL_writeAmount_Pass1()
        {
            string test = "ttttttttttttttttttttttttttttttttttttttt";
            NewsFormController newss = new NewsFormController();
            var expect = newss.checkQuantityD(test);
            Assert.AreEqual(true, expect);
        }

        [TestMethod]
        public void checkQuantityN_writeAmount_Pass1()
        {
            string test = "ttttttttttttttttttttttttttttttttttttttt";
            NewsFormController newss = new NewsFormController();
            var expect = newss.checkQuantityD(test);
            Assert.AreEqual(true, expect);
        }

        [TestMethod]
        public void checkQuantityD_writeAmount_Pass1()
        {
            string test = "ttttttttttttttttttttttttttttttttttttttt";
            NewsFormController newss = new NewsFormController();
            var expect = newss.checkQuantityD(test);
            Assert.AreEqual(true, expect);
        }
    }
}
