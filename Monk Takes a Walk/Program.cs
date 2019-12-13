using System;

namespace Monk_Takes_a_Walk
{
  class Program
  {
    static void Main(string[] args)
    {
      string line = "";
      line = Console.ReadLine();
      int T = Convert.ToInt32(line);
      char[] v= { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

      
      while (T-->0)
      {
        int count = 0;
        line = Console.ReadLine();
        for (int i = 0; i < line.Length; i++)
        {
          for (int j = 0; j < v.Length; j++)
          {
            if (line[i].Equals(v[j]))
            {
              count++;
            }
          }
        }
        Console.WriteLine(count);
      }

      
    }
  }
}
