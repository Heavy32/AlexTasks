using System;
using System.Linq.Expressions;

namespace Calculator
{
    public class Operation
    {
        public delegate BinaryExpression Calculation(Expression a, Expression b);

        public virtual T Act<T>(T a, T b, Calculation calculation)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "a"),
            paramB = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = calculation(paramA, paramB);

            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return add(a, b);
        }
    }
}
