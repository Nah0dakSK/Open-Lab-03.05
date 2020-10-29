using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {                      
           str1 = null;
            str2 = null;
            int output = 0;
            output = string.Compare(str1, str2);
            Console.WriteLine(output.ToString());
            Console.ReadLine();
        }
    }
}
