using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a word to manipulate or test.");
            string userString = Console.ReadLine();

            Console.WriteLine(userString+" reversed is: "+ReverseString(userString));
            
            Console.WriteLine("The amount of vowels in "+userString+" is: "+ CountVowels(userString));


        }

        public static string ReverseString(string userString)
        {
            string newString = "";



            Console.WriteLine(newString);
            
        }
       public static string CountVowels(string userString)
        {
            string vowels = "aeiou";

            string[] vowel = { "a", "e", "i", "o", "u" };


            foreach ( vowel in userString)
            {

            }
        }
       public static string IsPalindrome(string userString)
        {

            string newString = "";


            if (userString == newString)
            {
                Console.WriteLine("The word: "+userString+ "IS a palindrome.");
            }

            else
            {
                Console.WriteLine("The word:"+userString+"is NOT a Palindrome");
            }
        }
    }
}
