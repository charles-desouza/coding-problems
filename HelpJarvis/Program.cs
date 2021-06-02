using System;

namespace HelpJarvis
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());
            int[] n = new int[t];

            int a = 0;

            while (a < t)
            {
                n[a] = int.Parse(Console.ReadLine());
                a++;
            }

            for (int i = 0; i < t; i++)
            {
                int[] digits = new int[1 + (int)Math.Log10(n[i])];
                for (int j = digits.Length - 1; j >= 0; j--)
                {
                    int digit;
                    n[i] = Math.DivRem(n[i], 10, out digit);
                    digits[j] = digit;
                }

                Array.Sort(digits);

                bool flag = true;
                for (int k = 1; k < digits.Length; k++)
                {
                    if((digits[k-1] - digits[k]) < 1)
                    {
                        flag = false;
                        break;    
                    }
                }

                Console.WriteLine(flag?"YES":"NO");
            }

            Console.ReadLine();
        }

    }
}
