public class Comment
{
    public string _name;
    public string _comment;

    //Constructors
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }
        public Comment()
    {
        _name = "";
        _comment = "";
    }
}