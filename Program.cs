using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            #region 
            //var rand = new Random();
            //var favNumber = rand.Next(1, 1000);

            //Console.WriteLine("Try to guess my favorite number");
            //var userInput = int.Parse(Console.ReadLine());

            //while (favNumber != userInput)
            //{
            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine("Your number is too low!");
            //        userInput = int.Parse(Console.ReadLine());
            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine("Your number is too high!");
            //        userInput = int.Parse(Console.ReadLine());
            //    }
            //    else if (userInput == favNumber)
            //    {
            //        Console.WriteLine("Your number is just right!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nevermind");
            //    }
            //}
            #endregion

            //Exercise 2
            #region
            Console.WriteLine("What is your favorite school subject:");
            Console.WriteLine("History");
            Console.WriteLine("English");
            Console.WriteLine("Math");
            Console.WriteLine("Science");

            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "History":
                    Console.WriteLine("Why? That's all in the past");
                    break;
                case "English":
                    Console.WriteLine("You already speak the language");
                    break;
                case "Math":
                    Console.WriteLine("Nerd");
                    break;
                case "Science":
                    Console.WriteLine("Have you tried being a cool kid");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            #endregion
        }
    }
}
