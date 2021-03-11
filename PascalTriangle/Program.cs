using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height of the triangle");
            int n = int.Parse(Console.ReadLine());

            int[][] m = new int[n][];
            for (int i = 0; i < n; i++)
            {
                m[i] = new int[n];
            }


            for (int i = 0; i < n; i++)
            {
                m[i][0] = m[0][i] = 1;
            }




            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    m[i][j] = m[i - 1][j] + m[i][j - 1];
                }
            }



            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{m[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
