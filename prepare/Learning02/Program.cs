using System;

class Program
{
    static void Main(string[] args)
    {
        // Create new Resume object
        Resume resume = new Resume();
        // Create and populate new Job object
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // Create and populate second Job object
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Add the two jobs to the _jobs list in the Resume object
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Set name
        resume._name = "Allison Rose";

        // Display all jobs
        resume.Display();
    }
>>>>>>> 204b65796b019f02f18515ff28d1d6f41b8347f3
}