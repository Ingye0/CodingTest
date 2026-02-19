using System;

namespace _0219Bronze
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int month = int.Parse(input[0]);
            int day = int.Parse(input[1]);

            DateTime d = new DateTime(2007, month, day);
            int week = (int)d.DayOfWeek;

            switch (week)
            {
                case 0:
                    Console.WriteLine("SUN");
                    break;
                case 1:
                    Console.WriteLine("MON");
                    break;
                case 2:
                    Console.WriteLine("TUE");
                    break;
                case 3:
                    Console.WriteLine("WED");
                    break;
                case 4:
                    Console.WriteLine("THU");
                    break;
                case 5:
                    Console.WriteLine("FRI");
                    break;
                case 6:
                    Console.WriteLine("SAT");
                    break;
            }
        }
    }
}
