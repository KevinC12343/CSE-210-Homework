using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

class Program
{        public class Scripture
    {
        //Scripture class
        private Refrence _refrence;

        List<string> _words = new List<string>();
        public void HideRandomWords(int NumToHide)
        {
          int numhide = NumToHide;
        }
        public string GetDisplayText()
        {
          return ($"{_words}");
        }
        public bool IsCompletelyHiden()
        //is Hidden class
        {
        return true;
        } 
}
        public class Refrence
        //Refrence class
        {
            String _book;
            int _chapter;
            int _verse;
            int _endVerse;

            public Refrence(string book, int chapter, int verse)
            {
                _book = book;
                _chapter = chapter;
                _verse = verse;

            }
            public Refrence(string book, int chapter, int startVerse, int endVerse)
            {
                _book = book;
                _chapter = chapter;
                _verse = startVerse;
                _endVerse = endVerse;
            }
        public string GetDisplayText()
        {
            return ($"{_book} {_chapter} {_verse}");
        }
        }
        public class Word
        //word class
        {
           string _text;
           bool _IsHidden;
           public Word(string text)
           {
            _text = text;
           }
           public void Hide()
           {

           }
           public void Show()
           {

           }
           bool isHidden()
           {
            return true;
           }
           public string GetDisplayText()
           {
            return "";
           }
        }
    static void Main(string[] args)
    {
        //print out the scripture and prompts
        //Console.WriteLine(Word);

        Console.WriteLine("Press enter to Continue or type 'quit' to quit: ");
        String responce = Console.ReadLine();

        if (responce == "Quit")
        {
            System.Environment.Exit(3);
        }
        else
        {
            foreach (Word in Word)
            {
                Console.WriteLine(Word);
            }
        }
    }

        }

