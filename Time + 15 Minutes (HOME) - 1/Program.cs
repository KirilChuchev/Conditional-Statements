using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes__HOME____1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hours * 60 + minutes;
            totalMinutes += 15;

            int newHours = totalMinutes / 60;
            int newMinutes = totalMinutes % 60;

            if (newHours > 24)
            {
                newHours = newHours % 24;

                if (newMinutes <10)
                {
                    Console.WriteLine($"{newHours}:0{newMinutes}");
                }

                else
                {
                    Console.WriteLine($"{newHours}:{newMinutes}");
                }
            }

            else if (newHours < 24)
            {
                
                if (newMinutes < 10)
                {
                    Console.WriteLine($"{newHours}:0{newMinutes}");
                }

                else
                {
                    Console.WriteLine($"{newHours}:{newMinutes}");
                }
            }

            else
            {
                if (newMinutes < 10)
                {
                    Console.WriteLine($"0:0{newMinutes}");
                }

                else
                {
                    Console.WriteLine($"0:{newMinutes}");
                }
            }
        }
    }
}
