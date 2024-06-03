using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    protected override string GetSpecificDetails()
    {
        return $"RSVP Email: {_rsvpEmail}";
    }
}
