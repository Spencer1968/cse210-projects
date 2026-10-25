using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into individual words
        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }
    }

    public string GetDisplayText()
    {
        string textToDisplay = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            textToDisplay += word.GetDisplayText() + " ";
        }

        return textToDisplay.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }
}