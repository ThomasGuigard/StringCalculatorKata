namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal result = 0;
            Operation operators =  new Operation(operation);
            operators.FindAnswer();
            return result;
        }
    }
}