using System;
class tst
{
    static void FindFactors(int n, int i = 5)
    {
        if (n % i == 0)
            Console.Write(i + " ");
        if (i == n / 2) return;
        FindFactors(n, ++i);
    }
    static void Main()
    {
        FindFactors(1000);
        Console.WriteLine();
    }
}