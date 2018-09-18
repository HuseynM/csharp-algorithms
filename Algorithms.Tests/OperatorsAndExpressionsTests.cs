using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Algorithms.Exercises.operators_and_expressions.OperatorsAndExpressions;

namespace Algorithms.Tests
{
    [TestFixture]
    public class OperatorsAndExpressionsTests
    {
        [Test]
        public void IsOddOrEvenTest()
        {
            Assert.AreEqual("even", IsOddOrEven(2));
            Assert.AreEqual("even", IsOddOrEven(0));
            Assert.AreEqual("even", IsOddOrEven(-6));
            Assert.AreEqual("even", IsOddOrEven(int.MinValue));

            Assert.AreEqual("odd", IsOddOrEven(1));
            Assert.AreEqual("odd", IsOddOrEven(-1));
            Assert.AreEqual("odd", IsOddOrEven(int.MaxValue));

        }

    }
}
