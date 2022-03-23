using System;
using Xunit;
using Lab03_App;

namespace Lab03_Test
{
    public class UnitTest1
    {
        //  Challenge 1 Test
        [Theory]
        [InlineData(new string[] { "1", "2", "3" }, 6)]
        [InlineData(new string[] { "1", "2", "3" ,"4"}, 6)]
        [InlineData(new string[] { "1", "2" }, 0)]
        [InlineData(new string[] { "-1", "-2","-3" }, -6)]
        [InlineData(new string[] { "s", "a","b" }, 1)]
        public void Challenge1Test(string[] inputNumbers, int expectedValue)
        {
            Assert.Equal(expectedValue, Program.MultipliedNumbers(inputNumbers));
        }


        // Challenge 2 Test
        [Theory]
        [InlineData(new int[] { 4 , 8 , 15 , 16 }, 10)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        public void Challenge2Test(int[] inputNumbers, int expectedValue)
        {
            Assert.Equal(expectedValue, Program.AverageNumber(inputNumbers));
        }

        // Challenge 3 Test

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
        [InlineData(new int[] { 2, 3, 4, 5 }, 2)]
        [InlineData(new int[] { 5,2, 2, 3, 3, 4, 4, 5 }, 5)]
        public void Challenge3Test(int[] inputNumbers, int expectedValue)
        {
            Assert.Equal(expectedValue, Program.Duplicates(inputNumbers));
        }

        // Challenge 4 Test

        [Theory]
        [InlineData(new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 }, 555)]
        [InlineData(new int[] { -2, -3, -4, -5 }, -2)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 1)]
        public void Challenge4Test(int[] inputNumbers, int expectedValue)
        {
            Assert.Equal(expectedValue, Program.MaxNum(inputNumbers));
        }

        //  Challenge 5 Test
        [Theory]
        [InlineData("This is a sentance about important things", new string[] { "This: 4", "is: 2", "a: 1", "sentance: 8", "about: 5", "important: 9", "things: 6" })]
        [InlineData("Welcome to console",new string[] { "Welcome: 7", "to: 2" ,"console: 7" })]
        public void Challenge5Test(string inputNumbers, string[] expectedValue)
        {
            Assert.Equal(expectedValue, Program.SentenceSplit(inputNumbers));
        }
    }
}