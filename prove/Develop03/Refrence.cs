using System;

public class Refrence
{
    private string _book;
    private int _chapter;
     private int _startverse;
     private int _endVerse;

     public Refrence(string book, int chapter, int startverse, int endVerse)
     {

        _book = book;
        _chapter =chapter;
        _startverse = startverse;
        _endVerse = endVerse;
     }
     public string GetDisplayText()
     {
        return ("$ {_book} ");
     }
}