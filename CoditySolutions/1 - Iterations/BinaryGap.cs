using System;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    class Solution
    {
        // 100/100
        public int BinaryGap(int N)
        {
            if (N <= 0)
                return 0;

            bool inGap = false;
            int result = 0;
            int current = 0;

            var inBinary = Convert.ToString(N, 2);
            
            for (int index = 0; index < inBinary.Length; index++)
            {
                if (inBinary[index] == '1')
                {
                    if (inGap)
                    {
                        if (current > result) result = current;
                        current = 0;
                        continue;
                    }

                    inGap = true;
                    continue;
                }

                if (inGap)
                {
                    current++;
                }
            }

            return result;
        }

        [TestCase(9, 2)]
        [TestCase(529, 4)]
        [TestCase(20, 1)]
        [TestCase(15, 0)]
        public void Tests(int input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, BinaryGap(input));
        }
    }
}
