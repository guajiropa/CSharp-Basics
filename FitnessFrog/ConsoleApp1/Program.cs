/*
##  AUTHOR      :   Robert James Patterson
##  FILENAME    :   FitnessFrog/Program.cs
##  DATE        :   01/02/18
##  SYNOPSIS    :   Work file for the Treehouse C# Basics course
##
*/
using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            var runningTotal = 0.0;
            var keepGoing = true;

            // Run until user exits app
            while (keepGoing)
            {
                // Prompt user for minutes exercised. 
                Console.Write("Enter how many minutes of exercise or \"quit\" to exit: ");
                var input = Console.ReadLine();

                // Check for 'quit' input from end user
                if (input.ToLower() == "quit")
                {
                    keepGoing = false;
                    break;
                }
                else
                {
                    // convert the input string to int
                    try
                    {
                        var minutes = double.Parse(input);

                        // if minutes are less then or equal to 0, then prompt user for
                        // a valid value.
                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value.");
                            continue;
                        }
                        else if (minutes <= 10)
                        {
                            Console.WriteLine("You gotta start somewhere, right?");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Way to go, hot stuff!!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("Are you a nija warrior?");
                        }
                        else
                        {
                            Console.WriteLine("OK, now you are just showing off!");
                        }
                        // Add those minutes
                        runningTotal += minutes;
                        // Display the running total.
                        Console.WriteLine("You entered a total of " + runningTotal + " minutes.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That was not a valid input, please try again.");
                        continue;
                    }

                }
            }
            // Display the program exit message
            Console.WriteLine("Thank you for using\n*************\nFITNESS FROG\n*************");
        }
    }
}