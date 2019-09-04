using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds1 = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());
            int seconds3 = int.Parse(Console.ReadLine());

            int sumSeconds = seconds1 + seconds2 + seconds3;
            int minutes = sumSeconds / 60;
            int seconds = sumSeconds % 60;

            if (seconds < 10 )
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }

            
        }
    }
}
