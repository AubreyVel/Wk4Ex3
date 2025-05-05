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
            string userString = "";
            int userChoice = 0;

            Console.WriteLine("Insert a word to manipulate or test.");
            userString = Console.ReadLine();

            Console.WriteLine("Select an operation:\n1: Reverse\n2: Count Vowels\n3: Check Palindrome\n4: Exit");
            userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine(userString + " reversed is: " + ReverseString(userString));
                    break;
                case 2:
                    Console.WriteLine("The amount of vowels in " + userString + " is: " + CountVowels(userString));
                    break;
                case 3:
                    IsPalindrome(userString);
                    break;
                default:
                    Console.WriteLine("Good bye.");
                    break;
            }


            
            
            


        }

        public static string ReverseString(string userString)
        {
            string newString = "";
            string[] reverse = { };

            foreach(char c in userString)
            {
                string v = Convert.ToString(c);
                for (int i = 0; i <= reverse.Length; i++)
                {
                    newString += reverse[i];
                } 
            }
            for (int i = reverse.Length; i >= 0 ; i--)
            {
                newString += reverse[i];
            }


            return newString;
        }



       public static string CountVowels(string testString)
        {
            string[] vowels = {"a","e","i","o","u"};

            int count = 0;
            foreach (char c in testString)
            {
                
                for (int i = 0; i < vowels.Length; i++)
                {
                    string v = Convert.ToString(c);
                    if (v == vowels[i])
                    {
                        count++;
                    }
                    Console.WriteLine(v+" "+count);
                }

            }
            return testString;
        }
       public static string IsPalindrome(string userString)
        {

            string newString = "";
            string[] reverse = { };

            foreach (char c in userString)
            {
                int i = 0;
                reverse[i] = Convert.ToString(c);
                i++;

            }
            for (int i = reverse.Length; i >= 0; i--)
            {
                newString += reverse[i];
            }

            if (userString == newString)
            {
                return "The word: "+userString+ "IS a palindrome.";
            }

            else
            {
                return "The word:"+userString+"is NOT a Palindrome";
            }
        }
    }
}
