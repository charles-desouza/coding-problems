using System;
using Xunit;

namespace Kangaroo_Jumps
{
  public class KangarooJumpTest
  {
    [Theory]
    [InlineData(0, 3, 4, 2, "YES")]
    [InlineData(0, 2, 5, 3, "NO")]
    [InlineData(43, 2, 70, 2, "NO")]
    public void Jumps_Are_In_Sync(int x1,int v1,int x2,int v2,string result)
    {
      Assert.Equal(kangaroo(x1,v1,x2,v2),result);
    }

    private string kangaroo(int x1, int v1, int x2, int v2)
    {
      decimal x = x2-x1;
      decimal v = v1-v2;

      decimal r = v==0?-1:x/v;
      if (r >= 0 && r%1 == 0)
        return "YES";
      else
        return "NO";
    }
  }
}
