using System;
using System.Collections.Generic;

namespace SnakeAndLadder2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Set the Foreground color to blue
            Console.ForegroundColor = ConsoleColor.Blue;

            // Display current Foreground color
            Console.WriteLine("Changed Foreground Color: {0}",
                                    Console.ForegroundColor);
            PlayerPositin.Position();

        }
    }
}
