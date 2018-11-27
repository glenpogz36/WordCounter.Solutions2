using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _word;

    public void SetPrivateInput(string word)
    {
      _word = word;
    }

    public string GetPrivateInput()
    {
      return _word;

    }

    public void SetPrivateText(string sentence)
    {
      _sentence = sentence;
    }

    public string GetPrivateText()
    {
      return _sentence;

    }

    public static string[] SplitTheText(string sentence)
    {
    string[] splitsentence = sentence.Split(' ');
    return splitsentence;
    }

    public static int CountTheWords(string target, string[] words)
    {
      int matches = 0;
      foreach(string word in words)
    {
      if (word.Equals(target))
      {
         matches ++;
      }
    }
      return matches;
    }

  }
}
