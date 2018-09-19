namespace Algorithms.Exercises.operators_and_expressions
{
    public static class OperatorsAndExpressions
    {
        public static string IsOddOrEven(int value)
        {
            /*
            * Write an expression that checks whether an integer is odd or even.
            */

            return (value & 1) == 0 ? "even" : "odd";
        }

        public static bool IsDivisibleBothDivisor(int value, int divisor1, int divisor2)
        {
            /*
             * Write a Boolean expression that checks whether a given integer is
                divisible by both divisor1 and divisor2, without a remainder.
             */
            if (divisor1 != 0 && divisor2 != 0)
                return value % divisor1 == 0 && value % divisor2 == 0;
            return false;
        }
    }
}
