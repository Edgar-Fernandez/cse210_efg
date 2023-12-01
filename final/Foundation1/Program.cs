using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        //Program 1: Abstraction with Youtube Videos

        List<Video> videos = new List<Video>(); // We create an empty list of Video

        Video video1 = new Video("Cute cat", "Jonh Smith", 35); // Create 1rst Video with no comments

        Comment comment1 = new Comment("Paolo", "The video was great!"); // Create 1rst comment for video
        video1.AddComment(comment1); // Add it to video
        Comment comment2 = new Comment("Gabriela", "I really liked the cats!"); // Create 2nd comment for video
        video1.AddComment(comment2); // Add it to video
        Comment comment3 = new Comment("Juan Luis", "I have seen other videos like this"); // Create 3rd comment for video
        video1.AddComment(comment3); // Add it to video
        Comment comment4 = new Comment("Jose", "Nice video!"); // Create 4th comment for video
        video1.AddComment(comment4); // Add it to video

        videos.Add(video1); // Add video to List of Video

        //********************************************


        Video video21 = new Video("Cake recipe", "Martha Stewart", 250); // Create 1rst Video with no comments

        Comment comment21 = new Comment("Ana Julia", "It looks tasty!"); // Create 1rst comment for video
        video21.AddComment(comment21); // Add it to video
        Comment comment22 = new Comment("Maria Juana", "It has lots of sugar, I think is not that healty"); // Create 2nd comment for video
        video21.AddComment(comment22); // Add it to video
        Comment comment23 = new Comment("Alejandro Fernandez", "Thank you for the recipe"); // Create 3rd comment for video
        video21.AddComment(comment23); // Add it to video
        Comment comment24 = new Comment("Elsa de Lourdes", "Well done!"); // Create 4th comment for video
        video21.AddComment(comment24); // Add it to video
        Comment comment25 = new Comment("Iron Chef", "I want a pice of that cake!"); // Create 4th comment for video
        video21.AddComment(comment25); // Add it to video

        videos.Add(video21); // Add video to List of Video

        Console.Clear();

        foreach (Video video in videos) // Display videos and comments
        {
            video.DisplayVideoData(video.CommentsNumber());
        }

    }
}