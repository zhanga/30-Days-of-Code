using System;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        Console.WriteLine(i + Convert.ToInt32(Console.ReadLine()));
        double doubleInput = Convert.ToDouble(Console.ReadLine());
        d += doubleInput;
        double convertToInt = Convert.ToInt32(d);

        if (d == convertToInt)
        {
            Console.WriteLine(d.ToString("N1"));
        }

        else
        {
            Console.WriteLine(d);
        }

        Console.WriteLine(s + Console.ReadLine());
        }
}