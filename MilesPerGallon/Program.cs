using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double miles;
            double gallon;
            double milesPerGallon;
            string input;

            Console.WriteLine("Miles Per Gallon");
            Console.Write("How many miles have you driven: ");
            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.Write("How many gallons have you consumed: ");
            input = Console.ReadLine();
            gallon = double.Parse(input);
            milesPerGallon = gallon / miles;

            Console.Write("The miles per gallon is: " + milesPerGallon);
            Console.ReadLine();
        


        }
    }
}
