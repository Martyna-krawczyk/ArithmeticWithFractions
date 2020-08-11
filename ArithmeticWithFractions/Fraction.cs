using System;
using System.Reflection.Metadata.Ecma335;

namespace ArithmeticWithFractions
{
    public class Fraction
    {
        private int _integerValue { get; set; }

        public Fraction(int integerValue)
        {
            _integerValue = integerValue;
        }

        public Fraction Plus(Fraction fraction)
        {
            if (fraction._integerValue != 0)
            {
                return new Fraction(this._integerValue + fraction._integerValue);
            }
            else
            {
                return this;
            }
        }

        public int IntValue()
        {
            return _integerValue;
        }
    }
}
