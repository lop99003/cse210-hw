// Job.cs
public class Job
{
    // Member variables
    public string _company; // Stores the company name
    public string _jobTitle; // Stores the job title
    public int _startYear; // Stores the start year of the job
    public int _endYear; // Stores the end year of the job

    // Display method
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

// Resume.cs
public class Resume
{
    // Member variables
    public string _personName; // Stores the person's name
    public List<Job> _jobs = new List<Job>(); // Stores a list of Job instances

    // Add job to the list
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}

// Program.cs
class Program
{
    static void Main()
    {
        // Create Job instances
        Job job1 = new Job { _company = "Microsoft", _jobTitle = "Software Engineer", _startYear = 2019, _endYear = 2022 };
        Job job2 = new Job { _company = "Apple", _jobTitle = "Manager", _startYear = 2022, _endYear = 2023 };

        // Test Job class
        job1.Display();
        job2.Display();

        // Create Resume instance
        Resume myResume = new Resume { _personName = "Allison Rose" };

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Test Resume class
        myResume.Display();
    }
}
