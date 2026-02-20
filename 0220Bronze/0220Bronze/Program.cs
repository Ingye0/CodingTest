using System;

namespace _0220Bronze
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int N, A, B, C, D, E, F, G, H;
                int X = 0, Y = 0, Z = 0;

                string[] input = Console.ReadLine().Split(' ');

                N = int.Parse(input[0]);
                A = int.Parse(input[1]);
                B = int.Parse(input[2]);
                C = int.Parse(input[3]);
                D = int.Parse(input[4]);
                E = int.Parse(input[5]);
                F = int.Parse(input[6]);
                G = int.Parse(input[7]);
                H = int.Parse(input[8]);

                int results = 0;

                for (int x = 0; x <= N; x++)
                {
                    for (int y = 0; y <= N - x; y++)
                    {
                        int z = N - x - y;

                        if (A * x + B * y + C * z == D && E * x + F * y + G * z == H)
                        {
                            results++;
                            X = x;
                            Y = y;
                            Z = z;

                            if (results == 2) break;
                        }
                    }
                    if (results == 2) break;
                }

                if (results == 1)
                {
                    Console.WriteLine(0);
                    Console.WriteLine($"{X} {Y} {Z}");
                }
                else if (results == 2)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(2);
                }
            }
        }
    }
}

