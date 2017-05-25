using System;

namespace CoditySolutions
{
    class Solution
    {
        public int BinaryGap(int N)
        {
            if (N <= 0)
                return 0;

            bool inGap = false;
            int result = 0;
            int current = 0;

            var inBinary = Convert.ToString(N, 2);
            // Console.WriteLine(inBinary);

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
                    else
                    {
                        inGap = true;
                        continue;
                    }
                }

                if (inGap)
                {
                    current++;
                }
            }

            return result;
        }
    }
}
