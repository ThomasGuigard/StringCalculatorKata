using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateANegSum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1-2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateAPosSubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateANegSubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1-9,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateADivWithZero()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,0");
            Check.That(result).IsEqualTo(3.3);
        }
    }
}
