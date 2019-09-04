using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            double numInput = double.Parse(Console.ReadLine());
            string unitInput = Console.ReadLine();
            string unitOutput = Console.ReadLine();

            double numOutput = 0.00;

            if (unitInput == "mm")
            {
                switch (unitOutput)
                {
                    case "mm":
                        {
                            numOutput = numInput;
                        }
                        break;

                    case "cm":
                        {
                            numOutput = numInput / 10.00;
                        }
                        break;

                    case "m":
                        {
                            numOutput = numInput / 1000.00;
                        }
                        break;
                    default:
                        break;
                }
            }

            else if (unitInput == "cm")
            {
                switch (unitOutput)
                {
                    case "cm":
                        {
                            numOutput = numInput;
                        }
                        break;

                    case "mm":
                        {
                            numOutput = numInput * 10.00;
                        }
                        break;

                    case "m":
                        {
                            numOutput = numInput / 100.00;
                        }
                        break;
                    default:
                        break;
                }
            }

            else if (unitInput == "m")
            {
                switch (unitOutput)
                {
                    case "m":
                        {
                            numOutput = numInput;
                        }
                        break;

                    case "cm":
                        {
                            numOutput = numInput * 100.00;
                        }
                        break;

                    case "mm":
                        {
                            numOutput = numInput * 1000.00;
                        }
                        break;
                    default:
                        break;
                }
            }

            else
            {

            }

            Console.WriteLine($"{ numOutput:F3}");
        }
    }
}
