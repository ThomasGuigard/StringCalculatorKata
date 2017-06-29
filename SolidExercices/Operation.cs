using System;
using System.Linq;

namespace SolidExercices
{
    class Operation
    {
        public char[] Type { get; set; }
        public string[] SousOperations { get; set; }

        public string MyOperation { get; set; }

        public Operation(String myOperation)
        {
            MyOperation = myOperation;
            Type = new []{'+', '-', 'x', '/'};
        }

        public decimal FindAnswer()
        {
            GotOperators(MyOperation);

            decimal finalResult = 0;

            foreach (var myOperator in Type)
            {

                if (!MyOperation.Contains(myOperator))
                {
                    continue;
                }

                SousOperations = MyOperation.Split(myOperator);

                finalResult += Calcul(myOperator);

            }

            return finalResult;
        }

        public decimal Calcul(char myOperator)
        {

            decimal result = 0;


            try
            {
                result = Convert.ToDecimal(SousOperations[0]);
            }
            catch (Exception)
            {
                GetError(3);
            }


            for (int i = 1; i < SousOperations.Length; i++)
            {
                decimal chiffre = 0;

                try
                {
                    chiffre = Convert.ToDecimal(SousOperations[i]);
                }
                catch (Exception)
                {
                    GetError(3);
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
                            GetError(2);
                        }
                        break;
                }
            }

            return result;
        }

        public void GotOperators(String operation)
        {
            if (String.IsNullOrEmpty(operation) || !Type.Any(operation.Contains))
            {
                GetError(1);
            }

        }

        public void GetError(int type)
        {
            String error;
            switch (type)
            {
                case 1:
                    error = "Opération impossible";
                    break;
                case 2:
                    error = "La division par 0 est impossible ! Rentrez une autre valeur..";
                    break;
                case 3:
                    error = "Une valeur interdite se trouve au sein de l'opération ! ";
                    break;
                default:
                    error = "Defaut inconnnu";
                    break;
            }
            throw new ArgumentException(error);
        }
    }
}
