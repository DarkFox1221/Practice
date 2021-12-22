// Seeusing System; namespace Zadanie_4._1
class Program
{
    static double F(int n)
    {
        if (n == 1) return -10;
        else if (n == 2) return 2;
        return F(Math.Abs((n - 1)) - (6 * n + 1));
    }
    static void Main(string[] args)
    {
        Console.WriteLine(F(1)); 
        Console.WriteLine(F(2));
    }
}

