using System;

public class Word
{
    private string _word;
    private bool _hidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public bool HideWord()
    {
        if (_hidden == false)
        {
            string hiddenWord = "";

            foreach (char c in _word)
            {
                hiddenWord += "_";
            }

            _word = hiddenWord;
            _hidden = true;
            return true;
        }

        else
        {
            return false;
        }
    }

    public string GetWord()
    {
        return _word;
    }
}