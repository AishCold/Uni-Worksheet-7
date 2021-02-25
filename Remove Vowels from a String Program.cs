using System;

namespace L9_4_RemoveLettersFromString
{
    /*In this program, the user inputs a word/phrase, and the program removes the vowels and outputs
     the result.*/
    class Program
    {
        public static string RemoveLettersFromString(string pString, char pRemoveChar)
        {
            while (pString.IndexOf(pRemoveChar) != -1)
            {
                pString = pString.Remove(pString.IndexOf(pRemoveChar), 1);
            }

            return pString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Remove Letters From A String");
            Console.WriteLine("Input a word or phrase");
            string test = Console.ReadLine();
            test = test.ToLower();

            test = RemoveLettersFromString(test, 'a');
            test = RemoveLettersFromString(test, 'e');
            test = RemoveLettersFromString(test, 'i');
            test = RemoveLettersFromString(test, 'o');
            test = RemoveLettersFromString(test, 'u');

            Console.WriteLine(test);
        }
    }
}