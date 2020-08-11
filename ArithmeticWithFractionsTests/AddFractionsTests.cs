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

    }
}
