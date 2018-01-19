using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods;

namespace MethodsTests
{
    [TestClass]
    public class BasicMethodsTests
    {
        [TestMethod]
        public void TestSumWithOneNumber()
        {
            Assert.AreEqual(21, BasicMethods.Sum(6));
        }

        [TestMethod]
        public void TestSumWithNegativeNumber()
        {
            Assert.AreEqual(-15, BasicMethods.Sum(-5));
        }

        [TestMethod]
        public void TestSumWithZero()
        {
            Assert.AreEqual(0, BasicMethods.Sum(0));
        }

        [TestMethod]
        public void TestAverageWithPositiveNumber()
        {
            Assert.AreEqual(3.5, BasicMethods.Average(6));
        }

        [TestMethod]
        public void TestAverageWithZero()
        {
            Assert.AreEqual(1.5, BasicMethods.Average(2));
        }
    }
}
