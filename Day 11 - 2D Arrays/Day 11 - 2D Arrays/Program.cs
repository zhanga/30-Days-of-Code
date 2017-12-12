using System;
class Solution
{
    static int performAdditions(int[][] queries)
    {
        int result = -9 * 7;
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                if (result < queries[x][y] + queries[x][y + 1] + queries[x][y + 2] + queries[x + 1][y + 1] +
                    queries[x + 2][y] + queries[x + 2][y + 1] + queries[x + 2][y + 2])
                {
                    result = queries[x][y] + queries[x][y + 1] + queries[x][y + 2] + queries[x + 1][y + 1] +
                    queries[x + 2][y] + queries[x + 2][y + 1] + queries[x + 2][y + 2];
                }
            }
        }
        return result;
    }
    static void Main(String[] args)
    {
        int[][] arr = new int[6][];
        int result = 0;
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            arr[arr_i] = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        }
        result = performAdditions(arr);
        Console.WriteLine(result);
    }
}
