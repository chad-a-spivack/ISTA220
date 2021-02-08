using System;

namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");
            double area = Math.PI * (intradius * intradius);
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.WriteLine("Enter an integer for the radius: ");
            string strHemi = Console.ReadLine();
            int Hemi = int.Parse(strHemi);
            double volume =  (4*(Math.PI * (Hemi * Hemi * Hemi)))/3;
            Console.WriteLine($"The volume is {volume/2}");

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula)");
            Console.WriteLine("Enter an integer for a: ");
            string a = Console.ReadLine();
            int aLength = int.Parse(a);
            Console.WriteLine("Enter an integer for b: ");
            string b = Console.ReadLine();
            int bLength = int.Parse(b);
            Console.WriteLine("Enter an integer for c: ");
            string c = Console.ReadLine();
            int cLength = int.Parse(c);
            double pValue = (aLength + bLength + cLength) / 2;
            double pBeforeSqrt = pValue * (pValue - aLength) * (pValue - bLength) * (pValue - cLength);
            double areaTriangle = Math.Sqrt(pBeforeSqrt);
            Console.WriteLine($"The area is {areaTriangle}");

            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.WriteLine("Enter an integer for a: ");
            string stringaQuad = Console.ReadLine();
            int aQuad = int.Parse(stringaQuad);
            Console.WriteLine("Enter an integer for b: ");
            string stringBQuad = Console.ReadLine();
            int bQuad = int.Parse(stringBQuad);
            Console.WriteLine("Enter an integer for c: ");
            string stringCQuad = Console.ReadLine();
            int cQuad = int.Parse(stringCQuad);
            
            double positive_num = (-bQuad + Math.Sqrt((bQuad * bQuad) - 4 * aQuad * cQuad));
            double negative_num = (-bQuad - Math.Sqrt((bQuad * bQuad) - 4 * aQuad * cQuad));
            double denominator = 2 * aQuad;
            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");
        }
    }
}
