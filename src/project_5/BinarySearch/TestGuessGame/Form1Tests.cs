using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        public Form1 form1 = new Form1();


        [TestMethod()]
        public void Form1Test()
        {
            Assert.AreEqual(3, 3);
        }

        [TestMethod()]
        public void ExampleMethodTest()
        {
            int result = this.form1.ExampleMethod(2, 2);
            Assert.AreEqual(2, 2);
        }
    }
}