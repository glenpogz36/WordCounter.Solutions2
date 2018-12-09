using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void Constructor_CreatesInstanceOfRepeatCounter_RepeatCounter()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("basketball", "");
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      // Arrange
      string word = "basketball";
      RepeatCounter newRepeatCounter = new RepeatCounter(word, "");

      // Act
      string result = newRepeatCounter.GetWord();

      // Assert
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void SetWord_SetsWord_Void()
    {
      // Arrange
      string word = "basketball";
      RepeatCounter newRepeatCounter = new RepeatCounter(word, "");
      // Act
      string newWord = "basketball";
      newRepeatCounter.SetWord(newWord);
      string result = newRepeatCounter.GetWord();
      // Assert
      Assert.AreEqual(newWord, result);
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      // Arrange
      string sentence = "I like basketball";
      RepeatCounter newRepeatCounter = new RepeatCounter("", sentence);
      // Act
      string result = newRepeatCounter.GetSentence();
      // Assert
      Assert.AreEqual(sentence, result);
    }

    [TestMethod]
    public void SetSentence_SetsSentence_Void()
    {
      // Arrange
      string sentence = "I like basketball.";
      RepeatCounter newRepeatCounter = new RepeatCounter("", sentence);
      // Act
      string newSentence = "I like to eat.";
      newRepeatCounter.SetSentence(newSentence);
      string result = newRepeatCounter.GetSentence();
      // Assert
      Assert.AreEqual(newSentence, result);
    }

    [TestMethod]
    public void SplitSentence_ReturnsWords_StringArray()
    {
      // Arrange
      string sentence = "I like coding";
      RepeatCounter newRepeatCounter = new RepeatCounter("", sentence);
      // Act
      string[] newSentence = {"I", "like", "coding"};
    string [] result = newRepeatCounter.SplitText();
      // Assert
      CollectionAssert.AreEqual(newSentence, result);
    }

    [TestMethod]
    public void GetCount_ReturnsCount_Int()
    {
      // Arrange
      string word = "coding";
      string sentence = "I like coding";
      RepeatCounter newRepeatCounter = new RepeatCounter(word, sentence);

      // Act
      int result = newRepeatCounter.CountTheWords();

      // Assert
      Assert.AreEqual(1, result);
    }
  }
}
