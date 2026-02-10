using System;
using System.Collections.Generic;

namespace Bronze
{
    class Program
    {
        static void Main()
        {
            int testcase = int.Parse(Console.ReadLine());
            List<double> results = new List<double>();

            for (int i = 0; i < testcase; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                double result = Math.Pow(a, b);

                result = result % 10;

                if (result == 0)
                {
                    result = 10;
                }

                results.Add(result);
            }

            foreach (int x in results)
            {
                Console.WriteLine(x);
            }
        }
    }
}
