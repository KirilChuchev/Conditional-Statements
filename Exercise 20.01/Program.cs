using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // прочети данните
            // обща цена от вс. играчки
            // общ брой играчки
            // наем
            // има ли екскурзия

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionssCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double totalSum = puzzlesCount * 2.6 + dollsCount * 3 + bearsCount * 4.1 + minionssCount * 8.2 + truckCount * 2;

            int totalCount = puzzlesCount + dollsCount + bearsCount + minionssCount + truckCount;

            if (totalCount >=50)
            {

             totalSum -= totalSum * 0.25;
            }

            totalSum -= totalSum * 0.1;

            
            if (totalSum>=tripPrice)
            {
                double leftMoney = totalSum - tripPrice;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }

            else
            {
                double needMoney = tripPrice - totalSum;
                Console.WriteLine($"Not enough money! {needMoney:F2} lv needed.");
            }
        }
    }
}
