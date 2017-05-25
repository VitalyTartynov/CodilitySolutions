using System;
using System.Linq;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class MaxProfit
    {
        // 100/100
        public int solution(int[] A)
        {
            if (A.Length <= 1) return 0;
            var diff = new int[A.Length];
            diff[0] = 0;

            for (int i = 1; i < A.Length; i++)
            {
                diff[i] = A[i] - A[i - 1];
            }

            return MaxProfitOnDiff(diff);
        }

        private int MaxProfitOnDiff(int[] diff)
        {
            var mE = 0;
            var mS = 0;

            if (diff.Max() < 0) return 0;

            for (int i = 0; i < diff.Length; i++)
            {
                var cur = diff[i];
                mE = mE + cur > 0 ? mE + cur : 0;
                mS = mS > mE ? mS : mE;
            }

            return mS;
        }

        [TestCase(new [] {8, 20, 15, 21, 17}, 13)]
        [TestCase(new [] {10, 5, 3, 1}, 0)]
        [TestCase(new [] {23171, 21011, 21123, 21366, 21013, 21367}, 356)]
        public void Tests(int[] input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(input));
        }
    }
}