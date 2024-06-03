using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address address = new Address("123 Main St", "Anytown","CA","12345");

        Lecture lecture = new Lecture("Introduction to AI", "Learn about AI from a world-class expert.", new DateTime(2023, 03, 20), new TimeSpan(14, 0, 0), address, "Dr. Jane Smith", 100 );
        Reception reception = new Reception("Networking Event", "Join us for an evening of networking and refreshments.", new DateTime(2023, 03, 20), new TimeSpan(18, 0, 0), address, "nicouro@company.com");
        OutdoorGathering gathering = new OutdoorGathering("End of Summer BBQ", "Join us for our end of summer BBQ.", new DateTime(2023, 03, 20), new TimeSpan(16, 0, 0), address, "Partly cloudy, high of 70°F, low of 50°F.");

        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine(gathering.GetFullDetails());

    }
}