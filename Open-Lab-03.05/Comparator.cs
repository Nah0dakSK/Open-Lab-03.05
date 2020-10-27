using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {                      
           var str1;
            var str2;
            var IsSame = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
            return IsSame;
        }
    }
}
