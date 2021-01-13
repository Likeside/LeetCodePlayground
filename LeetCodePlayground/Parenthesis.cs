using System;
using System.Collections.Generic;

namespace LeetCodePlayground
{
    public static class Parenthesis
    { 
      static List<string> wrongPatterns = new List<string>()
      {
         "(}",
         "(]",
         "[)",
         "[}",
         "{)",
         "{]"
      };  
      
      static Dictionary<string,string> correctPatterns = new Dictionary<string, string>()
      {
          {"(", ")"},
          {"[", "]"},
          {"{","}"}
      };
      
      public static string ReplaceFirstOccurrence (string Source, string Find, string Replace)
      {
          int Place = Source.IndexOf(Find);
          string result = Source.Remove(Place, Find.Length).Insert(Place, Replace);
          return result;
      }
     public static bool isValid(string s)
      {
          bool isCorrect = true;
          isCorrect = IsEmpty(s);
          foreach (string pattern in wrongPatterns)
          {
              if (s.Contains(pattern))
              {
                  isCorrect = false;
              }
          }

          if (s.Length <= 1)
          {
              isCorrect = false;
          }


          foreach (string key in correctPatterns.Keys)
          {
              if ((s.Contains(key) && !s.Contains(correctPatterns[key])) || (s.Contains(correctPatterns[key]) && !s.Contains(key)))
              {
                  isCorrect = false;
              }
          }

          bool IsEmpty(string str)
          {
              bool result = true;
              for (int i = 0; i <= str.Length; i++)
              {
                  foreach (string key in correctPatterns.Keys)
                  {
                      if (str.Contains(key) && str.Contains(correctPatterns[key]) &&
                          (str.IndexOf(correctPatterns[key]) > str.IndexOf(key)))
                      {
                          str = ReplaceFirstOccurrence(str, key, "");
                          str = ReplaceFirstOccurrence(str, correctPatterns[key], "");
                      }
                  }
              }

              if (str != String.Empty)
              {
                  result = false;
              }

              return result;
          }

          
          return isCorrect;
      }
    }
}