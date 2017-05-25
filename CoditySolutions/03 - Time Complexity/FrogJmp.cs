namespace CoditySolutions
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            if (X == Y) return 0;

            return (Y - X + (D - 1)) / D;
        }
    }
}