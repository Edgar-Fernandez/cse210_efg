using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Console.Clear();
        Console.WriteLine("\n\t>>>>>  LIST OF EVENTS  <<<<<");

        Address address1 = new Address("210 West 4th South", "Rexburg", "Idaho", "USA");
        LectureEvent event1 = new LectureEvent("Relativity Theory: A New Aproach", "Re-discover Relativity Theory through \na new analysis based on modern evidence",
        "January 23, 2024", "8:00 PM Mountain Standard Time", address1, "Lecture", "PhD Albert Einstein", 150);
        Console.WriteLine($"\nDetails for event No.1: \n");
        Console.WriteLine(event1.StandardDetails("STANDARD DETAILS"));
        Console.WriteLine(event1.FullDetails());
        Console.WriteLine(event1.ShortDescription());

        Address address2 = new Address("6801 Hollywood Boulevard", "Hollywood", "California", "USA");
        ReceptionEvent event2 = new ReceptionEvent("Mary & John Reception", "Reception for Mary & John's family \nand friends after wedding ceremony",
        "February 14th, 2024", "4:00 PM Central Time", address2, "Reception", "mary&johnreception@weddings.com");
        Console.WriteLine($"\nDetails for event No.2: \n");
        Console.WriteLine(event2.StandardDetails("STANDARD DETAILS"));
        Console.WriteLine(event2.FullDetails());
        Console.WriteLine(event2.ShortDescription());

        Address address3 = new Address("50 North Temple", "Salt Lake City", "Utah", "USA");
        GatheringEvent event3 = new GatheringEvent("Christmas with Tabernacle Choir", "Special Christmas Concert \nin the Gardens of Temple Square",
        "December 23th, 2023", "6:00 PM Mountain Standard Time", address3, "Outdoor Gathering",
        "Temperature Max/Min: 15\u00B0C - 6\u00B0C\nHumidity: 25%, Cloud Amount: 13%\nPrecipitation Amount: 2%");
        Console.WriteLine($"\nDetails for event No.3: \n");
        Console.WriteLine(event3.StandardDetails("STANDARD DETAILS"));
        Console.WriteLine(event3.FullDetails());
        Console.WriteLine(event3.ShortDescription());
    }
}