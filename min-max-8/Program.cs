using System;
using System.Linq;

namespace min_max_8
{
  class Program
  {
    static void Main(string[] args)
    {
      int N = Convert.ToInt32(Console.ReadLine());
      string line = Console.ReadLine();
      string[] tokens = line.Split(' ');
      int[] numbers = Array.ConvertAll(tokens, int.Parse);

      numbers = numbers.OrderBy(x=>x).ToArray<int>();
      int sum = 0;
      for (int i = 0; i < numbers.Length-1; i++)
      {
        sum += numbers[i];
      }
        
      Console.Write(sum- numbers[numbers.Length - 1]);
      Console.Write(' ');
      Console.Write(sum - numbers[0]);
    }
  }
}
