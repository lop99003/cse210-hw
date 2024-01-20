using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public string ToFileString()
    {
        return $"{Date},{Prompt},{Response}";
    }

    public static Entry FromFileString(string entryString)
    {
        string[] parts = entryString.Split(',');
        return new Entry(parts[1], parts[2], parts[0]);
    }
}

class Journal
{
    private readonly List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    sw.WriteLine(entry.ToFileString());
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            entries.Clear(); // Clear existing entries before loading
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Entry loadedEntry = Entry.FromFileString(line);
                    entries.Add(loadedEntry);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        // List of prompts for the user
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is a goal I want to accomplish tomorrow?",
            "What made me laugh out loud today?",
            "Describe a moment of kindness you witnessed or experienced.",
            "What is something new you learned today?",
            "If today were a chapter in a book, what would its title be?"
        };

        while (true)
        {
            Console.WriteLine("🌟 Welcome to Your Journal Oasis! 🌟");
            Console.WriteLine("1. 📝 Embrace the Joy of a New Entry 📝"); // Option 1: Create a new journal entry
            Console.WriteLine("2. 📚 Rediscover Your Past Adventures 📚"); // Option 2: Display all journal entries
            Console.WriteLine("3. 💾 Preserve Your Masterpiece to the Eternal Pages 💾"); // Option 3: Save journal to a file
            Console.WriteLine("4. 📤 Journey Back to Relive Glorious Moments 📤"); // Option 4: Load journal from a file
            Console.WriteLine("5. 🚪 Bid Adieu (Exit) 🚪"); // Option 5: Exit the program

            Console.Write("☝️ Select your quest (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string randomPrompt = prompts[new Random().Next(prompts.Length)];
                    Console.WriteLine($"🚀 Today's Adventure: {randomPrompt}");
                    Console.Write("Captivate the world with your response: ");
                    string response = Console.ReadLine();
                    string currentDate = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry(randomPrompt, response, currentDate);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("✨ Entry Added! Your saga continues!");
                    break;

                case 2:
                    Console.WriteLine("🔍 Exploring the Chronicles of Your Past...");
                    journal.DisplayJournal();
                    break;

                case 3:
                    Console.Write("✨ Choose a name for the tome to house your epic: ");
                    string saveFileName = Console.ReadLine() + ".txt";
                    string saveFullPath = Path.Combine(Environment.CurrentDirectory, saveFileName);
                    journal.SaveToFile(saveFullPath);
                    Console.WriteLine($"📜 Your Journey Preserved! The saga lives on in {saveFullPath}!");
                    break;

                case 4:
                    Console.Write("📚 Open the tome to revisit your cherished moments: ");
                    string loadFileName = Console.ReadLine() + ".txt"; // Use the correct file extension
                    string loadFullPath = Path.Combine(Environment.CurrentDirectory, loadFileName);
                    if (File.Exists(loadFullPath))
                    {
                        journal.LoadFromFile(loadFullPath);
                        Console.WriteLine("🚀 Moments Relived! The magic is eternal!");
                    }
                    else
                    {
                        Console.WriteLine($"❌ File {loadFullPath} not found. Make sure the file exists and try again.");
                    }
                    break;

                case 5:
                    Console.WriteLine("👋 Until We Meet Again! Keep Creating!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("⚠️ Whoops! That wasn't a valid choice. Choose wisely (1-5).");
                    break;
            }
        }
    }
}
