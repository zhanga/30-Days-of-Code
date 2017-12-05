using System;
class Solution
{
    static int factorial(int n)
    {
        if (n > 0)
            return n * factorial(n - 1);
        else
            return 1;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int result = factorial(n);
        Console.WriteLine(result);
    }
}