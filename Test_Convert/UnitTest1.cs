using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Convert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Roman_1_I()
        {
            Assert.AreEqual("I", NumeroArab.To(1));
        }


    }
}