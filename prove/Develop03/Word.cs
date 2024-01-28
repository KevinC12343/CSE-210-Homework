using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }
    private void hide()
    {

    }
    private void Show()
    {

    }
    private bool IsHidden()
    {
        return true;
    }
    public string GetDisplayText()
    {
        return ($"{_text}");
    }

}