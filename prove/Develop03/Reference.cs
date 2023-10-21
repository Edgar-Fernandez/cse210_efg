using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    // Constructors

    public Reference(string book, int chapter, int verse) // For single verse
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse) // for multiverse
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }


    // Methods

    public string GetReference()
    {
        string reference;
        
        if (_endVerse == 0) // No end verse because it must be a natural number > 0
        {
            reference =  _book + " " + _chapter.ToString() + ":" + _verse.ToString();
        }
        else // We have an end verse
        {
            reference =  _book + " " + _chapter.ToString() + ":" + _verse.ToString() + "-" + _endVerse.ToString();
        }   
        
        return reference;
    }
}