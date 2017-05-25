using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class Dominator
    {
        // 100/100
        public int solution(int[] A)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!stack.Any())
                {
                    stack.Push(A[i]);
                    continue;
                }
                if (stack.Peek() == A[i])
                    stack.Push(A[i]);
                else
                    stack.Pop();
            }
            if (!stack.Any())
                return -1;
            var candidate = stack.Peek();
            var occur = 0;
            var rnd = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == candidate)
                {
                    occur++;
                    rnd = i;
                }
            }

            return occur > A.Length / 2 ? rnd : -1;
        }

        [TestCase(new [] {3, 4, 3, 2, 3, -1, 3, 3}, 3)]
        [TestCase(new [] {1, 2, 3, 4}, -1)]
        [TestCase(new [] {2, 2, 2, 4}, 2)]
        public void Tests(int[] inputs, int expectedResult)
        {
            var result = solution(inputs);
            if (expectedResult == -1 && result == -1) return;

            Assert.AreEqual(expectedResult, inputs[result]);
        }
    }
}