using NUnit.Framework;
using System;

namespace Kata.Tests
{
    [TestFixture]
    public class KataTest
    {
        [TestCase(new[] { -1, -2, -3 }, ExpectedResult = 0)]
        [TestCase(new int[0], ExpectedResult = 0)]
        [TestCase(new[] { 1, 2, 3, 4 }, ExpectedResult = 10)]
        [TestCase(new[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 }, ExpectedResult = 187)]
        [TestCase(new[] { 0, 0, 0, 0 }, ExpectedResult = 0)]
        [TestCase(new[] { 10, -21, 5, 8, -33 }, ExpectedResult = 13)]
        [TestCase(new[] { 1, 0, 3, 0, 5 }, ExpectedResult = 9)]
        public int TestFromDescription(int[] arr)
        {
            return Kata.LargestSum(arr);
        }
    }
}