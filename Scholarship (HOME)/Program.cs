using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double success = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(0.35 * minSalary);
            double successScholarship = Math.Floor(success * 25.00);


            if (success <= 4.50) // няма никаква стипендия
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (success >=5.50) //има отлична стипендия потенциална възможност за социална
            {
                if (income < minSalary)
                {
                    if (socialScholarship > successScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                    }

                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {successScholarship} BGN");
                    }
                }

                else
                {
                  Console.WriteLine($"You get a scholarship for excellent results {successScholarship} BGN"); 
                }
            }

            else // има потенциална възможност за социална стипендия, но не и за отлична
            {
                if (income < minSalary)
                {
                  Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }

                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
        }
    }
}
