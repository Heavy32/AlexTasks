using System;

namespace AlphabetDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            IAlphabet alphabet = new Alphabet();

            alphabet = new VowelsLowerCaseDecorator(alphabet);
            alphabet = new StrangeODecorator(alphabet);

            Console.WriteLine(alphabet.GetO());
        }
    }
}
