//    Exercise 5
//    Write a program and ask the user to enter an English word.
//    Count the number of vowels (a, e, o, u, i) in the word.
//    So, if the user enters "inadequate", the program should display 6 on the console.

namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an English word");
            var userInput = Console.ReadLine();
            var splitInput = userInput.Split(' ');
            var counter = 0;

            for(var i = 0; i < splitInput.Length; i++)
            {
                if (splitInput[i])
                {
                    counter++;
                }
            }

        }
    }
}