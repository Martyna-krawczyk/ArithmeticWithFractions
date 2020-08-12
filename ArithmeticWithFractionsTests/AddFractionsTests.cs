using System;
using ArithmeticWithFractions;
using Xunit;

namespace ArithmeticWithFractionsTests
{
    public class AddFractionsTests
    {
        [Fact]
        public void ZeroPlusZero()
        {
            Assert.Equal(0, new Fraction(0).Plus(new Fraction(0)).IntValue());
        }

        [Fact]
        public void NonZeroPlusZero()
        {
            Assert.Equal(3, new Fraction(3).Plus(new Fraction(0)).IntValue());
        }
        
        [Fact]
        public void ZeroPlusNonZero()
        {
            Assert.Equal(5, new Fraction(0).Plus(new Fraction(5)).IntValue());
        }
        
        [Fact]
        public void NonNegativeNonZeroOperands()
        {
            Assert.Equal(7, new Fraction(3).Plus(new Fraction(4)).IntValue());
        }

        [Fact]
        public void NegativeInputsAndNegativeOutputs()
        {
            Assert.Equal(-2, new Fraction(-3).Plus(new Fraction(1)).IntValue());
        }
    }
}
