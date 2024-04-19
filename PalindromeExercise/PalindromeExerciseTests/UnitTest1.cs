using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("level", true)]
        public void IsAPalindrome_Test(string input, bool expected)
        {
            // Arrange
            var wordSmith = new PalindromeExerciseTests.WordSmith();

            // Act
            bool result = wordSmith.IsAPalindrome(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
