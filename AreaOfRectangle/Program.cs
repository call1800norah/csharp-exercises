using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double Width;
            double Height;
            double Area;
            string input;

            Console.WriteLine("Area Of Rectangle");
            Console.Write("Tell me the width: ");
            input = Console.ReadLine();
            Width = double.Parse(input);

            Console.Write("Tell me the height: ");
            input = Console.ReadLine();
            Height = double.Parse(input);

            Area = Width * Height;
            Console.Write("The Area Of Rectangle: " + Area);
            Console.ReadLine();

        }
    }
}
