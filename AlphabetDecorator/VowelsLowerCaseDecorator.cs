using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetDecorator
{
    public class VowelsLowerCaseDecorator : AlphabetDecorator
    {
        public VowelsLowerCaseDecorator(IAlphabet decorator) : base(decorator)
        {}

        public override char GetA()
        {
            return Char.ToLower(base.GetA());
        }

        public override char GetE()
        {
            return Char.ToLower(base.GetE());
        }

        public override char GetI()
        {
            return Char.ToLower(base.GetI());
        }

        public override char GetO()
        {
            return Char.ToLower(base.GetO());
        }

        public override char GetU()
        {
            return Char.ToLower(base.GetU());
        }

        public override char GetY()
        {
            return Char.ToLower(base.GetY());
        }
    }
}
