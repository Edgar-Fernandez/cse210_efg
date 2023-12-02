using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        //Program 1: Abstraction with Youtube Videos

        List<Video> videos = new List<Video>(); // We create an empty list of Video

        Video video1 = new Video("Cute cats", "Jonh Smith", 35); // Create Video with no comments

        Comment comment1 = new Comment("New_Paolo", "The video was great!"); // Create 1rst comment for video
        video1.AddComment(comment1); // Add it to video
        Comment comment2 = new Comment("Gabriela", "I really liked the cats!"); // Create 2nd comment for video
        video1.AddComment(comment2); // Add it to video
        Comment comment3 = new Comment("Juan Luis", "I have seen other videos like this"); // Create 3rd comment for video
        video1.AddComment(comment3); // Add it to video
        Comment comment4 = new Comment("Jose Jose", "Nice video!"); // Create 4th comment for video
        video1.AddComment(comment4); // Add it to video

        videos.Add(video1); // Add video to List of Video

        // Second Video **************************************************************************************
        Video video21 = new Video("Cake recipe", "Martha Stewart", 250); // Create Video with no comments

        Comment comment21 = new Comment("Ana Julia", "It looks tasty!"); // Create 1rst comment for video
        video21.AddComment(comment21); // Add it to video
        Comment comment22 = new Comment("Maria2023", "It has lots of sugar, I think is not that healty"); // Create 2nd comment for video
        video21.AddComment(comment22); // Add it to video
        Comment comment23 = new Comment("Alex Lora", "Thank you for the recipe"); // Create 3rd comment for video
        video21.AddComment(comment23); // Add it to video
        Comment comment24 = new Comment("FrozenElsa", "Well done!"); // Create 4th comment for video
        video21.AddComment(comment24); // Add it to video
        Comment comment25 = new Comment("Iron Chef", "I want a pice of that cake!"); // Create 4th comment for video
        video21.AddComment(comment25); // Add it to video

        videos.Add(video21); // Add video to List of Video

        // Third Video **************************************************************************************
        Video video31 = new Video("Car accident", "Nicholas Cage", 120); // Create Video with no comments

        Comment comment31 = new Comment("Bond_007", "Never drink and drive"); // Create 1rst comment for video
        video31.AddComment(comment31); // Add it to video
        Comment comment32 = new Comment("Bad Police", "Thankfully no one died (but they were close to)"); // Create 2nd comment for video
        video31.AddComment(comment32); // Add it to video
        Comment comment33 = new Comment("Juan Lopez", "That car saved thir lives!"); // Create 3rd comment for video
        video31.AddComment(comment33); // Add it to video
        Comment comment34 = new Comment("Fast&FuryX", "Another totaled car!"); // Create 4th comment for video
        video31.AddComment(comment34); // Add it to video
        Comment comment35 = new Comment("Maria Leon", "They were really lucky"); // Create 4th comment for video
        video31.AddComment(comment35); // Add it to video

        videos.Add(video31); // Add video to List of Video

        // Fourth Video **************************************************************************************
        Video video41 = new Video("Happy New Year from Huejotzingo", "Carlos Sanchez", 97); // Create Video with no comments

        Comment comment41 = new Comment("Maria Sanchez", "Thanks Carlos for visiting us in Huejotzingo"); // Create 1rst comment for video
        video41.AddComment(comment41); // Add it to video
        Comment comment42 = new Comment("Luisa Sanchez", "We will wait for you next year Carlos!"); // Create 2nd comment for video
        video41.AddComment(comment42); // Add it to video
        Comment comment43 = new Comment("Carlos Sanchez", "Thanks to you Aunt Maria for receiving me with your family!"); // Create 3rd comment for video
        video41.AddComment(comment43); // Add it to video

        videos.Add(video41); // Add video to List of Video

        Console.Clear();
        Console.WriteLine("\n\t>>>>>  LIST OF VIDEOS & COMMENTS  <<<<<");

        int i = 1;
        foreach (Video video in videos) // Display videos and comments
        {
            video.DisplayVideoData(video.CommentsNumber(), i);
            Console.WriteLine();
            i++;
        }
    }
}