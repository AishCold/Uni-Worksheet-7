using System;

namespace L7_1_ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse a string application");
            Console.WriteLine("Input a word or phrase:");

            //user types in input, string variable is created to contain the user's input

            string userInput = Console.ReadLine();

            //first step to reverse the user's input: convert the string into a character array

            char[] inputArray = userInput.ToCharArray();

            //a loop that loops over half of the array
            //As we iterate over each element in the loop we will swap it with the corresponding element in the other half of the array.

            for(int i = 0; i < inputArray.Length / 2; i++)
            {
                char temp = inputArray[i];
                inputArray[i] = inputArray[inputArray.Length - 1 - i];
                inputArray[inputArray.Length - 1 - i] = temp;
            }

            userInput = new string(inputArray);

            Console.WriteLine(userInput);
        }
    }
}
