using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class CyclicRotation
    {
        // 100/100
        public int[] solution(int[] A, int K)
        {
            for (int k = 0; k < K; k++)
            {
                var shifted = new int[A.Length];
                for (int index = 0; index < A.Length; index++)
                {
                    if (index == 0)
                        shifted[index] = A[A.Length - 1];
                    else
                        shifted[index] = A[index - 1];
                }
                
                A = shifted;
            }

            return A;
        }

        [TestCase(new [] {3, 8, 9, 7, 6}, 3, new [] {9, 7, 6, 3, 8})]
        public void Tests(int[] inputArray, int inputK, int[] expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(inputArray, inputK));
        }
    }
}