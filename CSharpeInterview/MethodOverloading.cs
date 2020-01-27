using System;

namespace CSharpeInterview
{
  public class MethodOverloading
  {
    public static void Run(ref string name)
    {
      Console.WriteLine($"{name} Run....");
    }

    //public static void Run(out string name)
    //{
    //  name = "Hi";
    //  Console.WriteLine(" Run....");
    //}
  }
}

