using System;
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
            return this;
        }

        public int IntValue()
        {
            return _integerValue;
        }
    }
}
