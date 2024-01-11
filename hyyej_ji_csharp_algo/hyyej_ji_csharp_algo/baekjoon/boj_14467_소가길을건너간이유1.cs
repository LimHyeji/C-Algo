using System;

namespace hyyej_ji_csharp_algo.baekjoon
{
	class boj_14467_소가길을건너간이유1
    {
        static int N;
        static int[] arr;
        static int result;

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            arr = new int[11];
            for (int i = 0; i < 11; i++) arr[i] = -1;

            result = 0;        
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int num = int.Parse(input[0]);
                int move = int.Parse(input[1]);

                if (arr[num] == -1) arr[num] = move;
                else if (arr[num] != move) result++;
            }

            Console.WriteLine(result);
        }
    }
}