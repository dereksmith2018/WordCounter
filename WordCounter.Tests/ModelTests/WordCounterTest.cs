using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
     [TestMethod]
    public void SetString_ReturnsString_True()
    {
      //Arrange
      string inputString = "derek everyone";
      RepeatCounter newCounter = new RepeatCounter();

      //Act
      newCounter.SetUserSentence(inputString);
      string resultString = newCounter.GetUserSentence();

      //Assert
      Assert.AreEqual(inputString, resultString);
    }
    [TestMethod]
    public void HowManyMatches_DoesWordMatchString_True()
    {
      //Arrange
      string inputString = "I really dont like the documentaion on the last class";
      string inputWord = "last";
      RepeatCounter newCounter = new RepeatCounter();

      //Act
      newCounter.SetUserSentence(inputString);
      newCounter.SetUserWord(inputWord);
      int wordMatches = newCounter.CountedWord();

      //Assert
      Assert.AreEqual(1, wordMatches);
    }
    
  }
}