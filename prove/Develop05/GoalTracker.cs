class GoalTracker
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;
    private int level = 1;
    private int experience = 0;
    private int[] levelUps = {25, 50, 75, 100, 150, 200, 250, 300, 400, 500, 750, 1000, 1500};

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (Goal goal in goals)
        {
            if (goal.MatchesName(goalName))
            {
                goal.RecordEvent(ref totalScore);
                experience += goal.GetPoints();
                CheckLevelUp();
                Console.WriteLine("Recorded progress for the goal.");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void CheckLevelUp()
    {
        while (level - 1 < levelUps.Length && experience >= levelUps[level - 1])
        {
            level++;
            Console.WriteLine($"Congrats! You are now level {level}!");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetDisplayText());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
        Console.WriteLine($"Level: {level} | Experience: {experience}/{(level - 1 < levelUps.Length ? levelUps[level - 1] : "MAX")}");
    }

    public void SaveProgress(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"{totalScore}, {level}, {experience}");
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetSaveData());
            }
        }
        Console.WriteLine("Progress saved.");
    }

    public void LoadProgress(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        goals.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string[] mainInfo = reader.ReadLine().Split(',');
            totalScore = int.Parse(mainInfo[0]);
            level = int.Parse(mainInfo[1]);
            experience = int.Parse(mainInfo[2]);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string goalType = parts[0];

                if (goalType == "SimpleGoal")
                {
                    goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                }

                else if (goalType == "EternalGoal")
                {
                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                
                else if (goalType == "ChecklistGoal")
                {
                    goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[4])));
                }
            }
        }
        Console.WriteLine("Progress loaded.");
    }
}