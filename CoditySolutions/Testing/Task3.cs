using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CoditySolutions
{
    [TestFixture]
    public class Task3
    {
        // ?/100
        public string solution(string S)
        {
            var rules = new Dictionary<string, string>
            {
                {"AB", "A"}, // "AB" -> "AA" -> "A",
                {"BA", "A"}, // "BA" -> "AA" -> "A",
                {"CB", "C"}, // "CB" -> "CC" -> "C",
                {"BC", "C"}, // "BC" -> "CC" -> "C".
                {"AA", "A"},
                {"CC", "C"}
            };

            string result = string.Empty;
            var ab = S[0] == 'A' || S[0] == 'B';
            var bc = S[0] == 'B' || S[0] == 'C';
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'A' || (S[i] == 'B' && ab))
                {
                    if (bc)
                    {
                        result += "C";
                        ab = false;
                        bc = true;
                    }
                    continue;
                }

                if ((S[i] == 'B' && bc) || S[i] == 'C')
                {
                    if (ab)
                    {
                        result += "A";
                        ab = false;
                        bc = true;
                    }
                }
            }

            if (ab) result += "A";
            if (bc) result += "C";

            return result;
        }

        public string anoterSolution(string input)
        {
            var result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                var current = input[i];
                while (current == 'A' || current == 'B' && i < input.Length)
                {
                    i++;
                }

            }

            return result;
        }

        [TestCase("ABBCC", "AC")]
        [TestCase("ABCBA", "ACA")]
        [TestCase("AAA", "A")]
        [TestCase("BBB", "BBB")]
        [TestCase("CCC", "C")]
        [TestCase("BBBAABABBBCCBCBBCACB", "ACAC")]
        public void Tests(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, solution(input));
        }
    }
}