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
            char[] userInput = Console.ReadLine().ToCharArray();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var counter = 0;

            for (var i = 0; i < userInput.Length; i++)
            {
                for (var j = 0; j < vowels.Length; j++)
                {
                    if (userInput[i] == vowels[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}