using System;

namespace CSharpEX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = SumTenInts(0, 1);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart2, average 10 numbers.");
            double avg = AvgTenInts(0, 1);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart3, average user predetermined number of scores.");
            Console.Write("How many scores do you wish to enter? ");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 1, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart4, average non-predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 1);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average  is {avg2} and the letter garde is {letterGrade}");


        }

        private static int SumTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count == 10)
                return sum;
            else
                return SumTenInts(sum, count + 1);
        }

        private static double AvgTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count == 10)
                return sum / count;
            else
                return AvgTenInts(sum, count + 1);

        }

        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count == numScores)
                return sum / count;
            else
                return AvgUnkInts(sum, count + 1, numScores);
        }

        private static double AvgAnyInts(int sum, int count)
        {
            Console.Write("Enter a score: (enter -1 to stop)  ");
            string input = Console.ReadLine();
            int anyInput = int.Parse(input);
            sum += anyInput;
            if (anyInput < 0)
                return sum / count;
            else
                return AvgAnyInts(sum, count + 1);
            

        }

        private static char ConvertNumericToLetterGrade(double grade)
        {
            if (grade <= 100 && grade >= 90)
                return 'A';
            else if (grade >= 80 && grade < 90)
                return 'B';
            else if (grade >= 70 && grade < 80)
                return 'C';
            else if (grade >= 60 && grade < 70)
                return 'D';
            else if (grade < 60 && grade >= 0)
                return 'F';
            else
                return '0';


        }
    }
}
