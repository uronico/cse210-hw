using System;
using System.Collections.Generic;
using System.IO;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / base._lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return base._lengthInMinutes / _distance;
    }

    protected override string _GetType()
    {
        return "Running";
    }
}
