using System;
using FluentAssertions;
using Xunit;

namespace tdd_kata.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void WhenEmptyString_ShouldBe0()
        {
            var sut = new StringCalculator();
            var result = sut.Add(string.Empty);
            result.Should().Be(0);
        }

        [Fact]
        public void WhenSingleChar_ShouldBeCharParsed()
        {
            var sut = new StringCalculator();
            var result = sut.Add("4");
            result.Should().Be(4);
        }

        [Fact]
        public void WhenTwoCommaDelimited_ShouldReturnSum()
        {
            var sut = new StringCalculator();
            var result = sut.Add("10,20");
            result.Should().Be(30);
        }

        [Fact]
        public void WhenTwoNewLineDelimited_ShouldReturnSum()
        {
            var sut = new StringCalculator();
            var result = sut.Add("1\n2");
            result.Should().Be(3);
        }

        [Fact]
        public void WhenDifferentlyDelimited_ShouldReturnSum()
        {
            var sut = new StringCalculator();
            var result = sut.Add("1\n2,3");
            result.Should().Be(6);
        }

        [Fact]
        public void WhenNegatives_ShouldThrowArgumentException()
        {
            var sut = new StringCalculator();
            var act = new Action(() => sut.Add("-1,2,-3"));
            act.Should().Throw<ArgumentException>();
        }
    }
}