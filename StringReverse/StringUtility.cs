using System;
namespace StringReverse
{
  public static class StringUtility
  {
    public static string Reverse(this string input)
    {
      if(input.Equals(string.Empty))
        return input;

      int n = input.Length -1;
      char[] str = input.ToCharArray();

      for (int i = 0; i <= n / 2; i++)
      {
        char tmp = str[i];
        str[i] = str[n-i];
        str[n - i] = tmp;
      }

      return new string(str);
    }
  }
}
