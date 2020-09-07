using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            if (word1.Length != word1.Length)
                return false;
             var s1Array = word1.ToLower().ToCharArray();
             var s2Array = word2.ToLower().ToCharArray();

              Array.Sort(s1Array);
              Array.Sort(s2Array);

             word1 = new string(s1Array);
             word2 = new string(s2Array);

             return word1 == word2;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            //Insert the correct implementation here
            for(int i=0;i <candidates.Count;i++)
            { 
                 if (!WordPairIsAnagram(word, candidates[i])) {
                    candidates.RemoveAt(i);
                    i--;
            }
            }
            return candidates;
        }
    }
}
