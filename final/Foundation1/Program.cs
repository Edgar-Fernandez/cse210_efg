using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        //Program 1: Abstraction with Youtube Videos

    Video video1 = new Video(); // Create 1rst Video with no comments
    video1._title = "Cute cat";
    video1._author = "Jonh Smith";
    video1.length = 35;
    
    Comment comment1 = new Comment (); // Create 1rst comment
    comment1._name = "Paolo";
    comment1._comment = "The video was great!";
    video1.AddComment(comment1); // Add it to video

    Comment comment2 = new Comment (); // Create 2nd comment
    comment2._name = "Gabriela";
    comment2._comment = "I really liked the cats!";
    video1.AddComment(comment2); // Add it to video

    }
}