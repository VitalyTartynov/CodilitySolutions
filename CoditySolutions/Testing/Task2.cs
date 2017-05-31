using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class Task2
    {
        // ?/100
        public int solution(int[] A, int K)
        {
            return 0;
        }

        [TestCase(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 })]
        public void Tests(int[] inputArray, int inputK, int[] expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(inputArray, inputK));
        }
    }
}