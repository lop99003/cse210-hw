using System;

class Program
{
    static void Main(string[] args)
    {
        //ask the user their grade percentage
        Console.Write("What is your grade percentage? ");
        //the code stores the users answer
        string answer = Console.ReadLine();
        //the code then transforms the user response as an integer into a letter
        int percent = int.Parse(answer);

        //the condition
        string letter = "";

        //if statement
        if (percent >=90)

        //for "A" grade
        {
            letter = "A";
        }

        //in addition to for "B" grade
        else if (percent >= 80)
        {
            letter = "B";
        } 

        //in addition to for "C" grade
        else if (percent >= 70)
        {
            letter = "C";
        } 

        //in addition to for "D" grade
        else if (percent >= 60)
        {
            letter = "D";
        } 

        //if none of those, the grade will end with "F" grade
        else
        {
            letter = "F";
        }

        //output statement to the user using a function string
        Console.WriteLine($"Your grade is: {letter}");

        //general closing statement to the user if 70 and above
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        
        //gernal closing statment to user if 69 and below
        else
        {
            Console.WriteLine("You failed. You need to retake the course. Good luck!");
        }



    }
}