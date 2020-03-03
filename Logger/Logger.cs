using System;
using System.Reflection;

namespace Logger
{
    public class Logger<T>
    {
        public PropertyInfo[] GetProperties(T item) =>
            item.GetType().GetProperties();

        public void PrintProperties(PropertyInfo[] properties, T item)
        {
            foreach (var property in properties)
            {
                Console.WriteLine("Property's name: " + property.Name);
                Console.WriteLine("Property's value: " + property.GetValue(item).ToString());
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}

