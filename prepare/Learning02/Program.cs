using System;

class Program
{
    static void Main(string[] args)
    {      
        Job job1 = new Job();

        job1._startYear = 2020;
        job1._endYear = 2024;
        job1._company = "Aperture Science";
        job1._jobTitle = "Test Subject #62";
        
        Job job2 = new Job();

        job2._startYear = 2015;
        job2._endYear = 2017;
        job2._company = "Noodle Tech";
        job2._jobTitle = "Taste Tester";

        Resume myResume = new Resume();

        myResume._name = "Sam Niemand";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}