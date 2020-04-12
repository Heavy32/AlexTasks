using System.Linq.Expressions;
using System;

namespace Calculator
{
    public class Math<T> 
    {
        private Operation operation;

        public Math()
        {
            operation = new Operation();
        }

        public T Sum(T a, T b)
        {
            Operation.Calculation calculation = Expression.Add;
            return operation.Act<T>(a, b, calculation);
        }

        public T Multiply(T a, T b)
        {
            Operation.Calculation calculation = Expression.Multiply;
            return operation.Act<T>(a, b, calculation);
        }

        public T Divide(T a, T b)
        {
            Operation.Calculation calculation = Expression.Divide;
            return operation.Act<T>(a, b, calculation);
        }

        public T Subtract(T a, T b)
        {
            Operation.Calculation calculation = Expression.Subtract;
            return operation.Act<T>(a, b, calculation);
        }
    }
}
