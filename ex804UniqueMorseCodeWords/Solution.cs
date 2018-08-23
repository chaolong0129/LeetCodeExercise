using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex804UniqueMorseCodeWords
{
    public class Solution
    {

        string[] MCode = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        public int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> ret = new HashSet<string>();
            for (int i = 0; i < words.Length; i++)
            {
                var w = words[i].ToLower();
                var nw = "";
                foreach (var c in w)
                    nw = nw + MCode[(c - 97)];
                ret.Add(nw);
            }

            return ret.Count;
        }
        public int UniqueMorseRepresentations2(string[] words)
        {
            List<char> listAToZ = Enumerable.Range('a', 26)
                                        .Select(x => (char)x)
                                        .ToList();

            var morseCodeAns = words.Select(x =>
            {
                var temp = x.Select(y => MCode[listAToZ.IndexOf(y)]);
                return string.Join(string.Empty, temp);
            });

            return morseCodeAns.Distinct().Count();
        }
    }
}
