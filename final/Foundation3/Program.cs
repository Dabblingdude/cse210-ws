using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address addr0 = new Address("12345 Main St", "New York City", "NY", "USA");
        Address addr1 = new Address("67890 2nd St", "Metro Manila", "Manila", "PH");
        Address addr2 = new Address("13579 145th Ave","Metro York","Kyoto","Japan");
    
        events.Add(new Lecture("#1 University Lecture", "How to Graduate", "2025, 4, 12", "1:00 PM", addr0, "President Guy", 5000));
        events.Add(new Reception("Your Bud's Wedding Reception", "Join us to celebrate this union", "2025, 5, 13", "6:00 PM", addr1, "plsRSVP@gmail.com"));
        events.Add(new OutdoorGathering("Work Sponsored Picnic", "Fun for the whole family", "2045, 6, 14", "7:00 AM", addr2, "Rainy, 62F"));
    
        foreach (Event plan in events)
        {
            Console.WriteLine("\n========== Standard Details ==========");
            Console.WriteLine(plan.GetStandardDetails());

            Console.WriteLine("\n========== Full Details ==========");
            Console.WriteLine(plan.GetFullDetails());

            Console.WriteLine("\n========== Short Details ==========");
            Console.WriteLine(plan.GetShortDescription());

            
            Console.WriteLine("\n\n\n==================== Next Event ====================\n\n");
        }
    }
}