using System;
using System.Collections.Generic;
using System.IO;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * base._lengthInMinutes;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    protected override string _GetType()
    {
        return "Cycling";
    }
}
