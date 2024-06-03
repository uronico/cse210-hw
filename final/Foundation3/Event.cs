using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.Hours}:{_time.Minutes}\nAddress: {_address.GetFullAddress()}\n";
    }

    public virtual string GetFullDetails()
    {
        string details = GetStandardDetails();
        details += GetSpecificDetails();
        return details;
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }

    protected virtual string GetSpecificDetails()
    {
        return "";
    }
}
