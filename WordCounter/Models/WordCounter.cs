using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {


private string _sentence;
private string _word;

public void SetPrivateword(string word)
{
  _word = word;
}

public string GetPrivateword()
{
  return _word;

}

public void SetPrivatesentence(string sentence)
{
  _sentence = sentence;
}

public string GetPrivatesentence()
{
  return _sentence;

}

public static string[] SplitThesentence(string sentence)
{
string[] splitsentence = sentence.Split(' ');
return splitsentence;
}

public static int CountTheWords(string word, string[] splitsentence)
{
  int matches = 0;
  foreach(string sentence in splitsentence)
{
  if (sentence.Equals(word))
  {
     matches ++;
  }
}
  return matches;
}
}

      // // logic will go here
      // Console.WriteLine("word a Word")
      // Console.ReadLine();
      // {
      //   Console.WriteLine("word a Sentence")
      //   Console.ReadLine();
      // }
      // {
      //   Console.Console.WriteLine("Your word matches" + value + "using WordCounter");
      // }



    }
