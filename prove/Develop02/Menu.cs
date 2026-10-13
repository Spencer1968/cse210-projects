class Menu
{
    public int ProcessMenu()
    {
        int input = 0;

        while (input < 1 || input > 6)
        {
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("Create, Display, Save, Read, or Delete Journal Entries.");
            Console.WriteLine("1. Create new jounal entry.");
            Console.WriteLine("2. Display all journal entries.");
            Console.WriteLine("3. Save journal to a file.");
            Console.WriteLine("4. Read journal from a file.");
            Console.WriteLine("5. Delete journal entry.");
            Console.WriteLine("6. Quit");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}