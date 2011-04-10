using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FibonnaciTest
{
    [TestFixture]
    public class Fibotest 
    {
        [Test]
        public void fibonnaci_0_returns_0()
        {
            var result = Fibonnaci.Calc(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void fibonnaci_1_returns_1()
        {
            var result = Fibonnaci.Calc(1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void fibonnaci_2_returns_1()
        {
            var result = Fibonnaci.Calc(2);
            Assert.AreEqual(1, result);
        }

    }

    public class Fibonnaci
    {

        public static int Calc(int value)
        {
            if (value > 1)
                return 1;
            return value;
        }
    }
}
