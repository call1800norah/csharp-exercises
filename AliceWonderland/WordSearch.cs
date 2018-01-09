using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceWonderland
{
    public class WordSearch
    {
        public static bool GetWord()
        {

            string wonderland =
@"Alice was beginning to get very 
tired of sitting by her sister on the bank, 
and of having nothing to do: once or twice she had peeped into 
the book her sister was reading, but it had no pictures or 
conversations in it, 'and what is the use of a book,' 
thought Alice 'without pictures or conversation?'";

            string[] words = wonderland.Split(' ');
            
            Console.Write("Please enter the word you are searching for: ");
            string input = Console.ReadLine();
            string lowerCase = input.ToLower();

             for (int word = 0; word < words.Length; word++)
             {
                 string lowerword = words[word].ToLower();

                 if (lowerword == lowerCase)
                 {
                    return true;
                   
                }
          
             }

            return false;
        }
    }


}
    

