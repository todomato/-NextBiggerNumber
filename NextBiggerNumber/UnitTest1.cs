using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace NextBiggerNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void give_9_return_negative1()
        {
            var target = new Calculator();
            var actual = target.number(9);

            var expect = -1;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void give_12_return_21()
        {
            var target = new Calculator();
            var actual = target.number(12);

            var expect = 21;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void give_21_return_21()
        {
            var target = new Calculator();
            var actual = target.number(21);

            var expect = -1;

            Assert.AreEqual(expect, actual);
        }
    }
}
