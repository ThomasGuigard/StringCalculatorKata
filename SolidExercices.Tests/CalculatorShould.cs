using System;
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
            Check.That(result).IsEqualTo(3.3m);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("6x2,2x8");
            Check.That(result).IsEqualTo(105.6m);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("45-57,5-42-38");
            Check.That(result).IsEqualTo(-92.5m);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("68/2/4");
            Check.That(result).IsEqualTo(8.5m);
        }

        [Test]
        public void CalculateADivisionByZero()
        {
            var calculator = new Calculator();
            Check.ThatCode(() => calculator.Calculate("48/0")).Throws<ArgumentException>();
        }

        [Test]
        public void NotACalcul()
        {
            var calculator = new Calculator();
            Check.ThatCode(() => calculator.Calculate("Pas un calcul")).Throws<ArgumentException>();
        }

        [Test]
        public void EmptyCalcul()
        {
            var calculator = new Calculator();
            Check.ThatCode(() => calculator.Calculate("")).Throws<ArgumentException>();
        }
    }
}
