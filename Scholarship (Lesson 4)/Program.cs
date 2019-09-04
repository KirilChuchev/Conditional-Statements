using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship__Lesson_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            bool canHaveSocialStipend = score > 4.5 && income < minimumWage;
            bool canHaveExcellentResultStipend = score >= 5.50;

            double socialStipendAmount = 0.35 * minimumWage;
            double excellentStipendAmount = score * 25;

            if (canHaveExcellentResultStipend && canHaveSocialStipend)
            {
                if (excellentStipendAmount >= socialStipendAmount)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentStipendAmount)} BGN")
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialStipendAmount)} BGN");
                }
            }
            else if (canHaveSocialStipend && !canHaveExcellentResultStipend)
            {

            }
            else if (!canHaveSocialStipend && canHaveExcellentResultStipend)
            {

            }
            else 
            {

            }
        }
    }
}
