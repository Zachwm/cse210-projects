using System;

class zmProgram
{
    static void Main()
    {
        List<zmActivity> zmactivities = new List<zmActivity>();

        zmRunning zmrunningActivity = new zmRunning("Date", 30, 3.0);
        zmCycling zmcyclingActivity = new zmCycling("Date", 15, 15);
        zmSwimming zmswimmingActivity = new zmSwimming("Date", 25, 10);

        zmactivities.Add(zmrunningActivity);
        zmactivities.Add(zmcyclingActivity);
        zmactivities.Add(zmswimmingActivity);

        foreach (var zmactivity in zmactivities)
        {
            Console.WriteLine(zmactivity.zmGetSummary());
        }
    }
}
