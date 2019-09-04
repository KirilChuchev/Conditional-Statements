using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double totalStepsPerDay = Math.Ceiling((((steps * 1.00 / days) / steps) * 100.00));

             double stepsPerDancers = totalStepsPerDay / dancers;
            if (totalStepsPerDay <=13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancers:F2}%.");

            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {stepsPerDancers:F2}% steps to be learned per day.");
            }
            
        }
    }
}
