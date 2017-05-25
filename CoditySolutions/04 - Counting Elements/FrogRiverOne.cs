namespace CoditySolutions
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            var covered = new bool[X];
            var uncovered = X;

            for (int i = 0; i < A.Length; i++)
            {
                if (covered[A[i] - 1] == false)
                {
                    covered[A[i] - 1] = true;
                    uncovered -= 1;

                    if (uncovered == 0)
                        return i;
                }
            }

            return -1;
        }
    }
}