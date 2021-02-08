using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C sharp quiz 1");
            Console.WriteLine("Part 1");
            Console.WriteLine("MM           MM SSSSSSSS SSSSSSSS      AAAAAA");
            Console.WriteLine("MMM         MMM SSSSSSSS SSSSSSSS      AA  AA");
            Console.WriteLine("MMMM       MMMM SS       SS           AA    AA");
            Console.WriteLine("MM MM     MM MM SS       SS           AA    AA");
            Console.WriteLine("MM    MMMM   MM SSSSSSSS SSSSSSSS     AAAAAAAAA");
            Console.WriteLine("MM     MM    MM SSSSSSSS SSSSSSSS    AAAAAAAAAA");
            Console.WriteLine("MM           MM       SS       SS   AA        AA");
            Console.WriteLine("MM           MM       SS       SS   AA        AA");
            Console.WriteLine("MM           MM SSSSSSSS SSSSSSSS   AA        AA");
            Console.WriteLine("MM           MM SSSSSSSS SSSSSSSS   AA        AA");

            Console.WriteLine("Part 2");
            double result = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine($"Phi is  {result}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
