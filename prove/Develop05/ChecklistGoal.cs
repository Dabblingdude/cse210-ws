class ChecklistGoal : Goal
{
    private int _completedTimes;
    private int _requiredTimes;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int requiredTimes, int bonusPoints, int completedTimes = 0) : base(name, description, points)
    {
        _requiredTimes = requiredTimes;
        _bonusPoints = bonusPoints;
        _completedTimes = completedTimes;
    }

    public override void RecordEvent(ref int totalScore)
    {
        if (_completedTimes < _requiredTimes)
        {
            _completedTimes++;
            totalScore += _points;

            if (_completedTimes == _requiredTimes)
            {
                totalScore += _bonusPoints;
            }
        }
    }

    public override string GetDisplayText()
    {
        return $"[{(_completedTimes >= _requiredTimes ? "X" : " ")}] {_name}: {_description} ({_points} points, {_completedTimes}/{_requiredTimes} completed)";
    }

    public override string GetSaveData()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_completedTimes},{_requiredTimes},{_bonusPoints}";
    }
}