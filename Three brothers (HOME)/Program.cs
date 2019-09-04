using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_brothers__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());

            double cleaningTime = 1 / ((1 / A) + (1 / B) + (1 / C));
            cleaningTime += 0.15 * cleaningTime;

            double timeLeft = D - cleaningTime;

            if (timeLeft >= 0)
            {
                timeLeft = Math.Floor(timeLeft);

                Console.WriteLine($"Cleaning time: {cleaningTime:F2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeLeft} hours.");
            }

            else
            {
                timeLeft = Math.Abs(timeLeft);
                timeLeft = Math.Ceiling(timeLeft);

                Console.WriteLine($"Cleaning time: {cleaningTime:F2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeLeft} hours.");
            }

        }
    }
}
