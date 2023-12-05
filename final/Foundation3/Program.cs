using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Console.Clear();
        Address address1 = new Address("21 Jump street","Springfield", "Oklahoma", "USA");
        Event event1 = new Event("Oscars 2024", "Oscar's Price Gala 2024", "January 23, 2024", "8:00pm MT", address1);
        Console.WriteLine(event1.StandardDetails());
    }
}