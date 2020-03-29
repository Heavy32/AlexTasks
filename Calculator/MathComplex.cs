using System;

namespace Calculator
{
    public class MathComplex
    {
        public ComplexNumber Sum(ComplexNumber a, ComplexNumber b)
        {
            return a + b;
        }

        public ComplexNumber Multiply(ComplexNumber a, ComplexNumber b)
        {
            return a * b;
        }

        public ComplexNumber Divide(ComplexNumber a, ComplexNumber b)
        {
            return a / b;
        }

        public ComplexNumber Subtract(ComplexNumber a, ComplexNumber b)
        {
            return a - b;
        }
    }
}
