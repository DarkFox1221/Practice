using System;

namespace ConsoleApp11_с_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter pint coords x y:");
                Point point = new Point(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));

                point.PrintPoint();

                Console.Write("Multiply on scalar, enter scalar: ");
                point.MultiplyPointOnScalar = int.Parse(Console.ReadLine());

                point.PrintPoint();
                
                Console.Write("Enter two values to move point: ");
                point.ReplacePoint(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

                point.PrintPoint();
                Console.WriteLine($"Length: {point.CalcLengthToCoordinatesStart()}");
            }
            catch
            {
                Console.WriteLine("fail");
            }
        }
    }
}
