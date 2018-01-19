using System;
using Cycles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclesTests
{
    [TestClass]
    public class PalindromTests
    {
        [TestMethod]
        public void TestPalindromeWithLowestValue()
        {
            //Act
            bool result = Program.Palindrome(-1000000);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestPalindromWithMaxValue()
        {
            bool result = Program.Palindrome(1000000);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestPalindromeWithZero()
        {
            bool result = Program.Palindrome(0);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPalindromeWithSingleDigit()
        {
            bool result = Program.Palindrome(9);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPalindromeWithSameDigits()
        {
            bool result = Program.Palindrome(33333);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPalindromWithDifferentDigits()
        {
            bool result = Program.Palindrome(237732);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPalindromOutOfMaxRange()
        {
            Program.Palindrome(1000001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPalindromOutOfMinRange()
        {
            Program.Palindrome(-1000001);
        }

    }
}
