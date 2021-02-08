using System;


namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);
            Point point3 = new Point(3, 4, 5);
            Point point4 = new Point(7, 10, 3);
            Console.WriteLine($"The distance between point 1 and point 2 is:" +
                $"{point1.DistanceTo(point2)}");
            Console.WriteLine($"The distance between point 1 and point 2 is:" +
                $"{point2.DistanceTo(point1)}");
            Console.WriteLine($"The distance between point 1 and point 1 is:" +
               $"{point1.DistanceTo(point1)}");
            Console.WriteLine($"The number of points created is:" +
                $"{Point.ObjectCount()}");
            Console.WriteLine($"The distance between point 3 and point 4 is:" +
                $"{point3.DistanceToTriple(point4)}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
