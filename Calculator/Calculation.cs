using System;
using System.Linq.Expressions;

namespace Calculator
{
    public class Calculation<T>
    {
        public T Multiply<T>(T a, T b)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "a"),
                paramB = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Multiply(paramA, paramB);

            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return add(a, b);
        }

        public T Divide<T>(T a, T b)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "a"),
                paramB = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Divide(paramA, paramB);

            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return add(a, b);
        }

        public T Subtract<T>(T a, T b)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "a"),
                paramB = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Subtract(paramA, paramB);

            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return add(a, b);
        }

        public T Sum<T>(T a, T b)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "a"),
                paramB = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Add(paramA, paramB);

            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            return add(a, b);
        }
    }
}
