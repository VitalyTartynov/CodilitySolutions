namespace Test
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            var result = new int[N];
            var max = 0;

            for (int index = 0; index < A.Length; index++)
            {
                var val = A[index];

                if (val <= N)
                {
                    result[val - 1] += 1;
                    if (result[val - 1] > max) max = result[val - 1];
                }
                else
                {
                    for (int resultIndex = 0; resultIndex < result.Length; resultIndex++)
                    {
                        result[resultIndex] = max;
                    }
                }
            }

            return result;
        }
    }
}