namespace CoditySolutions
{
    public class PassingCars
    {
        // 100/100
        public int solution(int[] A)
        {
            var west = 0;
            var result = 0;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] == 1)
                {
                    west += 1;
                }
                else
                {
                    result += west;
                    if (result > 1000000000)
                        return -1;
                }
            }

            return result;
        }
    }
}