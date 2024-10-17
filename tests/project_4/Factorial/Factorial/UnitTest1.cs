using Microsoft.VisualStudio.TestTools.UnitTesting;
using factorial;

namespace FactorialTests
{
    [TestClass]
    public class UnitTest1
    {
        private Form1 form;

        [TestInitialize]
        public void Setup()
        {
            // Initialize Form1 instance for testing
            form = new Form1();
        }

        [TestMethod]
        public void TestFactorialBasicCases()
        {
            Assert.AreEqual(1, form.factorial(0));
            Assert.AreEqual(1, form.factorial(1));
        }

        [TestMethod]
        public void TestFactorialOfSmallNumbers()
        {
            Assert.AreEqual(120, form.factorial(5));
            Assert.AreEqual(720, form.factorial(6));
        }

        [TestMethod]
        public void TestFactorialWithMemoization()
        {
            long expected = 2_432_902_008_176_640_000; // 20!
            Assert.AreEqual(expected, form.factorial(20));
        }

        [TestMethod]
        public void TestIterativeFactorial()
        {
            long expected = 3_628_800; // 10! = 3,628,800
            Assert.AreEqual(expected, form.iterativeFactorial(10));
        }
    }
}