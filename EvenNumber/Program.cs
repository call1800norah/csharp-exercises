using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> Numbers = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            for (int i = 1; i < Numbers.Count; i++)
            {
                if (IsEven(i))
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
      
    }

        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
  
        
    }
}
