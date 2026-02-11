using System;

namespace Bronze
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                int result = 1;

                string[] inputs = Console.ReadLine().Split(' ');

                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                for (int j = 0; j < b; j++)
                {
                    result = (result * a) % 10;

                    if (result == 0)
                    {
                        result = 10;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
