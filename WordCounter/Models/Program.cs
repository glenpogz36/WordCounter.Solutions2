using System;
using System.Collections.Generic;
using WordCounter;


public class Program
{
    public static void Main()
  {
    Console.WriteLine("Check how frequently the word appears in the sentence");
    Console.WriteLine("Please type in a word");
    string words = Console.ReadLine();
    Console.WriteLine("Please type in a sentence");
    string sentences = Console.ReadLine();
    RepeatCounter counterInstance = new RepeatCounter();
    counterInstance.SetPrivateInput(words);
    counterInstance.SetPrivateText(sentences);
    string numberofwords = counterInstance.GetPrivateInput();
    string[] numberofsentences   = RepeatCounter.SplitTheText(counterInstance.GetPrivateText());
    int wordcounter = RepeatCounter.CountTheWords(numberofwords, numberofsentences);
    Console.WriteLine("Count is :"+ wordcounter);




  }
}
