using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        int totalPoints = GetPoints();
        if (_amountCompleted >= _target)
        {
            totalPoints += _bonus;
            // Console.WriteLine($"Congratulations! You have completed the checklist goal and earned an additional {_bonus} points!"); ////totalpoints ??
            Console.WriteLine($"Congratulations! You have earned the {_bonus} of bonus points!"); // only bonus
            Console.WriteLine($"You have earned in total {totalPoints} points."); // total points at this goal
        }
        else
        {
            // Console.WriteLine($"You have completed {_amountCompleted} out of {_target} tasks. Keep going!");
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_amountCompleted}|{_bonus}";
    }
}