using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRight
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkTemp = true;

            while (checkTemp == true)
            {
                Console.Write("Please input the currect temp(or q to quit): ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    checkTemp = false;
                    break;
                }
                else
                {
                    int temperature = int.Parse(input);

                    if (temperature < 21)
                    {
                        Console.WriteLine("Too cold!");
                    }
                    else if (temperature > 22)
                    {
                        Console.WriteLine("Too hot!");
                    }
                    else
                    {
                        Console.WriteLine("Just right.");
                    }
                }

            }

        }
    }
}
