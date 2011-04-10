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
    }

    public class Fibonnaci
    {

        public static int Calc(int value)
        {
            return 0;
        }
    }
}
