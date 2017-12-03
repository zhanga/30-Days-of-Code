using System;
using System.Text;
class Solution
{
    static string splitEvensAndOdds (string fullString)
    {
        String evenLetters = "";
        String oddLetters = "";
        for (int i = 0; i < fullString.Length; i++)
        {
            if (i % 2 == 0)
                oddLetters = oddLetters + fullString.Substring(i, 1);
            else
                evenLetters = evenLetters + fullString.Substring(i, 1);
        }
        fullString = oddLetters + " " + evenLetters;
        return fullString;
    }
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string fullString;
        for(int i = 0; i < n; i++)
        {
            fullString = Console.ReadLine();
            fullString = splitEvensAndOdds(fullString);
            Console.WriteLine(fullString);
        }
    }
}