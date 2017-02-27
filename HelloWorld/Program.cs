using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name ");
            Console.Write("What's your firstname: ");
            string myFirstName = Console.ReadLine();

            Console.Write("What's your lastname: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + myLastName);
            Console.ReadLine();

         
        }
    }
}
