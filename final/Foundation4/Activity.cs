using System;
using System.Collections.Generic;
using System.IO;

public abstract class Activity
{
    private DateTime _date;
    public int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        throw new NotImplementedException();
    }

    public virtual double GetSpeed()
    {
        throw new NotImplementedException();
    }

    public virtual double GetPace()
    {
        throw new NotImplementedException();
    }

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_GetType()}({_lengthInMinutes} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }

    protected abstract string _GetType();
}
