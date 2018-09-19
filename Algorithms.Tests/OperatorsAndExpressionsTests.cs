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


        [Test]
        public void CheckThirdDigitTest()
        {
            Assert.IsTrue(CheckThirdDigit(value:54321, n:3));
            Assert.IsTrue(CheckThirdDigit(value: 678, n: 6));

            Assert.IsTrue(CheckThirdDigit(value: 12, n: 0), "Failed when test with small (digits count less than three) number");

            Assert.IsTrue(CheckThirdDigit(-23464, 4), "Failed when test with negative number");

            Assert.IsFalse(CheckThirdDigit(-6345, -3));
        }


        [Test]
        public void CheckThirdBitTest()
        {
            Assert.IsTrue(CheckThirdBit(0));
            Assert.IsFalse(CheckThirdBit(1 << 2));
            Assert.IsFalse(CheckThirdBit(int.MaxValue));
            Assert.IsTrue(CheckThirdBit(~(1 << 2)));
        }


        [Test]
        public void SumDigitsTest()
        {

            Assert.AreEqual(6, SumDigits(123));
            Assert.AreEqual(6, SumDigits(-123), "Failed when test with negative number");
            Assert.AreEqual(0, SumDigits(0), "Failed when test with zero");
            
            Random rnd = new Random();

            for (int i = 0; i < 1_000_000; i++)
            {
                var digits = Enumerable.Range(0, int.MaxValue.ToString().Length - 1).Select(n => rnd.Next(10)).ToList();
                int expectedSum = digits.Sum();
                int number = int.Parse(new string(digits.Select(n => n.ToString()[0]).ToArray()));

                Assert.AreEqual(expectedSum, SumDigits(number), $"Failed  when test with {number}");

            }

        }


    }
}
