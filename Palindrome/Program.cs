using System;
using static System.Console;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome(123);
            IsPalindrome(121);
            IsPalindrome(123123123);
            IsPalindrome(12222221);
            ReadLine();
        }

        private static void IsPalindrome(int num)
        {
            int orginal = num;
            int result = 0;

            while (num%10 > 0)
            {
                result = result*10 + num % 10;
                num = num / 10;
            }

            if(result == orginal)
            {
                WriteLine($"{orginal} is palindrome");
            }
            else{
                WriteLine($"{orginal} is not a palindrome");
            }
            
        }
    }
}
