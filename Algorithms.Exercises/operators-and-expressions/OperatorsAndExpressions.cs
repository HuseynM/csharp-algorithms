namespace Algorithms.Exercises.operators_and_expressions
{
    public class OperatorsAndExpressions
    {
        public string IsOddOrEven(int value)
        {
            /*
            * Write an expression that checks whether an integer is odd or even.
            */

            return (value & 1) == 0 ? "even" : "odd";
        }
    }
}
