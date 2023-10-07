// The main functionality of this class is to generate random prompt questions

public class Prompt
{
    public List<string> _prompts = new List<string> //initializing pompt questions
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Who did you help today?",
        "What was the most productive activity you did today?",
        "What was the best decision you took today?",
        "In which personal goal did you work today?",
        "What scripture did you study today?"
    };
    string _prompt;


    public string NewRandomPrompt()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(0,9);
        _prompt = _prompts[index];
        
        return _prompt;
    }



}
