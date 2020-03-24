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

            //Assert
            Assert.AreEqual(30, math.Sum(20, 10));
        }

        [Test]
        public void IntMultiplyOf20and10()
        {
            // Setup
            Math<int> math = new Math<int>();

            //Assert
            Assert.AreEqual(200, math.Multiply(20, 10));
        }

        [Test]
        public void FloatDivideOf20and10()
        {
            // Setup
            Math<int> math = new Math<int>();

            //Assert
            Assert.AreEqual(2, math.Divide(20, 10));
        }

        [Test]
        public void DecimalSubtractOf20and10()
        {
            // Setup
            Math<decimal> math = new Math<decimal>();

            //Assert
            Assert.AreEqual(10, math.Subtract(20, 10));
        }
    }
}