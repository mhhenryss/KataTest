using NUnit.Framework;
using System;

namespace Kata.Tests
{
    [TestFixture]
    class KataTestClass
    {
        [Test]
        [TestCase("foefet", "toffee", ExpectedResult = true)]
        [TestCase("Buckethead", "DeathCubeK", ExpectedResult = true)]
        [TestCase("Twoo", "Woot", ExpectedResult = true)]
        [TestCase("apple", "pale", ExpectedResult = false)]
        [TestCase("", "", ExpectedResult = true)]
        [TestCase("a", "", ExpectedResult = false)]
        [TestCase("", "a", ExpectedResult = false)]
        public static bool FixedTest(string test, string original)
        {
            return Kata.IsAnagram(test, original);
        }

    }
}