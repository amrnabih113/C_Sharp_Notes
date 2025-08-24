using System;

namespace Extensions_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world from extension methods";
            Console.WriteLine(s.ToTitleCase());
            Console.WriteLine(s.ToTitleCase().WordCount());

        }
    }


    public static class StringExtesions
    {
        public static string ToTitleCase(this String s)
        {

            foreach (var item in s.Split(' '))
            {
                if (item.Length > 0)
                {
                    s = s.Replace(item, char.ToUpper(item[0]) + item.Substring(1).ToLower());
                }
            }
            return s;
        }

        public static int WordCount(this String s)
        {
            return s.Split(' ').Length;
        }
    }
}
