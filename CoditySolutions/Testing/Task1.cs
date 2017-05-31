using System;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class Task1
    {
        // ?/100
        public int solution(int[] A)
        {
            int n = A.Length;
            int result = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (A[i] == A[i + 1])
                    result = result + 1;
            }
            int r = -1;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                if (i > 0)
                {
                    if (A[i - 1] != A[i])
                        count = count + 1;
                    else
                        count = count - 1;
                }
                if (i < n - 1)
                {
                    if (A[i + 1] != A[i])
                        count = count + 1;
                    else
                        count = count - 1;
                }
                r = Math.Max(r, count);
            }

            return result + r;
        }

        [TestCase(new[] { 1, 1, 0, 1, 0, 0 }, 4)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 0, 0 }, 0)]
        [TestCase(new[] { 1, 0 }, 1)]
        [TestCase(new[] { 1, 1 }, 0)]
        [TestCase(new[] { 0, 0, 0 }, 1)]
        [TestCase(new[] { 1, 0, 0 }, 2)]
        [TestCase(new[] { 0, 1, 0 }, 2)]
        [TestCase(new[] { 0, 0, 1 }, 2)]
        [TestCase(new[] { 0, 1, 1 }, 2)]
        [TestCase(new[] { 1, 1, 0 }, 2)]
        [TestCase(new[] { 1, 0, 1 }, 2)]
        [TestCase(new[] { 1, 1, 1 }, 1)]
        public void Tests(int[] inputArray, int expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(inputArray));
        }
    }
}