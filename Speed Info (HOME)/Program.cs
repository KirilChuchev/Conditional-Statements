using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Info__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10.00)
            {
                Console.WriteLine("slow");
            }

            else if (speed <= 50.00)
            {
                Console.WriteLine("average");
            }

            else if (speed <= 150.00)
            {
                Console.WriteLine("fast");
            }

            else if (speed <= 1000.00)
            {
                Console.WriteLine("ultra fast");
            }

            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
