using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class CalculatorException : Exception
    {
        public CalculatorException()
        {
        }

        public CalculatorException(string message) : base(message)
        {
        }

        public CalculatorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CalculatorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
