using System;

namespace MentorMateLogo
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            char[,] m = new char[N + 1, 10 * N];

            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    m[row, col] = '-';
                }
            }

            fillMatrix(m, N);
            printMatrix(m);
        }


        public static void printMatrix(char[,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    Console.Write(m[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void draw(char[,] m, int row, int col, int N)
        {
            for (int i = 0; i < N; i++)
            {
                m[row, col + i] = '*';
            }
        }

        public static void fillMatrix(char[,] m, int N)
        {
            int[] tops = { N, 3 * N, 6 * N, 8 * N };
            foreach (int col in tops)
            {
                for (int row = 0; row < N + 1; row++)
                {
                    draw(m, row, col - row, N);
                    draw(m, row, col + row, N);

                }
            }
        }




    }
}

