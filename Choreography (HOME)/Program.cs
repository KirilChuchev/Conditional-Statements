using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int studyDays = int.Parse(Console.ReadLine());

             double individualPercentStepsPerDay = (((steps * 1.00 / dancers) / studyDays) / steps) * 100.00;
            /* double individualPercentStepsPerDay = steps * 1.00 / dancers;
            individualPercentStepsPerDay /= studyDays;
            individualPercentStepsPerDay /= steps;
            individualPercentStepsPerDay *= 100.00; */


            double teamPercentStepsPerDay = Math.Ceiling(individualPercentStepsPerDay * dancers);
            
            // individualPercentStepsPerDay = teamPercentStepsPerDay / dancers; Може да се направи Math.Ceiling

            if (teamPercentStepsPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {individualPercentStepsPerDay:F2}%.");
            }

            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {individualPercentStepsPerDay:F2}% steps to be learned per day.");
            }
        }
    }
}
