namespace CoditySolutions
{
    public class CyclicRotation
    {
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

                /*foreach (var i in shifted)
                    Console.Write(i + " ");
                Console.WriteLine();*/

                A = shifted;
            }

            return A;
        }
    }
}