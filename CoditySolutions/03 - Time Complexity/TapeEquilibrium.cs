using System;

namespace CoditySolutions
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            var sums = new int[A.Length];
            sums[0] = A[0];

            for (var index = 1; index < A.Length; index++)
            {
                sums[index] = sums[index - 1] + A[index];
            }

            int last = sums[A.Length - 1];
            int result = int.MaxValue;

            for (var index = 0; index  < sums.Length; index++)
            {
                result = Math.Min(result, Math.Abs(last - 2 * sums[index]));
            }

            return result;
        }
    }
}