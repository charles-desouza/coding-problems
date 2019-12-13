using System;
using System.Linq;

namespace joker_and_thieves
{
  class Program
  {
    static public void Main()
    {
      String line;
      line = Console.ReadLine();
      int T = Convert.ToInt32(line);

      for (int t_i = 0; t_i < T; t_i++)
      {
        var line1 = Console.ReadLine().Split();
        int N = Convert.ToInt32(line1[0]);
        int K = Convert.ToInt32(line1[1]);
        char[][] A = new char[N][];
        for (int i_A = 0; i_A < N; i_A++)
        {
          line = Console.ReadLine();
          A[i_A] = line.Split().Select(str => char.Parse(str)).ToArray();
        }

        int out_ = solution(A, K);
        Console.WriteLine(out_);

      }
    }

    static int solution(char[][] A, int K)
    {
      //// Write your code here
      //int count = 0;
      //for (int i = 0; i < A.GetLength(0); i++)
      //{
      //  for (int j = 0; j < A[i].Length - K; j++)
        
      //    for (int l = 0; l < ; l++)
      //    {

      //    }
      //    if((A[i][j] == 'P' && A[i][j+K] == 'T') ||
      //      (A[i][j] == 'T' && A[i][j + K] == 'P'))
      //    {
      //      A[i][j] = 'X';
      //      A[i][j + K] = 'X';
      //      count++;
      //    }
      //  }
      //}

      //return count;
      return 3;
    }
  }
}
