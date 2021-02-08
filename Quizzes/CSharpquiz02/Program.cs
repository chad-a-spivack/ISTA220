using System;

namespace CSharpQuiz02

{
    class Program
    {
        static void Main(string[] args)
        {
            double result = CalculatePhi(1, 1, 0, 40);
         
            Console.WriteLine($"Phi is = {result}");
        }

        public static double CalculatePhi(long first, long next, int place, int target = 40)
        {
            double result = first + next;
            if (place == target)
                return result / next;
            else
                return CalculatePhi(next, first + next, place + 1, target);
            
        }
    }
}
