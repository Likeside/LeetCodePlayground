using System;
using System.Collections.Generic;

namespace LeetCodePlayground
{
    public static class RomanToInt
    {
        public static string ReplaceFirstOccurrence (string Source, string Find, string Replace)
        {
            int Place = Source.IndexOf(Find);
            string result = Source.Remove(Place, Find.Length).Insert(Place, Replace);
            return result;
        }
        public static int RomanToInt1(string s)
        {
            Dictionary<string, int> romanNumbersDouble = new Dictionary<string, int>()
            {
                {"IV", 4},
                {"IX", 9},
                {"XL", 40},
                {"XC", 90},
                {"CD", 400},
                {"CM", 900},
            };
            Dictionary<string, int> romanNumbersSingle = new Dictionary<string, int>()
            {
                {"I", 1},
                {"V", 5},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000}
            };
            
            int result = 0;
            for (int i = 0; i <= s.Length; i++)
            {
                foreach (string key in romanNumbersDouble.Keys)
                {
                    if (s.Contains(key))
                    {
                        result += romanNumbersDouble[key];
                        s = ReplaceFirstOccurrence(s, key, "  ");
                    }
                }
            }

            for (int i = 0; i <= s.Length; i++)
            {
                foreach (string key in romanNumbersSingle.Keys)
                {
                    if (s.Contains(key))
                    {
                        result += romanNumbersSingle[key];
                        s = ReplaceFirstOccurrence(s, key, " ");
                    }
                }
            }

            return result;
        }
    }
}