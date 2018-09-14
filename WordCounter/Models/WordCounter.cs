using System.Collections.Generic;
using System;

namespace WordCounter
{
     public class RepeatCounter
    {
    private string _userSentence;
    private string _userWord;


    public void SetUserSentence(string newUserSentence)
    {
      _userSentence = newUserSentence;
    }
    public string GetUserSentence()
    {
      return _userSentence;
    }
    public void SetUserWord(string newUserWord)
    {
      _userWord = newUserWord;
    }
    public string GetUserWord()
    {
      return _userWord;
    }
    public string[] MakeSentenceArray()
    {
       string[] sentence = _userSentence.Split(' ');
       return sentence;
    }

    public int CountWord()
    {

    string[] sentence = this.MakeSentenceArray();
    int count = 0;
    foreach(string word in sentence)
      count = (word.Equals(_userWord)) ? 1 : 0;
          {
            return count;
          }

    }
  }
}
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
