using System;

namespace ConsoleApp12_c_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter point coords (x y): ");
                Point point = (Point)Console.ReadLine();

                Console.WriteLine($"X Y are equals: {(point?"yes":"no")}");

                Console.WriteLine((string)point);
                
                Console.Write("Enter scalar: ");
                point += int.Parse(Console.ReadLine());
                Console.WriteLine((string)point);

                Console.WriteLine("++");
                point++;
                Console.WriteLine((string)point);

                Console.WriteLine("--");
                point--;
                Console.WriteLine((string)point);
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }
}
