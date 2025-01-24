public class Job
{
    public int _startYear;
    public int _endYear;
    public string _company;
    public string _jobTitle;
    
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}