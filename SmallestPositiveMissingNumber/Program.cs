using System;
using System.Collections.Generic;

namespace SmallestPositiveMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            //FindSmallest(new int[] { 2, 3, 4, 5, 7, -1 });
            
            var i = solution(new int[] { 1, 3, 6, 4, 1, 2 });


            Console.ReadKey();

        }

        public  static int solution(int[] A)
        {
            int min = 1;
            HashSet<int> numbers = new HashSet<int>();
            foreach (int n in A)
            {
                if (!numbers.Contains(n))
                {
                    numbers.Add(n);
                    if (n == min)
                        while (numbers.Contains(++min)) ;
                }
            }
            return min;
        }

        public static void FindSmallest(int[] A)
        {
            int val = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 0)
                {
                    continue;
                }
            }
        }
    }
}
