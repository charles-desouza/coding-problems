using System;

namespace CSharpeInterview
{
  class Program
  {
    static void Main(string[] args)
    {
      //MultipleInterfaces
      IEngine car = new Car();
      car.Run();

      //MultipleInterfaces
      Console.WriteLine("Hello World!");
    }
  }
}
