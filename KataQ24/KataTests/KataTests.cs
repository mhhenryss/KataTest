using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Kata.Tests
{
    [TestFixture]
    public class Sample_Test
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new[] { new List<int> { 1, 3, 5, 9, 11 } }).Returns(7);
                yield return new TestCaseData(new[] { new List<int> { 0, 5, 10, 20, 25 } }).Returns(15);
                yield return new TestCaseData(new[] { new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 } }).Returns(10);
                yield return new TestCaseData(new[] { new List<int> { 1040, 1220, 1580 } }).Returns(1400);
                yield return new TestCaseData(new[] { new List<int> { 19, 17, 13, 11 } }).Returns(15);
                yield return new TestCaseData(new[] { new List<int> { 4, 2, -2, -4 } }).Returns(0);
                yield return new TestCaseData(new[] { new List<int> { -22, -16, -13, -10 } }).Returns(-19);
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(List<int> list) => Kata.FindMissing(list);
    }
}