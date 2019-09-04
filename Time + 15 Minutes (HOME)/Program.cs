using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                minutes -= 60;
                hours += 1;

                if (hours >= 24)
                {
                    hours -= 24;
                    

                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes}");
                    }

                    else
                    {
                        Console.WriteLine($"{hours}:{minutes}");
                    }
                }

                else
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes}");
                    }

                    else
                    {
                        Console.WriteLine($"{hours}:{minutes}");
                    }
                }
            }

            else
            {
                if (minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes}");
                }

                else
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }
            }
        }
    }
}
