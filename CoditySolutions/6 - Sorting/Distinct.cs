using System.Linq;

namespace CoditySolutions
{
    public class Distinct
    {
        // 100/100
        public int solution(int[] A)
        {
            return A.Distinct().Count();
        }
    }
}