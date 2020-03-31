using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestFixture()]
    public class MathComplexTests
    {
        [Test()]
        public void SumTest()
        {
            MathComplex mathComplex = new MathComplex();

            Assert.AreEqual(mathComplex.Sum(new ComplexNumber(1, 3), new ComplexNumber(2, 1)), new ComplexNumber(3, 3));
        }

        [Test()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void DivideTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SubtractTest()
        {
            Assert.Fail();
        }
    }
}