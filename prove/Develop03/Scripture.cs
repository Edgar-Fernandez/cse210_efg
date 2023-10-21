using System.CodeDom.Compiler;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture = new List<Word>();  


    // Constructor

    public Scripture (Reference reference, string scripture) // this is a constructor
    {
        _reference = reference; // Stores reference in Scripture data structure

        string[] scriptureWords; // Sets an inirial array of strings

        scriptureWords  = scripture.Split(" "); // split words in scripture using spaces

        for (int i = 0; i < scriptureWords.Length; i++) // store words in structure
        {
           Word tempWord = new Word(scriptureWords[i]);// create instance of word
           _scripture.Add(tempWord); // adds tempWord to array
        }
    }

    // Methods

    public void ShowScripture()
    {
        for (int i = 0; i < _scripture.Count; i++) // Iterate the scripture list        
        {
           _scripture[i].ShowWord();
        }
        return;
    }

    public bool AllHidden()
    { 
        bool allHidden = true; // Initializing flag value. 

        for (int i = 0; i < _scripture.Count; i++) // Iterate the scripture list to check status     
        {
            Word tempWord = _scripture[i]; //Load word from _Scripture

            if (!tempWord.WordIsHidden()) // Check if Word is NOT Hidden
            {
                allHidden = false;
                break;
            }
        }
        return allHidden;
    }

    public void HideWords()
    { 
        Random randomWordIndex = new Random(); // Generate a random index
        
        int hiddenWords = 0; // Sets counter for hidding words in scripture
        int hiddenWords2 = 0; // Sets second countr to check remaining words to hide
        int remaining; // Stores remaining words to hide in scripture
        int totalWords = _scripture.Count; // This sotres the total amount of words in the scripture list
        int toHide = 3; // Number of words to hide in a loop. It should be 3, but when there are less that 3 words 
                        // to Hide in the last loop, we need to adjust this queatity to 2 or 1 to avoid an infinite loop.

        // Count hidden words to find how many non hidden words are left in the scripture
        for (int i = 0; i < _scripture.Count; i++) // Iterate the scripture list to check status     
        {
            Word tempWord = _scripture[i]; //Load word from _Scripture
            if (tempWord.WordIsHidden()) // Check if Word is NOT Hidden
            {
                hiddenWords2 = hiddenWords2 + 1; // increases counter
            }
        }
        remaining = _scripture.Count - hiddenWords2;
        /*Console.WriteLine($"Hidden Words: {hiddenWords2}");
        Console.WriteLine($"Remaining to Hide: {remaining}");
        Console.ReadLine();*/

        if (remaining < toHide) // Checks if we have less that 3 words to hide
        {
            toHide = remaining; // If so, loop will just hide 1 or 2 words instead of 3 (3 is default)
        }

        /*
            HERE IS THE CODE FOR THE STRECHING CHALLENGE!!!
            Already hidden words ae not taking into acoun to be hidden again
            Just non hidden words can be hidden
            Loop repeats until it finds 3 random non hiden words to be hidden, except
            in the last iteration, when we can hide 3, 2 or just 1 remaining word.
        */

        do // loop will repeat until 3 random words are hidden, or less for the last loop.
        {  
            int index = randomWordIndex.Next(0,_scripture.Count); //Sets random index in variable
            Word tempWord = _scripture[index]; //Load random word from _Scripture
            if (!tempWord.WordIsHidden()) // Check if Word is NOT Hidden
            {
                tempWord.HideWord(); // hides the random word
                hiddenWords = hiddenWords + 1; // increases counter
            }
            totalWords = totalWords -1; // 1 word has been hided
        }
        while ((hiddenWords < toHide) ); // Stops until 3 words are hidden. For last loop just 2 or 1 word are hidden.
        return;
    }
}

