using System;

class Solution
{
    static int checkForConsecutiveOnes(string binaryValue)
    {
        int consecutiveOnes = 0;
        int highestConsecutiveOnes = 0;
        for (int i = 0; i < binaryValue.Length; i++)
        {
            if (binaryValue[i] == '1')
            {
                consecutiveOnes++;
            }
            else
            {
                if (highestConsecutiveOnes < consecutiveOnes)
                    highestConsecutiveOnes = consecutiveOnes;
                consecutiveOnes = 0;
            }
        }

        if (highestConsecutiveOnes < consecutiveOnes)
            highestConsecutiveOnes = consecutiveOnes;

        return highestConsecutiveOnes;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string binaryValue = Convert.ToString(n, 2);
        int consecutiveOnes = checkForConsecutiveOnes(binaryValue);
        Console.WriteLine(consecutiveOnes);
    }
}