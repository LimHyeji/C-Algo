using System;
using static System.Console;
using System.Collections.Generic;

namespace csharp_algo.baekjoon
{
    /*
     * 공격 -> 수비
     * 도미노(1~5)
     * 
     * 동서남북 중 하나로 넘어뜨림
     * 길이-1 만큼의 도미노가 넘어짐 -> 연달아 넘어짐
     * 
     * 원하는 것 하나 다시 세우기 (단, 넘어진 것)
     * 
     * 매 라운드마다 넘어뜨린 도미노 개수 세어 합함
     * 
     */
    class boj_20165_인내의도미노장인호석
    {
        static int N, M, R;
        static int[,] map;
        static int[] dirR = { -1, 1, 0, 0 }; // 상하좌우 == 북남서동
        static int[] dirC = { 0, 0, -1, 1 };
        static bool[,] fall;
        static int result;

        static void Main()
        {
            string[] input = ReadLine().Split(' ');
            N = Convert.ToInt32(input[0]);
            M = Convert.ToInt32(input[1]);
            R = Convert.ToInt32(input[2]);

            map = new int[N, M];
            fall = new bool[N, M];

            for(int i = 0; i < N; i++)
            {
                input = ReadLine().Split(' ');
                for(int j = 0; j < M; j++)
                {
                    map[i,j] = Convert.ToInt32(input[j]);
                }
            }

            result = 0;
            for(int i = 0; i < R; i++)
            {
                input = ReadLine().Split(' ');
                int X = Convert.ToInt32(input[0]) - 1;
                int Y = Convert.ToInt32(input[1]) - 1;
                char D = input[2][0]; // E W S N 동서남북
                int score = attack(X, Y, getDirection(D));

                input = ReadLine().Split(' ');
                X = Convert.ToInt32(input[0]) - 1;
                Y = Convert.ToInt32(input[1]) - 1;
                defend(X, Y);

                result += score;
            }

            WriteLine(result);
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    Write((fall[i, j] == true ? "F" : "S") + " ");
                }
                WriteLine();
            }
        }

       public class Node
        {
            public int row, col;
            public Node(int row,int col)
            {
                this.row = row;
                this.col = col;
            }
        }
        
        static int attack(int row, int col, int dir)
        {
            if (fall[row, col]) return 0;

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(new Node(row, col));
            fall[row, col] = true;

            int cnt = 1;

            while (q.Count > 0)
            {
                Node cur = q.Dequeue();
                int len = map[cur.row, cur.col];

                for (int i = 1; i < len; i++)
                {
                    int newR = cur.row + i * dirR[dir];
                    int newC = cur.col + i * dirC[dir];

                    if (newR < 0 || newR >= N || newC < 0 || newC >= M || fall[newR, newC]) continue;
                    q.Enqueue(new Node(newR, newC));
                    fall[newR,newC] = true;
                    cnt++;
                }
            }

            return cnt;
        }

        static void defend(int row,int col)
        {
            fall[row,col] = false;
        }

        static int getDirection(char c)
        {
            switch (c)
            {
                case 'E':
                    return 3;
                case 'W':
                    return 2;
                case 'S':
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
