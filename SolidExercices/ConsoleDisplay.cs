using System;


namespace SolidExercices
{
    class ConsoleDisplay : IDisplay
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public void Read()
        {
            Console.ReadKey();
        }
    }
}
