using NUnit.Framework;
using System;

namespace Kata.Tests
{
    [TestFixture]
    class KataTestClass
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Assert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
            Assert.AreEqual(new int[] { 0, 0, 0 }, Kata.SortArray(new int[] { 0, 0, 0 }));
            Assert.AreEqual(new int[] { 1, 3, 5, 7 }, Kata.SortArray(new int[] { 3, 1, 7, 5 }));
            Assert.AreEqual(new int[] { 2, 4, 8, 6}, Kata.SortArray(new int[] { 2, 4, 8, 6 }));
        }

    }
}