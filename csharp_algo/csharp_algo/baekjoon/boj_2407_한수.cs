using System;
using System.Numerics;

namespace csharp_algo.baekjoon
{
    class boj_2407_한수
    {
        static int n, m;

        static void Program(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            n = int.Parse(input[0]);
            m = int.Parse(input[1]);

            BigInteger result = solution(n, m);

            Console.WriteLine(result);
        }

        static BigInteger solution(int n, int m)
        {
            BigInteger a = 1, b = 1;

            for (int i = n - m + 1; i <= n; i++) a *= i;
            for (int i = 1; i <= m; i++) b *= i;

            return a / b;
        }
    }
}
