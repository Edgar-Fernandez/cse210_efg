using System.Diagnostics.Metrics;
using System.IO;

// Journal is stored in "memory" using a buffer list.
// Al operations with journal are performed using the buffer list, even saving the buffered joura to a file
// If user wants to load a journal, the buffered journal is "erased" from buffer

public class Journal
{
    public string _fileName;
    public List<string> _journal = new List<string>();
    string[] _separatedEntry;
    public int _counter;
    string[] _lines;


    public void StoreEntry(string entry)
    {   
        _journal.Add(entry);
    }

    public void DeleteEntry(int position)
    {
        _journal.RemoveAt(position);
    }

    public void DisplayJournal()
    {
        if (_journal.Count < 1)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            Console.WriteLine($"\nThe journal contents the following {_journal.Count} entries: \n");
            _counter = 0;
            foreach (string journalEntry in _journal)
            {
                _counter = _counter + 1;
                _separatedEntry = journalEntry.Split("|");
                Console.WriteLine($"{_counter}. Date: {_separatedEntry[0]} - Time: {_separatedEntry[1]} - Prompt: {_separatedEntry[2]}");
                Console.WriteLine($"{_separatedEntry[3]}.");
                //Console.WriteLine(journalEntry);
            }
        }
    }


    public void LoadJournal()
    {
        //NOTE: Loading a journal deletes any existing entry in the "buffer" journal
        _journal.Clear(); //Delete any previous journal
        Console.Write("Please enter the name of the file you want to upload: ");
        _fileName = Console.ReadLine();
        _lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in _lines)
        {
            _journal.Add(line);
        }
        Console.Write($"\nJournal has been loaded from file {_fileName}");
     }


    public void SaveJournal()
    {
        //Here we are saving the journal to a file
        Console.Write("Please enter a name for your file (it should end in \".txt\"): ");
        _fileName = Console.ReadLine();
        Console.WriteLine($"Saving journal entries into {_fileName} file...");

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {  
            foreach (string journalEntry in _journal)
            {
                outputFile.WriteLine(journalEntry);
            }
            
        }
        Console.WriteLine($"File {_fileName} has been created with {_journal.Count} entries.");
    }
}
    