using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(ref int totalScore);
    public abstract string GetDisplayText();
    public abstract string GetSaveData();
    
    public bool MatchesName(string name)
    {
        return _name.Equals(name, StringComparison.OrdinalIgnoreCase);
    }
}