using System;

namespace Test
{
    public class FizzBuzz
    {
        public void FB()
        {
            for (int i = 1; i <= 100; i++)
            {
                var div3 = i % 3 == 0;
                var div5 = i % 5 == 0;
                if (div3)
                {
                    Console.WriteLine("Fizz");
                }
                if (div5)
                {
                    Console.WriteLine("Buzz");
                }

                if (!div3 && !div5)
                    Console.WriteLine(i);
            }
        }
    }
}