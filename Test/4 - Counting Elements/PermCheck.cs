using System;

namespace Test
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            if (A.Length < 1) return 0;

            if (A[0] != 1) return 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                var current = A[i];
                var next = A[i + 1];
                if (next - current != 1)
                    return 0;
            }

            return 1;
        }
    }
}