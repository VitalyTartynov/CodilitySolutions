using System.Collections.Generic;

namespace CoditySolutions
{
    public class StoneWall
    {
        public int solution(int[] H)
        {
            var blocks = 0;
            var s = new Stack<int>();

            foreach (var h in H)
            {
                while (s.Count != 0 && s.Peek() > h)
                {
                    s.Pop();
                }

                if (s.Count == 0 || s.Peek() != h)
                {
                    blocks++;
                    s.Push(h);
                }
            }

            return blocks;
        }
    }
}