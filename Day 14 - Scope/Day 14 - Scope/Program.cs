using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] e)
    {
        elements = e;
    }

    public int computeDifference()
    {
        int minValue = 100;
        int maxValue = 1;
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] > maxValue)
            {
                maxValue = elements[i];
            }
            else if (elements[i] < minValue)
            {
                minValue = elements[i];
            }
        }
        maximumDifference = Math.Abs(minValue - maxValue);
        return maximumDifference;
    }
}
    class Solution
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }