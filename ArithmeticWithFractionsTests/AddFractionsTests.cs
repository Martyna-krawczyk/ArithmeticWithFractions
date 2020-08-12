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
            var sum = new Fraction(0).Plus(new Fraction(0));

            Assert.Equal(0, sum.IntValue());
        }

        [Fact]
        public void NonZeroPlusZero()
        {
            var sum = new Fraction(3).Plus(new Fraction(0));

            Assert.Equal(3, sum.IntValue());
        }
        
        [Fact]
        public void ZeroPlusNonZero()
        {
            var sum = new Fraction(0).Plus(new Fraction(5));

            Assert.Equal(5, sum.IntValue());
        }
        
        [Fact]
        public void NonNegativeNonZeroOperands()
        {
            var sum = new Fraction(3).Plus(new Fraction(4));

            Assert.Equal(7, sum.IntValue());
        }

        [Fact]
        public void NegativeInputsAndNegativeOutputs()
        {
            var sum = new Fraction(-3).Plus(new Fraction(1));

            Assert.Equal(-2, sum.IntValue());
        }

    }
}
