using System;
using System.Collections.Generic;
using System.Text;

namespace day2
{
    class Utility
    {
        public static string LastWord(int position, string stringVariable, char charToParse)
        {
            string[] words = stringVariable.Split(charToParse);
            string result = words[position];
            if (result != null && position < stringVariable.Length)
                return result;
            else
                return "There is no word in that position";

        }
        public List<string> GetPalindromes(string[] str)
        {
            List<string> strr = new List<string>();

            foreach (string s in str)
            {
                char[] ch = s.ToCharArray();
                Array.Reverse(ch);
                string revd = new string(ch);
                if (s.Equals(revd))
                {
                    strr.Add(s);
                }
            }

            return strr;
        }
    }
}
