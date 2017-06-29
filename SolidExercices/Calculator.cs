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
            char[] operators = {'+', '-', 'x', '/'};
            int ct = 1;
            var error = "Opération impossible";
            String[] sousOperations;


            if (String.IsNullOrEmpty(operation) || !operators.Any(operation.Contains))
            {
                throw new ArgumentException(error);
            }

            foreach (var myOperator in operators)
            {
              
                if (!operation.Contains(myOperator))
                {
                    continue;  
                }

                sousOperations = operation.Split(myOperator);

                try
                {
                    result = Convert.ToDecimal(sousOperations[0]);
                }
                catch (Exception e)
                {
                    error = "Valeur incorrect : " + sousOperations[0];
                    throw new ArgumentException(error);
                }
                

                for (int i = 1; i < sousOperations.Length; i++)
                {
                    decimal chiffre;

                    try
                    {
                        chiffre = Convert.ToDecimal(sousOperations[i]);
                    }
                    catch (Exception e)
                    {
                        error = "Valeur incorrect : " + sousOperations[i];
                        throw new ArgumentException(error);
                    }

                    switch (myOperator)
                    {
                        case '+':
                            result = result + chiffre;
                            break;

                        case '-':
                            result = result - chiffre;
                            break;

                        case 'x':
                            result = result * chiffre;
                            break;

                        case '/':
                            try
                            {
                                result = result / chiffre;
                            }
                            catch (DivideByZeroException)
                            {
                                error = "La division par 0 est impossible ! Rentrez une autre valeur..";
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