using System;
using Xunit;
using Isogram;
using FluentAssertions;
namespace Isogram.Tests
{
    public class IsogramTests
    {
        [Fact]
        public void TestForEmptyString()
        {
			Isogram.IsIsogram("").Should().BeTrue();
        }
		[Fact]
		public void TestForIsogram() {
			Isogram.IsIsogram("isogram").Should().BeTrue();
		}
		[Fact]
		public void TestForEleven()
		{
			Isogram.IsIsogram("eleven").Should().BeFalse();
		}
		[Fact]
		public void TestForSubdermatoglyphic()
		{
			Isogram.IsIsogram("subdermatoglyphic").Should().BeTrue();
		}
		[Fact]
		public void TestForDuplicateCharInDifferentCase()
		{
			Isogram.IsIsogram("Alphabet").Should().BeTrue();
		}
		[Fact]
		public void TestForStringWithHyphen()
		{
			Isogram.IsIsogram("thumbscrew-japingly").Should().BeTrue();
		}
		[Fact]
		public void TestForStringWithDuplicateHyphen()
		{
			Isogram.IsIsogram("six-year-old").Should().BeTrue();
		}
		[Fact]
		public void TestForStringWithSpaces()
		{
			Isogram.IsIsogram("thumbscrew japingly").Should().BeTrue();
		}

	}
}
