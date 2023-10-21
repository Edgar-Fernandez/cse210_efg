using System;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        //Scripture Memorizer program
        /* 
        *************************************************************************************************************************
        STRECHING CHALLENGE: In the Scripture class, we implemented a method that only looks for non hidden words to be hiden.
                                If a random position corresponds to a non hiden wors, the logic doesnt hide that word and gets a
                                new random position por another word. This activity repeats each time the user press enter until 
                                3 random non hidden words are found. Thus, words to hide are alwas different each time the user 
                                press enter.
        *************************************************************************************************************************
        */

        string scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        bool finish;
        string answer = "yes";

        // set reference with constructor
        Reference reference1 = new Reference("Proverbs", 3, 5, 6); // Multi verse reference
        //Reference reference1 = new Reference("1 Nephi", 3, 7); // Single verse reference for TESTING <<--

        Scripture scripture1 = new Scripture(reference1, scripture); // Creates instance of scripture

        do
        {
            Console.Clear(); //Clears screen
            Console.Write(reference1.GetReference() + " ");// Shows reference
            scripture1.ShowScripture(); // Shows scripture
            Console.WriteLine("\n"); // Adds 2 lines

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine(); // reads user answer looking for quit or enter
          
            finish = scripture1.AllHidden(); // Check if all scripture words are hidden
           
            if ((answer == "quit") || finish) // Check if we need to finish the program
            {
                finish = true;
            }
            else
            {
                scripture1.HideWords();
            }
        }
         while (finish != true);
    }
}