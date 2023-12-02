using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        //This program creates product orders

        Address address1 = new Address("203 Sunshine Boulevard", "Springfied", "Masachusets", "USA"); //Address is created
        Customer customer1 = new Customer("Walmart Inc.", address1);          // Customer is created using the address
        Product product1 = new Product("Twinky Wonder", "PAS017", 15.20, 11);   // 1rst product is created
        Product product2 = new Product("Cheese Crackers", "GAL035", 12.10, 12); // 2nd product is created
        Product product3 = new Product("Doritos Nachos", "PAP035", 19, 10);    // 3rd product is created
        List<Product> products1 = new List<Product>                            // Products list is created using products
        {
            product1,
            product2,
            product3
        };
        Order order1 = new Order(products1, customer1); // Finally, Order is created using products list and customer

        Address address21 = new Address("21 Jump Street", "Ajax", "Ontario", "Canada"); //Address is created
        Customer customer21 = new Customer("Real Canadian Superstore Inc.", address21);     // Customer is created using the address
        Product product21 = new Product("Fritos Original", "PAS2017", 2.20, 10);   // 1rst product is created
        Product product22 = new Product("Lay's X Cheese", "GAL2035", 2.10, 20); // 2nd product is created
        Product product23 = new Product("Cheetos Crunchy", "PAP2035", 3, 30);    // 3rd product is created
        Product product24 = new Product("Rold Gold  Xtra", "PAP2035", 2.5, 10);    // 3rd product is created
        List<Product> products21 = new List<Product>                            // Products list is created using products
        {
            product21,
            product22,
            product23,
            product24
        };
        Order order21 = new Order(products21, customer21); // Finally, Order is created using products list and customer    

        List<Order> orders = new List<Order> // A new list of orders is created to iterate it showing Packing and shipping labels, and also the cost of the order
        {
            order1,
            order21
        };

        Console.Clear();
        Console.WriteLine("\n\t>>>>>  LIST OF ORDERS  <<<<<");

        int i = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"\nDetails for order No.{i}: \n");
            order.Packinglabel();
            order.ShippingLabel();
            order.TotalPrice();
            i++;
        }
    }
}