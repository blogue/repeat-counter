using System;
using System.Collections.Generic;


namespace WordRepeatCounter
{
  public class RepeatCounter
  {
    private static List<string> _userStrings = new List<string>{"empty", "empty"};

    public int CountRepeats(string userString, string userWord)
    {
      _userStrings[0] = userString;
      _userStrings[1] = userWord;
      int repeatCounter = 0;
      char[] delimCharacters = {' ', ',', '.', '!', '?', ':', ';'};
      string[] userStringArray = userString.Split(delimCharacters);

      for(int i=0; i<userStringArray.Length; i++)
      {
        if(userStringArray[i].ToLower() == userWord.ToLower())
        {
          repeatCounter++;
        }
      }
      return repeatCounter;
    }
  }
}
