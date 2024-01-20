using System;
using static System.Console;

namespace csharp_algo.baekjoon
{
    class boj_5766_할아버지는유명해
    {
        static int N;
        static int[] height, weight;
        static int result;

       static public void Program()
        {
            N = int.Parse(ReadLine());
            height = new int[N];
            weight = new int[N];

            for(int i = 0; i < N; i++)
            {
                string[] input = ReadLine().Split(' ');
                height[i] = int.Parse(input[0]);
                weight[i] = int.Parse(input[1]);
            }

            for(int i = 0; i < N; i++)
            {
                result = 0;
                for(int j = 0; j < N; j++)
                {
                    if (height[i] < height[j] && weight[i] < weight[j]) result++;
                }
                Write(result + 1);
                Write(" ");
            }
        }
    }
}
