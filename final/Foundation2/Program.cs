using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        //This program creates product orders

        //Create 1 address
        //Create 1 customer with the address
        //Create 2 products
        //create 1 order
        Console.Clear();

        Address address1 = new Address("203 Sunshine Boulevard", "Springfied", "Masachusets", "USA");
        Customer customer1 = new Customer ("La Surtidora Inc.", address1);
        Product product1 = new Product("Twinky Wonder", "PAS017", 15.20, 5);
        Product product2 = new Product("Cheese Crackers", "GAL035", 12.10, 3);
        Product product3 = new Product("Doritos Nachos", "PAP035", 19, 10);
        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        products1.Add(product3);
        Order order1 = new Order(products1, customer1);
        Console.WriteLine();

        // Print Shipping Label
        // Print Packing Label
        // Print Total price of the order
        // Print Order details (NEW)

        order1.Packinglabel();
        order1.ShippingLabel();
    }
}