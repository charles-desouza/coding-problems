using System;
using System.Linq;
using System.Numerics;

namespace Maximum_Sum
{
  class Program
  {
    static void Main(string[] args)
    {
      long N = Convert.ToInt32(Console.ReadLine());
      string line = Console.ReadLine();
      string[] tokens = line.Split(' ');
      long[] numbers = Array.ConvertAll(tokens, long.Parse);

      long sum = 0;
      long count = 0;
      long current_high = long.MinValue;
      for (long i = 0; i < numbers.Length; i++)
      {

        if (numbers[i] > 0)
        {
          count++;
          sum += numbers[i];
        }

        if (sum > current_high)
          current_high = sum;

      }

      if (count == 0)
      {
        count = 1;
        sum = current_high;
      }

      Console.Write(sum);
      Console.Write(' ');
      Console.Write(count);
    }
  }
}
