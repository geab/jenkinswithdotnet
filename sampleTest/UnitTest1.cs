using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace sampleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello world", Program.createMessage());
        }
    }
}
