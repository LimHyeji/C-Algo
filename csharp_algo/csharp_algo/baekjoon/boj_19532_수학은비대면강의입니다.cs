using System;
using static System.Console;

namespace csharp_algo.baekjoon
{
    class boj_19532_수학은비대면강의입니다
    {
        
        public static void Main()
        {
            string[] input = ReadLine().Split(' ');

            int[] arr = new int[6];
            for(int i = 0; i < 6; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            for(int i = -999; i <= 999; i++)
            {
                for(int j = -999; j <= 999; j++)
                {
                    if (arr[0] * i + arr[1] * j == arr[2] && arr[3] * i + arr[4] * j == arr[5])
                    {
                        WriteLine(i + " " + j);
                        return;
                    }
                }
            }
        }
    }
}
