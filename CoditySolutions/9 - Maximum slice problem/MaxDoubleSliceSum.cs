using System;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class MaxDoubleSliceSum
    {
        // 100/100
        public int solution(int[] A)
        {
            var maxStart = new int[A.Length];
            var maxEnd = new int[A.Length];

            for (int i = 1; i < A.Length-1; i++)
            {
                maxStart[i] = Math.Max(maxStart[i - 1] + A[i], 0);
            }

            for (int i = A.Length - 2; i > 0; i--)
            {
                maxEnd[i] = Math.Max(maxEnd[i + 1] + A[i], 0);
            }

            var max = 0;
            for (int i = 1; i < A.Length-1; i++)
            {
                max = Math.Max(maxStart[i - 1] + maxEnd[i + 1], max);
            }

            return max;
        }

        [TestCase(new [] {3, 2, 6, -1, 4, 5, -1, 2}, 17)]
        [TestCase(new [] {1, 2, 3, 4, 5, 6, 7, 8}, 25)]
        [TestCase(new [] {5, 10, -40, 20}, 10)]
        [TestCase(new [] {5, 10, -40, 20, 5}, 30)]
        public void Tests(int[] input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(input));
        }
    }
}