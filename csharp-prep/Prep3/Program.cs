using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the PlayGuessMyNumberGame function to start the game
        PlayGuessMyNumberGame();
    }

    static void PlayGuessMyNumberGame()
    {
        // Display the initial greeting
        Console.WriteLine("Hello Prep3 World!");

        // Variables to store the magic number, user guess, and guess count
        int magicNumber;
        int userGuess;
        int guessCount = 0;

        // Get the magic number from the user
        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());

        // Game loop, continues until the user guesses the correct number
        do
        {
            // Get the user's guess
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            guessCount++;

            // Provide feedback to the user based on their guess
            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (userGuess != magicNumber);

        // Display the number of guesses made by the user
        Console.WriteLine($"Number of guesses: {guessCount}");

        // Ask the user if they want to play again
        Console.Write("Do you want to play again? (yes/no): ");
        string response = Console.ReadLine().ToLower();

        // If the user wants to play again, recursively call PlayGuessMyNumberGame
        if (response == "yes")
        {
            PlayGuessMyNumberGame();
        }
    }
}
