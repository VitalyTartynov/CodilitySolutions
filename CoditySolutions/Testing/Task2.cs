using System;
using System.Linq;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class Task2
    {
        // ?/100
        public int solution(int[] A)
        {
            var len = A.Length;
            if (len == 0)
                return -1;

            long sum = A.Sum();
            long avg = sum / len;

            long maxDeviation = -1;
            var index = 0;

            for (int i = 0; i < A.Length; i++)
            {
                var value = A[i];
                var localDeviation = Math.Abs(value - avg);
                if (localDeviation > maxDeviation)
                {
                    maxDeviation = localDeviation;
                    index = i;
                }
            }

            return index;
        }

        [TestCase(new[] { 9, 4, -3, -10 }, 3)]
        [TestCase(new int[0] , -1)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 1, 9 }, 0)]
        [TestCase(new[] { -50, +100 }, 0)]
        [TestCase(new[] { -50, -75 }, 1)]
        [TestCase(new[] { -60, 5, 55 }, 0)]
        [TestCase(new[] { 55, 5, -60 }, 2)]
        [TestCase(new[] {1, 1, 1, 1, 1}, 0)]
        [TestCase(new[] { 1, 1, 3, 1, 3 }, 2)]
        public void Tests(int[] inputArray, int expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(inputArray));
        }
    }
}