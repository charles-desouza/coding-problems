using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fib Using Loops");
            FibUsingLoops(n);

            Console.WriteLine("Fib Using Loops");
            
            Console.WriteLine($"Fib Using Recurssion - {FibRecursive(n-2)}");
            Console.ReadLine();
        }

        public static void FibUsingLoops(int noOfElements)
        {

            int n1 = 0, n2 = 1;

            Console.Write($"{n1} {n2}");

            for (int i = 2; i < noOfElements; i++)
            {
                int tmp = n1 + n2;
                Console.Write($" {tmp}");

                n1 = n2;
                n2 = tmp;
            }
        }

        public static int FibRecursive(int n)
        {
            if(n <= 2)
            {
                return n;
            }
            else
            {
                return FibRecursive(n - 1) + FibRecursive(n - 2);
            }
        }
    }
}
