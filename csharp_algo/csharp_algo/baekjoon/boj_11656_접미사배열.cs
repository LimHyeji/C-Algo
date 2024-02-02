using System;
using static System.Console;
using System.Collections.Generic;

namespace TestProject
{
    internal class boj_11656_접미사배열
    {
        public static void Main(string[] args)
        {
            string input=ReadLine();

            SortedSet<string> set = new SortedSet<string>();
            for(int i=0;i<input.Length;i++)
            {
                set.Add(input.Substring(i));
            }

            foreach(string word in set)
            {
                WriteLine(word);
            }
        }
    }
}
