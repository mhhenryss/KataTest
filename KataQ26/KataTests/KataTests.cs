using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Kata.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual("sihT si na !elpmaxe", Kata.ReverseWords("This is an example!"));
            Assert.AreEqual("", Kata.ReverseWords(""));
            Assert.AreEqual(" ", Kata.ReverseWords(" "));
            Assert.AreEqual("a", Kata.ReverseWords("a"));
            Assert.AreEqual(" ba ab", Kata.ReverseWords(" ab ba"));
            Assert.AreEqual(" ba ab ", Kata.ReverseWords(" ab ba "));
        }
    }
}