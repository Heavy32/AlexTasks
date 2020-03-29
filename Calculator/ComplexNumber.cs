using System;

namespace Calculator
{
    public class ComplexNumber 
    {
        private int real;
        private int image;

        public ComplexNumber(int real, int image)
        {
           
            this.real = real;
            this.image = image;
        }

        public override bool Equals(Object obj)
        {
            var other = (ComplexNumber)obj;
            if (this.real == other.real || this.image == other.image)
                return true;
            return false;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) => new ComplexNumber(a.real + b.real, a.image + b.image);
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) => new ComplexNumber(a.real - b.real, a.image - b.image);
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b) => new ComplexNumber(a.real * b.real - b.image * a.image, a.real * b.image + a.image * b.real);
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            var numerator = a * (new ComplexNumber(b.real, -b.image));
            var denominator = b * (new ComplexNumber(b.real, -b.image));
            return new ComplexNumber(numerator.real / denominator.real, numerator.image / denominator.real);
        }
    }
}
