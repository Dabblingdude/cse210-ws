class UIManager
{
    private GoalTracker _tracker;

    public UIManager(GoalTracker tracker)
    {
        _tracker = tracker;
    }

    public void ShowMenu()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine("\n===== Goal Tracker Menu =====");
            Console.WriteLine("1. Add New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Progress");
            Console.WriteLine("6. Load Progress");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();
            if (input == "1")
            {
                AddGoal();
            }

            else if (input == "2")
            {
                Console.Write("Enter goal name to record progress: ");
                _tracker.RecordEvent(Console.ReadLine());
            }

            else if (input == "3")
            {
                _tracker.DisplayGoals();
            }

            else if (input == "4")
            {
                _tracker.DisplayScore();
            }

            else if (input == "5")
            {
                Console.Write("Enter filename to save progress: ");
                _tracker.SaveProgress(Console.ReadLine()); 
            }

            else if (input == "6")
            {
                Console.Write("Enter filename to load progress: ");
                _tracker.LoadProgress(Console.ReadLine());
            }
            
            else if (input == "7") 
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please select a valid option.");
            }
        }
    }

    private void AddGoal()
    {
        Console.Write("Enter goal type ('1' for Simple, '2' for Eternal, '3' for Checklist): ");
        string input = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points per completion: ");
        int points = int.Parse(Console.ReadLine());

        if (input == "1")
        {
            _tracker.AddGoal(new SimpleGoal(name, description, points));
        }

        else if (input == "2")
        {
            _tracker.AddGoal(new EternalGoal(name, description, points));
        }

        else if (input == "3")
        {
            Console.Write("Enter required completions: ");
            int required = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _tracker.AddGoal(new ChecklistGoal(name, description, points, required, bonus));
        }
    }
}
