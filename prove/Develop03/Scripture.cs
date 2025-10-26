using System;
using System.Collections;
using System.Formats.Asn1;

public class Scripture
{
    private string _text;
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(string text)
    {
        _text = text;
    }

    public int MakeList()
    {
        string[] splitText = _text.Split(" ");

        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }

        return _words.Count();
    }

    public int HideWords()
    {
        Random randomGenerator = new Random();
        int hiddenwords = 0;

        for (int i = 0; i < 3; i++)
        {
            int attempts = 0;
            bool canHide = false;

            while (canHide == false)
            {
                int randomIndex = randomGenerator.Next(0, _words.Count());
                canHide = _words[randomIndex].HideWord();
                attempts++;

                if (canHide)
                {
                    hiddenwords++;
                }

                if (attempts >= 50)
                {
                    break;
                }
            }
        }

        return hiddenwords;
    }

    public void MakeReference(string book, int chapter, int firstVerse, int lastVerse = 0)
    {
        if (lastVerse > 0)
        {
            _reference = new Reference(book, chapter, firstVerse, lastVerse);
        }

        else
        {
            _reference = new Reference(book, chapter, firstVerse);
        }
    }

    public void Display()
    {
        string referenceString = _reference.GetReference();
        Console.WriteLine(referenceString);

        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }

    public void TestMemory()
    {
        Console.WriteLine("Let's test if you've memorized the scripture. Please type from memory.");
        string answer = Console.ReadLine();

        if (answer == _text)
        {
            Console.WriteLine("Good work! You've memorized the scripture.");
        }

        else
        {
            Console.WriteLine("Not quite. Try again next time.");
        }
    }
}