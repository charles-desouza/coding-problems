using System;

namespace scribble
{
  class Program
  {
    static void Main(string[] args)
    {
      //Shape s = new Circle();
      //Circle c = s.makeCopy();
      //Console.WriteLine(f2());
    }

    //static int f2()
    //{
    //  String s = "Hello\0world";
    //  return s.Length;
    //}
    //static void f1(out S s1, ref S s2)
    //{
    //  s1.i = 42;
    //  s2.i = 42;
    //}
    //static String f2()
    //{
    //  S s1, s2;
    //  f1(out s1, ref s2);
    //  return s1.i.ToString() + s2.i.ToString();
    //}
    class Shape
    {
      public virtual Shape makeCopy()
      {
        return new Shape();
      }
    }

    class Circle : Shape
    {
      public override Shape makeCopy()
      {
        return new Circle();
      }
    }

    //public class Unbox
    //{
    //  public static void Main(String[] args)
    //  {
    //    Shape s = new Circle();
    //    Circle c = s.makeCopy();
    //  }
    //}
    struct S{
public int i;
    }
  }
}
