using System;

namespace CSharpeInterview
{
  class Program
  {
    static void Main(string[] args)
    {
            //MultipleInterfaces
            //var car = new Car();
            //car.Run();

            ////MultipleInterfaces
            //Console.WriteLine("Hello World!");

            A a = new B();
            a.DoWork();
    }

  }

    public class A
    {
        public virtual void DoWork()
        {
            Console.WriteLine("A DoWork()");
        }
    }

    public class B : A
    {
        public override void DoWork()
        {
            Console.WriteLine("B DoWork()");
        }
    }
}
