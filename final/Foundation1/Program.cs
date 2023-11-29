using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        //Program 1: Abstraction with Youtube Videos

    List<Video> videos = new List<Video>(); // We create an empty list of Video

    Video newVideo = new Video(); // Create 1rst Video with no comments
    newVideo._title = "Cute cat";
    newVideo._author = "Jonh Smith";
    newVideo._length = 35;
    
    Comment newComment = new Comment (); // Create 1rst comment for video
    newComment._name = "Paolo";
    newComment._comment = "The video was great!";
    newVideo.AddComment(newComment); // Add it to video

    Comment comment2 = new Comment (); // Create 2nd comment for video
    comment2._name = "Gabriela";
    comment2._comment = "I really liked the cats!";
    newVideo.AddComment(comment2); // Add it to video

    Comment comment3 = new Comment (); // Create 3rd comment for video
    comment3._name = "Juan Luis";
    comment3._comment = "I have seen other videos like this";
    newVideo.AddComment(comment3); // Add it to video

    Comment comment4 = new Comment (); // Create 4th comment for video
    comment4._name = "Jose";
    comment4._comment = "Nice video!";
    newVideo.AddComment(comment4); // Add it to video

    videos.Add(newVideo);

    //********************************************

    

    Console.Clear();
    
    foreach (Video video in videos)
    {
        video.DisplayVideoData(video.CommentsNumber());
    }

    }
}