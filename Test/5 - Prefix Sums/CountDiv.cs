using System;

namespace Test
{
    public class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            var min = ((A + K - 1) / K) * K;
            if (min > B) return 0;

            return ((B - min) / K) + 1;
        }
    }
}