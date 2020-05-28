using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rand = new Random();

            int secretNumber =rand.Next(1, 101);

            int guessesGiven = 0;
            Console.WriteLine("Welcome to ***Guess The Number*** Choose your difficulty level- Easy, Medium, or Hard");
            string difficultyLevel = Console.ReadLine();


            while(guessesGiven < 4)
            { 
                Console.WriteLine($"Guess the Secret Number! Your guess ({guessesGiven + 1})");
                string userGuess = Console.ReadLine();
                int parsedUserGuess = Int32.Parse(userGuess);

                if (parsedUserGuess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (parsedUserGuess < secretNumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (parsedUserGuess == secretNumber) 
                {
                Console.WriteLine("You Win!");
                break;
                }
                else 
                {
                Console.WriteLine("Nope, try again!");
                }

            guessesGiven++;
        }
           
        }
    }
}
