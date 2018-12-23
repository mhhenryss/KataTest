using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Kata.Tests
{
    [TestFixture]
    class KataTestClass
    {
        [Test]
        public static void Level1()
        {
            CollectionAssert.AreEqual(new List<int> { }, Kata.PascalsTriangle(0));
            CollectionAssert.AreEqual(new List<int> { 1}, Kata.PascalsTriangle(1));
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1}, Kata.PascalsTriangle(2));
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1 }, Kata.PascalsTriangle(3));
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 }, Kata.PascalsTriangle(4));
        }

    }
}