using System;

namespace _0211
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int Longs = input / 4;

            for(int i = 0; i < Longs; i++)
            {
                Console.Write("long ");
            }
                Console.Write("int");
        }
    }
}
