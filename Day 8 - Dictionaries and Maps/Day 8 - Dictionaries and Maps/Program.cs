using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> phoneBook = new Dictionary<string, int>();
        string query = "";
        int phoneNumber = 0;
        int indexOfSpace = 0;
        for(int i = 0; i < n; i++)
        {
            query = Console.ReadLine();
            indexOfSpace = query.LastIndexOf(' ');
            phoneNumber = Convert.ToInt32(query.Substring(indexOfSpace + 1, 8));
            query = query.Substring(0, indexOfSpace);
            phoneBook.Add(query, phoneNumber);
        }

        while((query = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(query))
                Console.WriteLine("{0}={1}", query, phoneBook[query]);
            else
                Console.WriteLine("Not found");
        }
    }
}