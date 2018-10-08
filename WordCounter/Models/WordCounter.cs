using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
     public class RepeatCounter
    {
    private string _userSentence;
    private string _userWord;
    private int _count = 0;
    // private static List<RepeatCounter> _allCounters = new List<RepeatCounter> {};

    // public RepeatCounter(string userWord, string userSentence)
    // {
    //   _userSentence = userSentence;
    //   _userWord = userWord;
    // }

    public void SetUserSentence(string userSentence)
    {
      _userSentence = userSentence;
    }
    public string GetUserSentence()
    {
      return _userSentence;
    }
    public void SetUserWord(string userWord)
    {
      _userWord = userWord;
    }
    public string GetUserWord()
    {
      return _userWord;
    }
    public string[] MakeSentenceArray()
    {
       var sentence = _userSentence.Split(' ');
       return sentence;
    }
    // public static List<RepeatCounter> GetAll()
    // {
    //   return _allCounters;
    // }
    // public void Save()
    // {
    //   _allCounters.Add(this);
    // }
    public int CountedWord()
    {
      _count = 0;
      string[] newSentence = MakeSentenceArray();
      for (int i = 0; i < newSentence.Length; i++)
      {
        _count +=(_userWord == newSentence[i]) ? 1 : 0;
      }
      return _count;
    }
   }
}  
    //   _count = 0;
    // string[] sentence = this.MakeSentenceArray();
    // foreach(string word in sentence)
    //   count = (word.Equals(_userWord)) ? 1 : 0;
    //       {
    //         return count;
    //       }
    //
    // }
 
/* string[] sentence = usersentence.Split(" ");
 * int count = 0;

        for (int i = 0; i < sentence.Length; i++)
        {
         string word = sentence[i];
         if (word.Equals(userWord))
        {
              count++;
        }
              Console.WriteLine(count);
        }
         */
