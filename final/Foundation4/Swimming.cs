using System;
using System.Collections.Generic;
using System.IO;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / base._lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return base._lengthInMinutes / GetDistance();
    }

    protected override string _GetType()
    {
        return "Swimming";
    }
}
