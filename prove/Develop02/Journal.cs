class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public string _currentFile = "";

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }

    public void WriteToFile(string filename)
    {
        _currentFile = filename;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {          
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        _currentFile = filename;
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            JournalEntry entry = new JournalEntry();
            entry.CreateJournalEntry(date, question, entryText);
            _entries.Add(entry);
        }
    }

    public void DeleteEntry(string dateToDelete)
    {
        JournalEntry entryToRemove = null;

        // Look through each entry using a stanard foreach loop
        foreach (JournalEntry entry in _entries)
        {
            if (entry._date == dateToDelete)
            {
                entryToRemove = entry;
            }
        }

        // If we found a matching entry, remove it from the list
        if (entryToRemove != null)
        {
            _entries.Remove(entryToRemove);
            Console.WriteLine("Entry successfully deleted.");

            if (_currentFile != "")
            {
                WriteToFile(_currentFile);
                Console.WriteLine($"File '{_currentFile}' has been automatically updated.");
            }
            else
            {
                Console.WriteLine("Note: No file was loaded yet, so the file wasn't updated automatically.");
            }
        } else
        {
            Console.WriteLine("No entry found with that date.");
        }
    }
}