using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.LeetCode
{
    public static class _767_ReorganizeString
    {
        public static string ReorganizeString1(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char ch in s)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }

            //code to find majority letter

            int max = 0; char letter = new char();
            foreach (char ch in dict.Keys)
            {
                if (dict[ch] > max)
                {
                    max = dict[ch];
                    letter = ch;
                }
            }

            //count of majority char > total/2 (Length +1 because in case of odd string)
            if (max > (s.Length + 1) / 2)
            {
                return "";
            }
            else
            {
                char[] res = new char[s.Length];

                //fill all even places with majority charactor
                int inx = 0;
                while (dict[letter]-- > 0)
                {
                    res[inx] = letter;
                    inx += 2;
                }

                //fill remining charactors
                foreach (char ch in dict.Keys)
                {
                    while (dict[ch]-- > 0)
                    {
                        if (inx >= res.Length)
                        {
                            inx = 1;
                        }
                        res[inx] = ch;
                        inx += 2;
                    }
                }


                return new string(res);
            }
        }


        public static string ReorganizeString(string s)
        {
            var count = new int[26];

            foreach (var ch in s)
            {
                count[ch - 'a']++;
            }

            //code to find majority letter
            int max = 0, letter = 0;
            for (int i = 0; i < 26; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    letter = i;
                }
            }

            //count of majority char > total/2 (Length +1 because in case of odd string)
            if (max > (s.Length + 1) / 2)
            {
                return "";
            }
            else
            {
                char[] res = new char[s.Length];

                //fill all even places with majority charactor
                int inx = 0;
                while (count[letter]-- > 0)
                {
                    res[inx] = (char)('a' + letter);
                    inx += 2;
                }

                //fill remining charactors
                for (int i = 0; i < count.Length; i++)
                {
                    if(count[i] > 0)
                    {
                        while (count[i]-- > 0)
                        {
                            if (inx >= res.Length)
                            {
                                inx = 1;
                            }
                            res[inx] = (char)('a' + i);
                            inx += 2;
                        }
                    }
                }
                return new string(res);
            }
        }
    }
}
