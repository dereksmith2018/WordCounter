using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models; 

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void IsValidInput_SentenceLongerThanWord_False() 
        {
            string word = "hello to you";
            string sentence = "hello";
            bool testBool = Counter.IsValidInput(word, sentence);
            Assert.AreEqual(testBool, false);
        }

        [TestMethod]
        public void ReturnCounter_NumberOfOccurencesOfWord_True()
        {
            string word = "derek";
            string sentence = "derek drerk derek";
            Counter testCounter = new Counter(word, sentence);
            int testInt = testCounter.ReturnCounter();
            Assert.AreEqual(testInt, 2);
        }
    }
}