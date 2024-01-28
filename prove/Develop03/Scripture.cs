 using System;
 using System.Collections.Generic;

public class Scripture
{
   private Refrence _refrence;

   public List<Word> _words;

   public void HideRandomWords(int NumToHide)
   {
      int numhide = NumToHide;
   }
   public string GetDisplayText()
   {
      return ($"{_words}");
   }
   public bool IsCompletelyHJiden()
   {
      return true;
   } 
}