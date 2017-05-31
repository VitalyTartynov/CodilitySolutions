using System;
using NUnit.Framework;

namespace CoditySolutions
{
    /*
     * Find an index in an array such that its prefix sum equals its suffix sum.
     */

    [TestFixture]
    public class Equi
    {
        // 100/100
        public int solution(int[] A)
        {
            if (A.Length == 0) return -1;

            long sum = 0;
            int i;

            for (i = 0; i < A.Length; i++) sum += A[i];

            long sum_left = 0;
            for (i = 0; i < A.Length; i++)
            {
                long sum_right = sum - sum_left - A[i];
                if (sum_left == sum_right) return i;
                sum_left += A[i];
            }

            return -1;
        }

        [TestCase(new[] { -1, 3, -4, 5, 1, -6, 2, 1 }, 1)]
        public void Tests(int[] inputArray, int expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(inputArray));
        }
    }
}