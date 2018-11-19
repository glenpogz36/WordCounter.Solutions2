using System;
using System.Collections.Generic;
using WordCounter;

namespace ProgramCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("WordCounter");
      Console.WriteLine("Please type in a word");
      string wordInput = Console.ReadLine();
      Console.WriteLine("Please type in a text");
      string textInput = Console.ReadLine();
      RepeatCounter counterInstance = new RepeatCounter();
      counterInstance.SetPrivateInput(wordInput);
      counterInstance.SetPrivateText(textInput);
      string wordToCount = counterInstance.GetPrivateInput();
      string[] textToCount = RepeatCounter.SplitTheText(counterInstance.GetPrivateText());
      int totalCounts = RepeatCounter.CountTheWords(wordToCount, textToCount);
      Console.WriteLine("Count is :"+ totalCounts);
    }
  }
}
