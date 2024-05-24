using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private int amountCompleted;
    private int target;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        amountCompleted = 0;
        this.target = target;
        this.bonus = bonus;
    }

    public override void RecordEvent()
    {
        amountCompleted++;
        if (amountCompleted >= target)
        {
            // award bonus points
        }
    }

    public override bool IsComplete()
    {
        return amountCompleted >= target;
    }

    public override string GetDetailsString()
    {
        return $"Completed {amountCompleted}/{target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist: {name} ({description}) - {points} points";
    }
}