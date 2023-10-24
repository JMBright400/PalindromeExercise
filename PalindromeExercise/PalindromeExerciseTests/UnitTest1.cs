using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("madam", true)]
        [InlineData("noon", true)]
        [InlineData("level", true)]
        [InlineData("rotor", true)]
        [InlineData("sunglasses", false)]
        [InlineData("at", false)]
        [InlineData("night", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            var wordsmith = new WordSmith();
            var actual = wordsmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
