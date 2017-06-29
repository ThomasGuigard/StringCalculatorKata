namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            Operation operators =  new Operation(operation);
            return operators.FindAnswer(); ;
        }
    }
}