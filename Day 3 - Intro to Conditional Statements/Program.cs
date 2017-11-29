using System;
class Solution
{
    static bool checkIfOdd(int numberToCheck)
    {
        bool isOdd;
        if (numberToCheck % 2 != 0)
        {
            isOdd = true;
        }
        else
        {
            isOdd = false;
        }
        return isOdd;
    }
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (checkIfOdd(n) == true)
        {
            Console.WriteLine("Weird");
        }
        else
        {
            if (n >= 2 && n <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (n >= 6 && n <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
