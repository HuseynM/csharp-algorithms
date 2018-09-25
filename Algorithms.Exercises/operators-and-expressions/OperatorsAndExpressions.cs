using System;

namespace Algorithms.Exercises.operators_and_expressions
{
    public static class OperatorsAndExpressions
    {
        public static string IsOddOrEven(int value) // Exercise 1
        {
            /*
            * Write an expression that checks whether an integer is odd or even.
            */

            return (value & 1) == 0 ? "even" : "odd";
        }

        public static bool IsDivisibleBothDivisor(int value, int divisor1, int divisor2) // Exercise 2
        {
            /*
             * Write a Boolean expression that checks whether a given integer is
                divisible by both divisor1 and divisor2, without a remainder.
             */
            if (divisor1 != 0 && divisor2 != 0)
                return value % divisor1 == 0 && value % divisor2 == 0;
            return false;
        }

        public static bool CheckThirdDigit(int value, int n) // Exercise 3
        {
            /*
             * Write an expression that looks for a given integer if its third digit (right
                to left) is 7.
             */

            value = value / 100;

            return value % 10 == n;
        }

        public static bool CheckThirdBit(int value) // Exercise 4
        {
            /*
             * Write an expression that checks whether the third bit in a given integer
                is 1 or 0.
             */

            /*
             * 1011010001
             * 0000000100 4
             * 0000000000
             */

            int thirdBit = value & 0B100; //0B100 = 4

            return thirdBit == 0;
        }

        public static int SumDigits(int value) // Exercise 10-A
        {
            /*
             * Write a program that takes as input a four-digit number in format abcd
                (e.g. 2011) and performs the following actions:
                - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
             */

            int sum = 0;
            while (value > 0)
            {
                sum += value % 10;
                value = value / 10;
            }

            return sum;
        }

        public static int ReverseDigits(int value) // Exercise 10-B
        {
            /*
             * Write a program that takes as input a four-digit number in format abcd
                (e.g. 2011) and performs the following actions:
               -Prints on the console the number in reversed order: dcba (in our
                example 1102).
             */

            int reversed = 0;
            while (value > 0)
            {
                reversed *= 10;
                int lastDigit = value % 10;
                reversed += lastDigit;
                value = value / 10;
            }

            return reversed;
        }

        private static int GetDigitCount(int value)
        {
            int i = 0;
            while (value > 0)
            {
                value = value / 10;
                i++;
            }

            return i;
        }

        public static int PutLastDigitInFirst(int value) // Exercise 10 C
        {
            /*
             * Write a program that takes as input a four-digit number in format abcd
                (e.g. 2011) and performs the following actions:
                -Puts the last digit in the first position: dabc (in our example 1201).
             */

            int i = GetDigitCount(value);
            int lastDigit = value % 10;
            lastDigit *= (int)Math.Pow(10, i - 1);
            lastDigit += value / 10;

            return lastDigit;
        }

        public static int PutFirstDigitInLast(int value)
        {
            /*
             * Write a program that takes as input a four-digit number in format abcd
                (e.g. 2011) and performs the following actions:
                -Puts the first digit in the last position: bcda (in our example 1201).
             */
            //1523
            int i = GetDigitCount(value);
            int firstDigit = value / (int)Math.Pow(10, i - 1);
            value = value % (int)Math.Pow(10, i - 1);
            value = value * 10 + firstDigit;

            return value;
        }

        public static int ExchangeDigits(int value) // Exercise 10 D
        {
            /*
              Write a program that takes as input a four-digit number in format abcd
               (e.g. 2011) and performs the following actions:
              -Exchanges the second and the third digits: acbd (in our example
               2101).
            */

            //1234

            int secondDigit = (value / 100) % 10; // 2
            int thirdDigit = (value / 10) % 10; // 3

            value = value - secondDigit * 100;
            value = value + thirdDigit * 100;

            value = value - thirdDigit * 10;
            value = value + secondDigit * 10;

            return value;

        }

        public static int PrintBitPosition(int n, byte p) // Exercise 11
        {
            /*
               We are given a number n and a position p. Write a sequence of
                operations that prints the value of the bit on the position p in the
                number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35,
                p=6 -> 0.
             */

            int bit = n & (1 << (p - 1));
            return bit == 0 ? 0 : 1;

        }

        public static bool CheckBitPosition(int n, int p) // Exercise 12
        {
            /*
               Write a Boolean expression that checks if the bit on position p in the
                integer n has the value 1. Example v=5, p=1 -> false.
             */

            int bit = n & (1 << (p - 1));
            return bit != 0;
        }

        public static int ChangeValueOfBit(int n, byte v, byte p) // Exercise 13
        {
            /*
             We are given the number n, the value v (v = 0 or 1) and the position p.
                write a sequence of operations that changes the value of n, so the bit on
                the position p has the value of v. Example: n=35, p=5, v=0 -> n=3.
                Another example: n=35, p=2, v=1 -> n=39.
             */
            if (v != 1 && v != 0) return 0;
            return v == 1 ? n | (1 << (p - 1)) : n & ~(1 << (p - 1));
        }

        public static bool CheckPrime(int value) // Exercise 14
        {
            /*
              Write a program that checks if a given number n (1 < n < 100) is a
                prime number (i.e. it is divisible without remainder only to itself and 1).
             */

            if (value == 1) return false;
            if (value == 2) return true;

            for (int i = 2; i <= value / 2; i++)
            {
                if (value % i == 0) return false;
            }
            return true;
        }

        public static int ExchangeBits(int n)
        {
            /*
                 Write a program that exchanges the values of the bits on positions
                 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned
                 integer.
             */

            byte _3v = (n & (1 << 2)) == 0 ? (byte)0 : (byte)1; // 0001
            byte _4v = (n & (1 << 3)) == 0 ? (byte)0 : (byte)1;
            byte _5v = (n & (1 << 4)) == 0 ? (byte)0 : (byte)1;

            byte _24v = (n & (1 << 23)) == 0 ? (byte)0 : (byte)1;
            byte _25v = (n & (1 << 24)) == 0 ? (byte)0 : (byte)1;
            byte _26v = (n & (1 << 25)) == 0 ? (byte)0 : (byte)1;

            n = ChangeValueOfBit(n, _3v, 23);
            n = ChangeValueOfBit(n, _4v, 24);
            n = ChangeValueOfBit(n, _5v, 25);

            n = ChangeValueOfBit(n, _24v, 2);
            n = ChangeValueOfBit(n, _25v, 3);
            n = ChangeValueOfBit(n, _26v, 4);

            return n;
        }

        public static int ExchangeBitValues(int n)
        {
            /*
              Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q,
                    q+1, …, q+k-1} of a given 32-bit unsigned integer.
             */

            return 0;
        }

    }
}
