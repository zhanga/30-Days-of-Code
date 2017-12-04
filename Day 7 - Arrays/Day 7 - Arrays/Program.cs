using System;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        Array.Reverse(arr);

        foreach (var item in arr)
            Console.Write(item.ToString() + " ");
    }
}
