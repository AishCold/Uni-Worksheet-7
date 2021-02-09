using System;

namespace L7_3_RemoveAllVowels
{
    /*In this program, the user inputs a string
     and the code outputs the string after remnoving the vowels*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vowel Removing Application");
            Console.WriteLine("Input a word or a phrase");
            string input = Console.ReadLine();

            while(input.Contains('a') || input.Contains('e') || input.Contains('i') || input.Contains('o') || input.Contains('u'))
            {
                int indexOfA = input.IndexOf('a');
                input = input.Remove(indexOfA, 1);
            }

            Console.WriteLine(input);
        }
    }
}