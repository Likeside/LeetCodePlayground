using System;

namespace LeetCodePlayground
{
    public class NeedleInHaystack
    {
        public int StrStr(string haystack, string needle)
        {

            if (needle == String.Empty) return 0;

            return haystack.IndexOf(needle);
        }
    }
    
}