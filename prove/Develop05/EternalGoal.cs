class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    public override void RecordEvent(ref int totalScore)
    {
        totalScore += _points;
    }

    public override string GetDisplayText()
    {
        return $"[∞] {_name}: {_description} ({_points} points per completion)";
    }

    public override string GetSaveData()
    {
        return $"EternalGoal,{_name},{_description},{_points}";
    }
}