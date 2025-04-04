class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent(ref int totalScore)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            totalScore += _points;
        }
    }

    public override string GetDisplayText()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name}: {_description} ({_points} points)";
    }

    public override string GetSaveData()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }
}