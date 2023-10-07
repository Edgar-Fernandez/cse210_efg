using System.Security.Cryptography.X509Certificates;

// The main functionality of this class is to create entries

public class Entry
{
    public string _entry;
    public string _dateInText;
    public string _timeInText;
    //string _prompt;
    public string _answer;

    
    public string CreateEntry(string prompt)//, string answer)
    {
        Console.WriteLine(prompt); //Writes the prompt received as parameter
        Console.Write("> ");
        _answer = Console.ReadLine(); //We have stored the user's answer*/
        DateTime actualDateAndTime = DateTime.Now;
        _dateInText = actualDateAndTime.ToShortDateString();
        _timeInText = actualDateAndTime.ToShortTimeString();
        _entry = _dateInText + "|" + _timeInText + "|" + prompt + "|" + _answer;//answer;     
          
        return _entry;
    }
    
    
}