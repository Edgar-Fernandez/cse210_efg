using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");
        //Shape area program

        Console.Clear();
        Console.WriteLine("Shape program\n");
        
        Square square = new Square("Green", 2);
        Console.WriteLine($"The square color is: {square.GetColor()}");
        Console.WriteLine($"The square area is: {square.GetArea()}\n");

        Rectangle rectangle = new Rectangle("Yellow", 3, 4);
        Console.WriteLine($"The rectangle color is: {rectangle.GetColor()}");
        Console.WriteLine($"The rectangle area is: {rectangle.GetArea()}\n");

        Circle circle = new Circle("Red", 5);
        Console.WriteLine($"The cirle color is: {circle.GetColor()}");
        Console.WriteLine($"The circle area is: {circle.GetArea()}\n");

        List<Shape> shapeList = new List<Shape>();

        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        Console.WriteLine("\nList of shapes: \n");
        //int i = 1;

        foreach (Shape sh in shapeList)
        {
            Console.WriteLine($"The {sh.GetColor()} shape area is {sh.GetArea()} \n"); // I changed the output after comparing my program to the example solution
            
            //Console.WriteLine($"The shape {i} color is {sh.GetColor()}");
            //Console.WriteLine($"The shape {i} area is {sh.GetArea()}\n");
            //i++;
        }

        Console.WriteLine();
    }
}