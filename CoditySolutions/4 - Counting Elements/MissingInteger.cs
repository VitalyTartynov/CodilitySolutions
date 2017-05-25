using System;
using System.Linq;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class MissingInteger
    {
        // 77/100
        public int solution(int[] A)
        {
            if (A.Length == 0) return 0;

            Array.Sort(A);
            A = A.Where(x => x > 0).Distinct().ToArray();

            if (A.Length == 1) return A[0] + 1;
            
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != i + 1) return i + 1;
            }

            return A.Length + 1;
        }

        [TestCase(new [] {1, 2, 4}, 3)]
        [TestCase(new [] {1, 3, 6, 4, 1, 2}, 5)]
        [TestCase(new [] {1, 1, 1, 1, 1, 1}, 2)]
        [TestCase(new [] {-1, -2, -3, -4}, 1)]
        public void Tests(int[] input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(input));
        }
    }
}