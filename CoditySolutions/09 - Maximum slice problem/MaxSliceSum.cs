using System.Linq;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class MaxSliceSum
    {
        // 100/100
        public int solution(int[] A)
        {
            if (A.Max() < 0) return A.Max();

            var cS = 0;
            var mS = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var value = A[i];
                cS = cS + value > 0 ? cS + value : 0;
                mS = cS > mS ? cS : mS;
            }

            return mS;
        }

        [TestCase(new [] {1, 2, 3}, 6)]
        [TestCase(new [] {3, 2, -6, 4, 0}, 5)]
        [TestCase(new [] {-5, -3, -6, 10, -3}, 10)]
        [TestCase(new [] {-5, 9, 2, -6, 10, -3}, 15)]
        [TestCase(new [] {-5, 10, -6, 2, 9, -3}, 15)]
        [TestCase(new [] {-5, 10, -60, 2, 9, -3}, 11)]
        public void Tests(int[] input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(input));
        }
    }
}