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
            return new Fraction(this._integerValue + fraction._integerValue);
        }

        public int IntValue()
        {
            return _integerValue;
        }
    }
}
