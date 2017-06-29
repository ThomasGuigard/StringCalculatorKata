namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            Operation myOperation =  new Operation(operation);
            return myOperation.FindAnswer(); ;
        }
    }
}