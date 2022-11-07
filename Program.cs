using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardsCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramMemoryCount = int.Parse(Console.ReadLine());

            double totalSum = videoCardsCount + cpuCount + ramMemoryCount;
            int pearVideoCard = 250;
            double cpuPricePearOne = (pearVideoCard * videoCardsCount) * 0.35;
            double ramPricePearOne = (pearVideoCard * videoCardsCount) * 0.10;
          //Console.WriteLine(cpuPricePearOne);
          //Console.WriteLine(ramPricePearOne);
            double totalPrice = (pearVideoCard * videoCardsCount) + (cpuPricePearOne * cpuCount) + (ramPricePearOne * ramMemoryCount);
            if (videoCardsCount > cpuCount)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            if (totalPrice <= budget)
            {
                double leftBudget = budget - totalPrice;
                Console.WriteLine($"You have {leftBudget:f2} leva left!");
            }
            else
            {
                double leftBudget = budget - totalPrice;
                leftBudget = Math.Abs(leftBudget);
                Console.WriteLine($"Not enough money! You need {leftBudget:f2} leva more!");
            }
                
        }
    }
}
