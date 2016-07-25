using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beck1
{
    class StringOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase to reverse: "); 
            string phrase = Console.ReadLine(); 
            StringOperations.ReverseWordsInSentence(phrase);
            Console.ReadKey();
        } 
                        
        public static void ReverseWordsInSentence(string phrase)
        {
            string reversed = string.Empty;
            string[] words = phrase.Split(' '); 
            Array.Reverse(words); 
            reversed = string.Join(" ", words); 
            Console.WriteLine("The reversed phrase is: " + reversed); 
        }





    }
}
