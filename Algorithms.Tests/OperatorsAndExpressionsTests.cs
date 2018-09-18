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


        [Test]
        public void IsDivisibleBothDivisorTest()
        {
            Assert.IsTrue(IsDivisibleBothDivisor(value:10, divisor1:2, divisor2:5));
            Assert.IsTrue(IsDivisibleBothDivisor(value: 17, divisor1: 17, divisor2: 1));
            Assert.IsTrue(IsDivisibleBothDivisor(value: 10, divisor1: -2, divisor2: -5), "Failed when test with negative divisors");

            Assert.IsFalse(IsDivisibleBothDivisor(value: 15, divisor1: 5, divisor2: 10));
            Assert.IsFalse(IsDivisibleBothDivisor(value: 15, divisor1: 10, divisor2: 5));
            Assert.IsFalse(IsDivisibleBothDivisor(value: 15, divisor1: 20, divisor2: 30));
            Assert.IsFalse(IsDivisibleBothDivisor(value: 10, divisor1: 0, divisor2: 0), "Failed when test with zero divisor (should return false)");

        }

    }
}
