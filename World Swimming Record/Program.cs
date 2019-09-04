using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPer1m = double.Parse(Console.ReadLine());

            double time = distance * secondsPer1m;

            double resistance = Math.Floor(distance / 15) * 12.5;
           // resistance = Math.Round(resistance, 2);
            time += resistance;
            //time = Math.Floor((resistance + time), 2);

            if (time >= record)
            {
                // double secondsNeeded = time - record - 1;

                double secondsNeeded = time - record;

                Console.WriteLine($"No, he failed! He was {secondsNeeded:F2} seconds slower.");
                
            }

            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
        }
    }
}
