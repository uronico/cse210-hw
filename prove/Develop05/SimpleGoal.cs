using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        isComplete = false;
    }

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return $"Simple: {name} ({description}) - {points} points";
    }
}
