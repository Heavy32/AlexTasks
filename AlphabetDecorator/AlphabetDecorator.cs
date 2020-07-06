using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetDecorator
{
    public abstract class AlphabetDecorator : IAlphabet
    {
        private readonly IAlphabet decorator;

        protected AlphabetDecorator(IAlphabet decorator)
        {
            this.decorator = decorator;
        }

        public virtual char GetA()
        {
            return decorator.GetA();
        }

        public virtual char GetB()
        {
            return decorator.GetB();
        }

        public virtual char GetC()
        {
            return decorator.GetC();
        }

        public virtual char GetD()
        {
            return decorator.GetD();
        }

        public virtual char GetE()
        {
            return decorator.GetE();
        }

        public virtual char GetF()
        {
            return decorator.GetF();
        }

        public virtual char GetG()
        {
            return decorator.GetG();
        }

        public virtual char GetH()
        {
            return decorator.GetH();
        }

        public virtual char GetI()
        {
            return decorator.GetI();
        }

        public virtual char GetJ()
        {
            return decorator.GetJ();
        }

        public virtual char GetK()
        {
            return decorator.GetK();
        }

        public virtual char GetL()
        {
            return decorator.GetL();
        }

        public virtual char GetM()
        {
            return decorator.GetM();
        }

        public virtual char GetN()
        {
            return decorator.GetN();
        }

        public virtual char GetO()
        {
            return decorator.GetO();
        }

        public virtual char GetP()
        {
            return decorator.GetP();
        }

        public virtual char GetQ()
        {
            return decorator.GetQ();
        }

        public virtual char GetR()
        {
            return decorator.GetR();
        }

        public virtual char GetS()
        {
            return decorator.GetS();
        }

        public virtual char GetT()
        {
            return decorator.GetT();
        }

        public virtual char GetU()
        {
            return decorator.GetU();
        }

        public virtual char GetV()
        {
            return decorator.GetV();
        }

        public virtual char GetW()
        {
            return decorator.GetW();
        }

        public virtual char GetX()
        {
            return decorator.GetX();
        }

        public virtual char GetY()
        {
            return decorator.GetY();
        }

        public virtual char GetZ()
        {
            return decorator.GetZ();
        }
    }
}
