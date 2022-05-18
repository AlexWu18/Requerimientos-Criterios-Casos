using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Convert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RomanTest_1()
        {
            Assert.AreEqual("I", NumeroArab.To(1));
        }
        
        [TestMethod]
        public void RomanTest_2()
        {
            Assert.AreEqual("II", NumeroArab.To(2));
        }

        [TestMethod]
        public void RomanTest_3()
        {
            Assert.AreEqual("III", NumeroArab.To(3));
        }

        [TestMethod]
        public void RomanTest_4()
        {
            Assert.AreEqual("L", NumeroArab.To(50));
        }

        [TestMethod]
        public void RomanTest_5()
        {
            Assert.AreEqual("CM", NumeroArab.To(900));
        }

        [TestMethod]
        public void RomanTest_6()
        {
            Assert.AreEqual("CD", NumeroArab.To(400));
        }

        [TestMethod]
        public void RomanTest_7()
        {
            Assert.AreEqual("XC", NumeroArab.To(90));
        }

    }
}