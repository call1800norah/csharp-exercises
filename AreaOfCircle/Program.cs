using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double area;
            double number;
            int tryAgain = 0;
            bool negaNum = true;
            do
            {
                Console.Write("Please enter the number: ");
                string input = Console.ReadLine();
                number = double.Parse(input);
                area = Math.PI * number * number;
                tryAgain++;
                if (number > 0)
                {
                    negaNum = false;
                    Console.WriteLine(area);

                }
                else
                {
                    Console.WriteLine("Please enter the positive number!");
                }


            } while (negaNum);
             Console.ReadLine();
        }
    }
}
