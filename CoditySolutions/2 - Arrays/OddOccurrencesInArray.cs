using System;

namespace CoditySolutions
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            for (int index = 0; index < A.Length; index+=2)
            {
                if (index+1 == A.Length)
                    return A[index];

                if (A[index] != A[index + 1])
                    return A[index];
            }

            return 0;
        }
    }
}