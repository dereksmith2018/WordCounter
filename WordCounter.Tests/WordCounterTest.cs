using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void GetUserWord_CheckForString_True()
        {
            string sentenceInput = "like";
            RepeatCounter newCounter = new RepeatCounter();
            newCounter.SetUserWord(newCounter);
            string checkWord = newCounter.GetUserWord();
            Assert.AreEqual(newCounter, checkWord);
         }
        [TestMethod]
        public void GetUserSentence_CheckForString_True()
        {
        string newSentence = "I really dont like testing";
        RepeatCounter newCounter = new RepeatCounter();
        newCounter.SetUserSentence(newCounter);
        string checkSentence = newCounter.GetUserSentence();
        Assert.AreEqual(newCounter, checkSentence);
        }
        [TestMethod]
        public void MakeSentenceArray_SplitArrayForCompare_AreEqual()
        {
          string testSentence = "I really dont like testing";
          string[] testArray = {"I", "really", "dont", "like", "testing"};
          RepeatCounter newCounter = new RepeatCounter();
          newCounter.SetUserSentence(testSentence);
          string[] newArray = newCounter.MakeSentenceArray();
          CollectionAssert.AreEqual(testArray, newArray);
        }
        [TestMethod]
        public void CountWord_CheckHowManyWordsMatch_True()
        {
          string[] testOne = {"hello"};
          string[] testTwo = {"why", "do", "kitten", "hello", "skip"};
          RepeatCounter newCounter = new RepeatCounter();
          newCounter.CountWord(testTwo, testOne);
          int output = newCounter.CountWord();
          Assert.AreEqual(output, 1);
        }
  }
}
