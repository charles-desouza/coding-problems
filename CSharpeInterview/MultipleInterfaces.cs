using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpeInterview
{
  public class Car : IEngine, IAC
  {
    void IEngine.Run()
    {
      Console.WriteLine("Running Engine");
    }

    void IAC.Run()
    {
      Console.WriteLine("Running AC");
    }

    public void Run()
    {
      Console.WriteLine("running");
    }
  }

  interface IEngine{
    void Run();
  }

  public interface IAC
  {
    void Run();
  }
}
