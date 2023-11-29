using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        //Program 1: Abstraction with Youtube Videos

    List<Video> videos = new List<Video>(); // We create an empty list of Video

    Video video1 = new Video(); // Create 1rst Video with no comments
    video1._title = "Cute cat";
    video1._author = "Jonh Smith";
    video1._length = 35;
    
    Comment comment1 = new Comment (); // Create 1rst comment for video
    comment1._name = "Paolo";
    comment1._comment = "The video was great!";
    video1.AddComment(comment1); // Add it to video

    Comment comment2 = new Comment (); // Create 2nd comment for video
    comment2._name = "Gabriela";
    comment2._comment = "I really liked the cats!";
    video1.AddComment(comment2); // Add it to video

    Comment comment3 = new Comment (); // Create 3rd comment for video
    comment3._name = "Juan Luis";
    comment3._comment = "I have seen other videos like this";
    video1.AddComment(comment3); // Add it to video

    Comment comment4 = new Comment (); // Create 4th comment for video
    comment4._name = "Jose";
    comment4._comment = "Nice video!";
    video1.AddComment(comment4); // Add it to video

    videos.Add(video1);

    Console.Clear();
    
    foreach (Video video in videos)
    {
        video.DisplayVideoData(video.CommentsNumber());
    }

    }
}