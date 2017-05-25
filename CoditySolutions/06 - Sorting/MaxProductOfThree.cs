using System;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class MaxProductOfThree
    {
        // 100/100
        public int solution(int[] A)
        {
            if (A.Length < 3) return 0;

            Array.Sort(A);

            var last = A.Length-1;

            var max1 = A[last] * A[last - 1] * A[last - 2];
            var max2 = A[last] * A[0] * A[1];

            return Math.Max(max1, max2);
        }

        [TestCase(new[] { 1, 2, 3, 20, 10, 1, 10 }, 2000)]
        [TestCase(new[] { 1, 1, 1, 1, 1, 1, 1 }, 1)]
        [TestCase(new[] { -1, -2, -3, -20, -10, -1, -10 }, -2)]
        public void Tests(int[] input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(input));
        }
    }
}