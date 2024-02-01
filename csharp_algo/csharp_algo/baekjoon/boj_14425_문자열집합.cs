using System;
using static System.Console;
using System.Collections.Generic;

namespace csharp_algo.baekjoon
{
    class boj_14425_문자열집합
    {
        public static void Main()
        {
            string[] input = ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            HashSet<string> set = new HashSet<string>();
            for(int i = 0; i < N; i++)
            {
                string word = ReadLine();
                set.Add(word);
            }

            int result = 0;
            for(int i = 0; i < M; i++)
            {
                string word = ReadLine();
                if (set.Contains(word)) result++;
            }

            WriteLine(result);
        }
    }
}
