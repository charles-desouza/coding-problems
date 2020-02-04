using System;
using Xunit;

namespace MaxProfit.Tests
{
  public class MaxProfitTest
  {
    [Theory]
    [InlineData(new int[3]{2,2,2},new int[3]{ 1,1,1},6)]
    [InlineData( new int[3] { 1, 2, 1 }, new int[3] { 2, 3, 1 }, 6)]
    [InlineData(new int[3] { 1, 2, 1 }, new int[3] { 0, 4, 1 }, 5)]
    public void MaxProfit_ReturnMaximumProfit(int[] profitA, int[] profitB,int maxProfit)
    {
      int result = MaxProfit(profitA, profitB);

      Assert.Equal(maxProfit, result);
    }

    private static int MaxProfit(int[] profitA, int[] profitB)
    {
      int n = profitA.Length;

      int[] preSumA = new int[n];
      preSumA[0] = profitA[0];
      for (int i = 1; i < n; i++)
      {
        preSumA[i] = profitA[i] + preSumA[i - 1];
      }

      int[] postSumB = new int[n];
      postSumB[n - 1] = profitB[n - 1];

      for (int i = n - 2; i >= 0; i--)
      {
        postSumB[i] = postSumB[i + 1] + profitB[i];
      }

      int result = preSumA[n - 1];
      for (int i = 2; i < n - 1; i++)
      {
        result = Math.Max(result, preSumA[i] + postSumB[i + 2]);
      }

      result = Math.Max(result, postSumB[0]);
      return result;
    }
  }
}
