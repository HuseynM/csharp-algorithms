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
                divisible by both 5 and 7, without a remainder.
             */

            return value % divisor1 == 0 && value % divisor2 == 0;
        }
    }
}
