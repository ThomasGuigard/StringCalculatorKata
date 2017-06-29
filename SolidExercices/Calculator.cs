using System;
using System.CodeDom;
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
        
            String[] sousOperations;

            foreach (var myOperator in operators)
            {
                if (!operation.Contains(myOperator))
                {
                    continue;  
                }

                sousOperations = operation.Split(myOperator);
                result = Convert.ToDecimal(sousOperations[0]);

                for (int i = 1; i < sousOperations.Length; i++)
                {
                    decimal chiffre = Convert.ToDecimal(sousOperations[i]);

                    switch (myOperator)
                    {
                        case '+':
                            result = result + chiffre;
                            break;

                        case '-':
                            result = result - chiffre;
                            break;

                        case '*':
                            result = result * chiffre;
                            break;

                        case '/':
                            try
                            {
                                result = result / chiffre;
                            }
                            catch (DivideByZeroException)
                            {
                                var error = "La division par 0 est impossible ! Rentrez une autre valeur..";
                                throw new ArgumentException(error);
                            }
                            break;
                    }
                }

                
            }


            return result;
        }
    }
}