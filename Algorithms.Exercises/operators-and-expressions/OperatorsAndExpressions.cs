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


    }
}
