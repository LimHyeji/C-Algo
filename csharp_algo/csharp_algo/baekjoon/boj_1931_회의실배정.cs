using System;
using static System.Console;

namespace csharp_algo.baekjoon
{
    internal class boj_1931_회의실배정
    {
        static int N;

        class Room
        {
            public int start;
            public int end;

            public Room(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        }
        static Room[] rooms;
        static int result;

        static public void Program(string[] args)
        {
            N = int.Parse(ReadLine());
            rooms = new Room[N];

            for(int i=0; i<N; i++)
            {
                string[] input = ReadLine().Split(' ');
                int start = int.Parse(input[0]);
                int end = int.Parse(input[1]);
                rooms[i]= new Room(start, end);
            }

            result = 1;

            Array.Sort(rooms, delegate(Room o1, Room o2) { 
                if(o1.end==o2.end) return o1.start.CompareTo(o2.start);
                return o1.end.CompareTo(o2.end); 
            });

            int idx = 0;
            while (idx < N)
            {
                Room cur = rooms[idx];
                // WriteLine(cur.start);

                bool flag = false;
                for(int i=idx+1; i<N; i++)
                {
                    if (cur.end <= rooms[i].start)
                    {
                        // WriteLine(cur+ " :: " + rooms[i].start);
                        idx=i;
                        flag = true;
                        break;
                    }
                }

                if (flag) result++;
                else break;
            }

            WriteLine(result);

        }

    }
}
