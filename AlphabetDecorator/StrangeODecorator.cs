using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetDecorator
{
    public class StrangeODecorator : AlphabetDecorator
    {
        public StrangeODecorator(IAlphabet decorator) : base(decorator)
        {
        }

        public override char GetO()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            return '\u00F8';
        }
    }
}
