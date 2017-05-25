using System;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class OddOccurrencesInArray
    {
        // 100/100
        public int solution(int[] A)
        {
            Array.Sort(A);

            for (int index = 0; index < A.Length; index+=2)
            {
                if (index+1 == A.Length)
                    return A[index];

                if (A[index] != A[index + 1])
                    return A[index];
            }

            return 0;
        }

        [TestCase(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void Tests(int[] input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(input));
        }
    }
}