using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("05 Apr 2025", 30.0, 4.8),
            new Cycling("05 Apr 2025", 45.0, 20.0),
            new Swimming("05 Apr 2025", 30.0, 50.0)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}