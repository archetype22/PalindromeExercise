using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("raCecar", true)] // ← you will need to put some test data and expected result here.  
        [InlineData("woW", true)]
        [InlineData("mOm", true)]
        [InlineData("noOn", true)]
        [InlineData("banana", false)]

        // For example [InlineData(“racecar”, true)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange

            var instance = new WordSmith();

            //Act

            var actual = instance.IsAPalindrome(word);

            //Assert

            Assert.Equal(expected, actual);
        }
    }
}
