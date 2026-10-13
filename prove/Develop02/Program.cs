using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();

        int response = 0;

        while(response != 6)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    myJournal.CreateEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("What file would you like to save your entries to? ");
                    string writeFileName = Console.ReadLine();
                    myJournal.WriteToFile(writeFileName);
                    break;
                case 4:
                    Console.WriteLine("Which file would you like to read your entries from? ");
                    string fileName = Console.ReadLine();
                    myJournal.ReadFromFile(fileName);
                    break;
                case 5:
                    Console.WriteLine("What is the date of the entry you would like to delete? ");
                    string deleteDate = Console.ReadLine();
                    myJournal.DeleteEntry(deleteDate);
                    break;
            }
        }
    }
}