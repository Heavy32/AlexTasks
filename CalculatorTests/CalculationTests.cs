using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculationTests
    {
        [Test]
        public void IntSumOf20and10()
        {
            // Setup
            Math<int> math = new Math<int>();
            //Calculation<int> calculation = new Calculator.Calculation<int>();

            //Assert
            Assert.AreEqual(40, math.Sum(20, 20));
            //Assert.AreEqual(30, calculation.Sum(10, 20));
        }

        [Test]
        public void IntMultiplyOf20and10()
        {
            // Setup
            Calculation<int> calculation = new Calculator.Calculation<int>();

            //Assert
            Assert.AreEqual(200, calculation.Multiply(10, 20));
        }

        [Test]
        public void FloatDivideOf20and10()
        {
            // Setup
            Calculation<float> calculation = new Calculator.Calculation<float>();

            //Assert
            Assert.AreEqual(0.5f, calculation.Divide(10f, 20f));
        }

        [Test]
        public void DecimalSubtractOf20and10()
        {
            // Setup
            Calculation<float> calculation = new Calculator.Calculation<float>();

            //Assert
            Assert.AreEqual(-10.0, calculation.Subtract(10.0, 20.0));
        }
    }
}