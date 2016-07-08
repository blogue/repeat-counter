using System.Text;
using System.Collections.Generic;
using System;


namespace WordRepeatCounter
{
  public class RepeatCounter
  {
    private List<string> _userStrings = new List<string>{"empty", "empty"};
    private int _repeatCounter = 0;
    public int CountRepeats(string userString, string userWord)
    {
      _userStrings[0] = userString;
      _userStrings[1] = userWord;

      char[] delimCharacters = {' ', ',', '.', '!', '?', ':', ';' , '"', '-', '(', ')'};
      string[] userStringArray = userString.Split(delimCharacters);
      for(int i=0; i<userStringArray.Length; i++)
      {
        if(userStringArray[i].ToLower() == userWord.ToLower())
        {
          _repeatCounter++;
        }
      }
      return _repeatCounter;
    }
    public StringBuilder Highlight(string sentenceToHighlight, string wordToHighlight)
    {
      StringBuilder highlight = new StringBuilder(sentenceToHighlight);
      highlight.Replace(wordToHighlight, "*" + wordToHighlight + "*");

      return highlight;
    }
    public List<string> GetStrings()
    {
      return _userStrings;
    }
    public int GetCount()
    {
      return _repeatCounter;
    }
  }
}
