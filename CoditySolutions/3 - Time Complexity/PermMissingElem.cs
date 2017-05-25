using System;

namespace CoditySolutions
{
    public class PermMissingElem
    {
        public int solution(int[] A)
        {
            if (A.Length == 0) return 1;

            Array.Sort(A);

            if (A[0] != 1) return 1;
            if (A[A.Length - 1] != A.Length + 1) return A.Length + 1;

            for (int index = 1; index < A.Length; index++)
            {
                if (A[index - 1] != A[index] - 1) return A[index] - 1;
            }

            return 0;
        }
    }
}