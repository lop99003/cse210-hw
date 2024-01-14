using System;

class Program
{
    static void Main(string[] args)
    {
        // Call DisplayWelcome function
        DisplayWelcome();

        // Call PromptUserName function and save the returned name
        string userName = PromptUserName();

        // Call PromptUserNumber function and save the returned number
        int userNumber = PromptUserNumber();

        // Call SquareNumber function with userNumber as a parameter and save the squared result
        int squaredNumber = SquareNumber(userNumber);

        // Call DisplayResult function with userName and squaredNumber as parameters
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt user for name and return the entered name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt user for favorite number and return the entered number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // Function to square a given number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the user's name and squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
