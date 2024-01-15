using System;
using static System.Console;
namespace csharp_algo.baekjoon
{
    class boj_18429_근손실
    {
        static int N, K;
        static int[] A;
        static int[] num;
        static bool[] sel;
        static int result;

        static void Program()
        {
            string[] input = ReadLine().Split(' ');
            N = int.Parse(input[0]);
            K = int.Parse(input[1]);

            A = new int[N];
            input = ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                A[i] = int.Parse(input[i]);
            }

            result = 0;
            num = new int[N];
            sel = new bool[N];
            solution(0, 500);

            WriteLine(result);
        }

        static void solution(int cnt, int sum)
        {
            if (cnt == N)
            {
                result++;
                return;
            }

            for(int i = 0; i < N; i++)
            {
                if (sel[i]) continue;

                if (sum + A[i] - K < 500) continue;
                num[cnt] = A[i];
                sel[i] = true;
                solution(cnt + 1, sum + A[i] - K);
                sel[i] = false;
            }
        }

    }
}
