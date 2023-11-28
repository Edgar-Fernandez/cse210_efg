public class Video
{
    //Attributes
    public string _title;
    public string _author;
    public int length;
    public  List<Comment> _comments = new List<Comment>();

    //Methods

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
        return;
    }

    public int CommentsNumber()
    {
        return 0;
    }

    public void DisplayVideoData()
    {
        return;
    }

}