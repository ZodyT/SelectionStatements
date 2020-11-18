using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("What is my favoritve number?");
            var userInput = int.Parse(Console.ReadLine());

            bool Conditional = true;

            while (Conditional)
            {
                if (userInput < favNumber)
                {
                    Console.WriteLine("Your guess is too low");
                    Console.WriteLine("Guess again");
                    userInput = int.Parse(Console.ReadLine());
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Your guess is too high");
                    Console.WriteLine("Guess again");
                    userInput = int.Parse(Console.ReadLine());
                }

                else if (userInput == favNumber)
                {
                    Console.WriteLine("Good Job!");
                    Conditional = false;
                }
            }
        }
    }
}
