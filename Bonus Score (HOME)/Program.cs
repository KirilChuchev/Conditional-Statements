using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonus = 0.00;
            double numBonus = 0.00;

            if (number <= 100)
            {
                bonus = 5.00;
                
            }

            else if (number <= 1000)
            {
                bonus = 0.2 * number;
                              
            }

            else
            {
                bonus = 0.1 * number;
                              
            }

            if (number % 2 == 0)
            {
                bonus += 1.00;
            }

            else if (number % 10 == 5)
            {
                bonus += 2.00;
            }

            else
            {
               
            }

            numBonus = number + bonus;
            Console.WriteLine(bonus);
            Console.WriteLine(numBonus);


        }
    }
}
