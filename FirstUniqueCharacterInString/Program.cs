using System;
using System.Collections.Generic;
using System.Collections;

namespace FirstUniqueCharacterInString
{
    class MainClass
    {
        // https://leetcode.com/problems/first-unique-character-in-a-string/
        //Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

        //Examples:

        //s = "leetcode"
        //return 0.

        //s = "loveleetcode",
        //return 2.
        //Note: You may assume the string contain only lowercase letters.
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            while (!s.Equals("end"))
            {
                Console.WriteLine(FirstUniqCharImproved2(s));
                s = Console.ReadLine();
            }
        }

        public static int FirstUniqCharImproved2(string s) //using HashTable O(n)
        {
            System.Collections.Hashtable ht = new Hashtable();

            for (int index = 0; index < s.Length; index++)
            {
                char c = s[index];

                if (ht.ContainsKey(c))
                    ht[c] = (int)ht[c] + 1;
                else
                    ht.Add(c, 1);
            }

            for (int index = 0; index < s.Length; index ++)
            {
                char c = s[index];
                if (ht.ContainsKey(c))
                    if ((int)ht[c] == 1)
                        return index;
            }
            return -1;

        }

        public static int FirstUniqCharImproved(string s) //using dictionary O(n)
        {
            Dictionary<char, int> scanned = new Dictionary<char, int>();

            for(int index = 0; index < s.Length; index++)
            {
                char c = s[index];

                if (scanned.ContainsKey(c))
                    scanned[c]++;
                else
                    scanned.Add(c, 1);
            }

            foreach(KeyValuePair<char,int> entry in scanned)
            {
                if (entry.Value == 1)
                    return s.IndexOf(entry.Key);
            }
            return -1;
        }

        public static int FirstUniqCharBrutalForce(string s) //O(n^2)
        {
            int indexPositionUniqueChar = -1;

            for(int i=0; i < s.Length; i++)
            {
              
                char c = s[i];
                int cCount = 0;

                for (int j = 0; j < s.Length; j++)
                {
                    if (c.Equals(s[j]))
                        cCount++;
                }

                if (cCount == 1) // found first unique character
                    return i;
            }
            return indexPositionUniqueChar;
        }
    }
}
