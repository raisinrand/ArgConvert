﻿using System;

namespace ArgConvert
{
    static class StringUtils
    {
        public static string[] SplitLines(this string s)
        {
            return s.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        }
        public static int LastIndexOfAny(this string s, string[] options, int startIndex)
        {
            int res = -1;
            for (int i = 0; i < options.Length; i++)
            {
                int index = s.LastIndexOf(options[i], startIndex);
                if (index > res)
                {
                    res = index;
                }
            }
            return res;
        }
        public static string SubstringFrom(this string s, int start, int end)
        {
            return s.Substring(start, end - start);
        }
    }
}
