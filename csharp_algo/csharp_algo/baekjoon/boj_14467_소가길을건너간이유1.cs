using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_algo.baekjoon
{
    class boj_14467_소가길을건너간이유1
    {
        static int N;
        static int[] arr;
        static int result;

        static void Program(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            arr = new int[11];
            for (int i = 0; i < 11; i++) arr[i] = -1;

            result = 0;
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int num = int.Parse(input[0]);
                int move = int.Parse(input[1]);

                if (arr[num] == -1) arr[num] = move;
                else if (arr[num] != move)
                {
                    result++;
                    arr[num] = move;
                }
            }

            Console.WriteLine(result);
        }
    }
}

