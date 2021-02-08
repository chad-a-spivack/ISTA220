using System;

namespace Quiz03
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateReciprocal();
        }

        private static void CalculateReciprocal()
        {
            try
            {
                Console.Write("To calculate the reciprocal of an integer, enter an integer: ");
                string input = Console.ReadLine();
                double intInput = double.Parse(input);
                if (intInput > 0)
                {
                    double result = 1 / intInput;
                    Console.WriteLine($"The reciprocal of {intInput} is {result}");
                }
                else if (intInput == 0)
                {
                    throw new InvalidOperationException("Divide by 0 error");

                }
                else if (intInput < 0)
                {
                    throw new InvalidOperationException("No negative integers");

                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                CalculateReciprocal();

            }
            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                CalculateReciprocal();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CalculateReciprocal();

            }
        }
    }
}
