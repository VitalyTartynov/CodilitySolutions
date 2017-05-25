using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class CountSemiprimes
    {
        public int[] solution(int N, int[] P, int[] Q)
        {
            var factArray = FactorizationArray(N);
            var semiPrimes = new int[factArray.Length];
            for (var i = 0; i < semiPrimes.Length; i++)
            {
                if (factArray[i] != 0 && factArray[i / factArray[i]] == 0)
                    semiPrimes[i] = 1;
            }
            var preSum = PrefixSum(semiPrimes);
            var result = new int[P.Length];
            for (var i = 0; i < Q.Length; i++)
            {
                result[i] = preSum[Q[i]] - preSum[P[i] - 1];
            }

            return result;
        }

        public static int[] FactorizationArray(int n)
        {
            var result = new int[n + 1];
            for (var i = 2; i * i <= n; i++)
            {
                if (result[i] != 0) continue;

                for (var k = i * i; k <= n; k += i)
                {
                    if (result[k] == 0)
                        result[k] = i;
                }
            }

            return result;
        }

        public static int[] PrefixSum(int[] A)
        {
            var result = new int[A.Length];
            for (var i = 0; i < A.Length; i++)
            {
                if (i == 0)
                    result[i] = A[i];
                else
                    result[i] = result[i - 1] + A[i];
            }

            return result;
        }

        [TestCase(new[] { 1, 4, 16}, new [] {26, 10, 20}, 26, new [] {10, 4, 0})]
        public void Tests(int[] inputP, int[] inputQ, int inputN, int[] expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(inputN, inputP, inputQ));
        }
    }
}
