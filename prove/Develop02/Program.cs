using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        // This is the Journal Program
        // SHOW CREATIVITY AND EXCEED REQUIREMENTS
        // we added the following functionality:
        // 1. Entries include also the time
        // 2. Entries can be deleted
        // 3. A separate class for Prompt generation was added

        string option;
        int optionInt;
        string randomPrompt;
        string newEntry;
        string position;
        int positionInt;
        int journalSize;

        Journal journal = new Journal(); //We created a new instance of journal to start using it in the program


        //General menu
        do
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Select an option from the menu: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Write New Entry");
            Console.WriteLine("2 - Delete Entry");
            Console.WriteLine("3 - Display Journal");
            Console.WriteLine("4 - Load Journal from file");
            Console.WriteLine("5 - Save journal to file");
            Console.WriteLine("6 - Quit");
            Console.WriteLine("");
            Console.Write("What would you like to do: ");
            option = Console.ReadLine();
            optionInt = int.Parse(option); 
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            

            switch(optionInt)
            {
                case 1: //Write new entry
                    Console.WriteLine("Option: 1 -Write New Entry");  
                    Prompt prompt = new Prompt(); //Generate prompt using class
                    randomPrompt = prompt.NewRandomPrompt(); //We have the prompt question  
                    Entry entry = new Entry(); // We create a new instance of an entry (empty)
                    newEntry = entry.CreateEntry(randomPrompt); // Create entry using a class (fill entry)
                    journal.StoreEntry(newEntry); //Now store complete entry into Journal using class

                break;
                case 2:
                    Console.WriteLine("Option: 2 - Delete Entry\n");
                    journalSize = journal._journal.Count();
                    if (journalSize < 1)
                    {
                        journal.DisplayJournal();
                    }
                    else{
                        journal.DisplayJournal();
                        Console.Write($"\nWhich entry do you want to delete? (1-{journalSize}): ");
                        position = Console.ReadLine();
                        positionInt = int.Parse(position);
                        journal.DeleteEntry(positionInt-1);
                        journal.DisplayJournal();
                    }

                break;
                case 3:
                    Console.WriteLine("Option: 3 - Display Journal\n");
                    journal.DisplayJournal();

                break;
                case 4:
                    Console.WriteLine("Option: 4 - Load Journal\n");
                    journal.LoadJournal();

                break;
                case 5:
                    Console.WriteLine("Option: 5 - Save Journal\n");
                    journal.SaveJournal();

                break;
                case 6:
                    Console.WriteLine("Thanks for using the Journal Program!\n");

                break;
            }
        } while (optionInt != 6);
    }
}