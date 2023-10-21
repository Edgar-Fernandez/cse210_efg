public class Word
{
    private string _word;
    private bool _isHidden;

    // Constructor
   
    public Word(string word) // this is a constructor as indicated in design activity
    {
        _word = word;
        _isHidden = false;
    }
    

    // Methods

    public void HideWord()
    {
        _isHidden = true;
        return;
    }

    public void ShowWord()
    {
        if (_isHidden)
        {
            for (int i = 0; i < _word.Length; i++)
            {
                Console.Write('_'); // change char to use something different to hide
            }
            Console.Write(' '); // adds an space at the end of the word as separator
        }
        else
        {
            Console.Write(_word);
            Console.Write(' '); // adds an space at the end of the word as separator
        }     
        return;  
    }

    public bool WordIsHidden()
    {
        return _isHidden;
    }

}