using NUnit.Framework;
using System;

namespace Kata.Tests
{
    [TestFixture]
    class KataTestClass
    {
        [Test]
        public void BasicTest()
        {
            var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
            Assert.AreEqual(12, Kata.HighestRank(arr));
            var arr1 = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
            Assert.AreEqual(12, Kata.HighestRank(arr1));
            var arr2 = new int[] { 1, 2 };
            Assert.AreEqual(2, Kata.HighestRank(arr2));
            var arr3 = new int[] { 3 };
            Assert.AreEqual(3, Kata.HighestRank(arr3));
            var arr4 = new int[] { 5, 5 };
            Assert.AreEqual(5, Kata.HighestRank(arr4));
            var arr5 = new int[] { 5, 5, 5, 6, 6, 6, 7, 8, 8, 8 };
            Assert.AreEqual(8, Kata.HighestRank(arr5));
            var arr6 = new int[] { 5, 4, 3, 2, 1 };
            Assert.AreEqual(5, Kata.HighestRank(arr6));
        }

    }
}