using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static double calculateTip(double tipPercent, double mealCost)
    {
        double tipTotal = 0;
        tipTotal = (tipPercent / 100) * mealCost;
        return tipTotal;
    }

    static double calculateTax(double taxPercent, double mealCost)
    {
        double taxTotal = 0;
        taxTotal = (taxPercent / 100) * mealCost;
        return taxTotal;
    }

    static double calculateMealTotal(double totalTip, double totalTax, double mealCost)
    {
        double mealTotal = totalTip + totalTax + mealCost;
        return mealTotal;
    }

    static void Main(String[] args)
    {
        double mealCost = Convert.ToDouble(Console.ReadLine());
        double tipPercent = Convert.ToDouble(Console.ReadLine());
        double taxPercent = Convert.ToDouble(Console.ReadLine());
        double tipTotal = calculateTip(tipPercent, mealCost);
        double taxTotal = calculateTax(taxPercent, mealCost);
        mealCost = calculateMealTotal(tipTotal, taxTotal, mealCost);
        Console.WriteLine("The total meal cost is " + Math.Round(mealCost) + " dollars.");
    }
}