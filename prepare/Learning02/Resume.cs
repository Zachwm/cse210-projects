using System;

public class Resume
{
    public string _zmName;
    public List<Job> _zmJobs = new List<Job>();
    public void zmDisplay()
    {
        Console.WriteLine($"Name: {_zmName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _zmJobs)
        {
            job.zmDisplay();
        }
    }
}