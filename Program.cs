using System;
using System.Collections.Generic;


namespace dictionary_list
{
  class Program
  {
    static void Main(string[] args)
    {
      var dictionaryOfWords = new List<Dictionary<string, string>>();

      //  Each word needs:
      //    word
      //    definition
      //    part of speech
      //    example sentence

      var excitedWord = new Dictionary<string, string>();

      excitedWord.Add("word", "excited");
      excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
      excitedWord.Add("part of speech", "adjective");
      excitedWord.Add("example sentence", "I am excited to learn C#!");


      dictionaryOfWords.Add(excitedWord);




      var pensiveWord = new Dictionary<string, string>();

      pensiveWord.Add("word", "pensive");
      pensiveWord.Add("definition", "Showing or expressing deep thought");
      pensiveWord.Add("part of speech", "adjective");
      pensiveWord.Add("example sentence", "She stared out at the night, silent, her expression pensive.");

      dictionaryOfWords.Add(pensiveWord);


      foreach (var word in dictionaryOfWords)
      {
        foreach (KeyValuePair<string, string> data in word)
        {
          Console.WriteLine($"{data.Key}: {data.Value}");
        }
      }
    }
  }
}
