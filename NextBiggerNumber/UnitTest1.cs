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
            var actual = target.Next(9);

            var expect = -1;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void give_12_return_21()
        {
            var target = new Calculator();
            var actual = target.Next(12);

            var expect = 21;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void give_21_return_21()
        {
            var target = new Calculator();
            var actual = target.Next(21);

            var expect = -1;

            Assert.AreEqual(expect, actual);
        }

        
        [TestMethod]
        public void give_345_return_354()
        {
            var target = new Calculator();
            var actual = target.Next(345);

            var expect = 354;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void input_is_576_should_return_657()
        {
            var target = new Calculator();
            var expected = 657;
            var actual = target.Next(576);
            Assert.AreEqual(expected, actual);
        }

    }
}
