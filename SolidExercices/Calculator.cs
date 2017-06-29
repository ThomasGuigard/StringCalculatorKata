using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal result = 0;
            char[] operators = {'+', '-', '*', '/'};

            foreach (var myOperator in operators)
            {
                if (!operation.Contains(myOperator))
                {
                    continue;  
                }

                var sousOperations = operation.Split(myOperator);
                result = Convert.ToDecimal(sousOperations[0]);

                foreach (string t in sousOperations)
                {
                    var chiffre = Convert.ToDecimal(t);

                    switch (myOperator)
                    {
                        case '+':
                            result = result + chiffre;
                            break;

                        case '-':
                            result = result - chiffre;
                            break;

                        case '*':
                            result = result / chiffre;
                            break;

                        case '/':
                            try
                            {
                                result = result / chiffre;
                            }
                            catch (DivideByZeroException)
                            {
                                String error = "La division par 0 est impossible ! Rentrez une autre valeur..";
                                Console.WriteLine(error);
                            }
                            break;
                    }
                }

                
            }


            return result;
        }
    }
}