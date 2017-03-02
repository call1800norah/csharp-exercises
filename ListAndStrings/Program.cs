using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ListAndStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> myString = new List<string>();
            myString.Add("happy");
            myString.Add("Sunday");
            myString.Add("great");
            myString.Add("Friday");
            myString.Add("joy");
            myString.Add("Weekend");
            myString.Add("Norah");
           
            foreach (string item in myString)
            {
                

                if (item.Count() == 5)
                {
                    Console.WriteLine(item);
                }
               
            }
            Console.ReadLine();
  
        }

    }
}
