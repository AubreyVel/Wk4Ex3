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
            //declare
            string userString = "";
            int userChoice = 0;
            //askign user for word
            Console.WriteLine("Insert a word to manipulate or test.");
            userString = Console.ReadLine();
            //asking user what operation they want to do
            Console.WriteLine("Select an operation:\n1: Reverse\n2: Count Vowels\n3: Check Palindrome\n4: Exit");
            userChoice = Convert.ToInt32(Console.ReadLine());

            //chicking operation based on user input
            switch (userChoice)
            {
                case 1:
                    //run reverse
                    Console.WriteLine(userString + " reversed is: " + ReverseString(userString));
                    Console.ReadLine();
                    break;
                case 2:
                    //run vowels
                    Console.WriteLine("The amount of vowels in " + userString + " is: " + CountVowels(userString));
                    Console.ReadLine();
                    break;
                case 3:
                    //run palindrome
                    Console.WriteLine(IsPalindrome(userString));
                    Console.ReadLine();
                    break;
                default:
                    //if user inputs anything other than 1, 2, or 3, program exits
                    Console.WriteLine("Good bye.");
                    Console.ReadLine();
                    break;
            }


        }






        public static string ReverseString(string userString)
        {
            //declare
            string newString = "";
           //going through each letter and assigning it to news tring in reverse
            for (int i = userString.Length-1; i >=0 ; i--)
            {
                newString += userString[i];
            }
            //returning reversed string
            return newString;
        }



       public static int CountVowels(string testString)
        {
            //tried to use striing[], didnt work necause of different data types, so changed to char, and that worked
            //declare
            char[] vowels = {'a','e','i','o','u'};

            int count = 0;

            //for each character in the testing string, will check jand see if the char is part of the vowel array
            foreach (char c in testString)
            {
                
                for (int i = 0; i < vowels.Length; i++)
                {
                    //if found to match a char, will add to count, and exit of loop. then move on top the next char    
                    if (c == vowels[i])
                    {
                        count++;
                        break;
                    }
                    
                }

            }

            //return count number
            return count;
        }





       public static string IsPalindrome(string userString)
        {

            //declare
            string newString = "";
            //going through each letter and assigning it to news tring in reverse
            for (int i = userString.Length - 1; i >= 0; i--)
            {
                newString += userString[i];
            }
            //checking to see if reversed string is teh same as old string
            if (userString == newString)
            {
                //if so , output that it is
                return "The word: "+userString+ " IS a palindrome.";
            }

            else
            {
                //if not, output that it isnt
                return "The word: "+userString+" is NOT a Palindrome";
            }
        }
    }
}
