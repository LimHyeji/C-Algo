using System;
using static System.Console;
using System.Text;

namespace csharp_algo.baekjoon
{
    class boj_16496_큰수만들기
    {
        static int N;
        static string[] arr;
        static StringBuilder result;

        static void Program()
        {
            N = int.Parse(ReadLine());
            arr = ReadLine().Split(' ');

            Array.Sort(arr, (o1, o2) => (o2 + o1).CompareTo(o1 + o2));

            result = new StringBuilder();
            for(int i = 0; i < N; i++)
            {
                result.Append(arr[i]);
            }
            if (result.ToString()[0]=='0') WriteLine(0);
            else WriteLine(result);
        }
    }
}
