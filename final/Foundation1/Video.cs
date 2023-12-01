public class Video
{
    //Attributes
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    //Constructors
    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _length = lenght;
    }

        public Video()
    {
        _title = "";
        _author = "";
        _length = 0;
    }
    //Methods
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
        return;
    }

    public int CommentsNumber()
    {
        return _comments.Count();
    }

    public void DisplayVideoData(int comments)
    {
        int position = 1;
        Console.WriteLine($"\nVideo \"{_title}\" by {_author} has a length of {_length} seconds");
        Console.WriteLine($"and it received the following {comments} comments: \n");

        foreach (Comment commentDisplayed in _comments)
        {
            Console.WriteLine($"{position}. {commentDisplayed._name}: \"{commentDisplayed._comment}\" ");
            position++;
        }
        return;
    }

}