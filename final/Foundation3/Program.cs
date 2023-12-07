using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Console.Clear();
        Address address1 = new Address("21 Jump street","Springfield", "Oklahoma", "USA");
        Event event1 = new Event("Oscars 2024", "Oscar's Price Gala 2024", "January 23, 2024", "8:00pm MT", address1);
        //Console.WriteLine(event1.StandardDetails("STANDARD DETAILS"));

        Address address2 = new Address("210 West 4th South","Rexburg", "Idaho", "USA");
        LectureEvent event2 = new LectureEvent("Relativity Theory: A New Aproach", "Re-discover Relativity Theory through \na new analysis based on modern evidence", 
        "January 23, 2024", "8:00 PM Mountain Time", address2, "Phd. Albert Einstein", 150);      
        Console.WriteLine(event2.StandardDetails("STANDARD DETAILS"));
        Console.WriteLine(event2.FullDetails());
        Console.WriteLine(event2.ShortDescription());
    }
}