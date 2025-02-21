public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string subject, string title)
        : base(studentName, subject)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
