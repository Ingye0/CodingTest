using System;
using System.Collections.Generic;
using System.Numerics;

namespace Bronze
{
    class Program
    {
        static void Main()
        {
            int testcase = int.Parse(Console.ReadLine());
            List<BigInteger> results1 = new List<BigInteger>(testcase);

            for (int i = 0; i < testcase; i++)
            {
                var inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                BigInteger result = BigInteger.Pow(a, b) % 10;
                if (result == 0)
                {
                    result = 10;
                }

                results1.Add(result);
            }

            foreach (BigInteger b in results1)
            {
                Console.WriteLine(b);
            }
        }
    }
}
