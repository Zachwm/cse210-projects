// Resume
// CSE 210
// Zach McLaughlin
// A resume that allows for the addition of new jobs into the class

using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._zmJobTitle = "Software Engineer";
        job1._zmCompany = "Microsoft";
        job1._zmStartYear = 2019;
        job1._zmEndYear = 2022;

        Job job2 = new Job();
        job2._zmJobTitle = "Manager";
        job2._zmCompany = "Apple";
        job2._zmStartYear = 2022;
        job2._zmEndYear = 2023;

        Resume zmMyResume = new Resume();
        zmMyResume._zmName = "Zach McLaughlin";

        zmMyResume._zmJobs.Add(job1);
        zmMyResume._zmJobs.Add(job2);

        zmMyResume.zmDisplay();
    }
}