using System;
class Solution
{
    static int[] reverseArray(int[] arr, int[] tempArr, int n)
    {
        int reverseIndex = n - 1;
        for (int i = 0; i < n; i++, reverseIndex--)
            arr[i] = tempArr[reverseIndex];
        return arr;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        int[] tempArr = new int[n];

        for (int i = 0; i < n; i++)
            tempArr[i] = arr[i];

        arr = reverseArray(arr, tempArr, n);

        foreach (var item in arr)
            Console.Write(item.ToString() + " ");
    }
}
