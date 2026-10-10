using System;
using System.Security.Cryptography.X509Certificates;

namespace Number_guessing_Game;

class Program
{

    static void Main(string[] args)




    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 11); // Generates a random number between 1 and 10
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("Guess a number between 1 and 10:");
            int playerGuess = Convert.ToInt32(Console.ReadLine());   //Convert the input to an integer


            if (playerGuess == numberToGuess)            // Check if the player's guess is correct
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                break;
            }
            else if (playerGuess < numberToGuess)
            {    
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }
        }
    }

}
