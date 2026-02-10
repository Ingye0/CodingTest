using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        long first14 = 0;
        long all = 0;
        long last = long.Parse(input[14]);
        
        for (int i = 0; i < 15; i++)
        {
            long a = long.Parse(input[i]);
            
            if (a > all)
            {
                all = a;
            }
            
            if (i < 14 && a > first14)
            {
                first14 = a;
            }
        }

        if (last > first14)
        {
            Console.WriteLine(last);
        }
        else
        {
            Console.WriteLine(all + 1);
        }
    }
}
