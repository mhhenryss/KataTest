using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Kata.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, Kata.Solution(10));
            Assert.AreEqual(60, Kata.Solution(16));
            Assert.AreEqual(258, Kata.Solution(34));
        }
    }
}