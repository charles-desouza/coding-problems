using System;
using static System.Console;

namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[] { 1, 2, 5 };
            int amount = 9;

            CoinChangePossiblities(coins, amount);

            CoinChangePossiblities(new int[]{ 1,2,3}, 4);
            ReadLine();
        }

        private static void CoinChangePossiblities(int[] coins, int amount)
        {
            int[,] result = new int[coins.Length, amount + 1];

            for (int i = 0; i < coins.Length; i++)
            {
                result[i, 0] = 1;
            }
            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = 1; j <= amount; j++)
                {
                    result[i, j] = i == 0 ? 0 : result[i-1, j];

                    if (j >= coins[i])
                    {
                        result[i, j] += result[i,j - coins[i]];
                    }
                }
            }

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = 0; j <= amount; j++)
                {
                    Write(" " + result[i, j]);
                }
                WriteLine("");
            }
        }
    }
}
