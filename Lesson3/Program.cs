using System;

namespace LessonThree
{
  class Program
  {
    static void LessonThree(string[] args)
    {
      // We can store our shapes in
      // a Shape array as long as it 
      // contains subclasses of Shape

      Shape[] shapes = { new Circle(5), new Rectagle(4, 5) };
      foreach (Shape figure in shapes)
      {
        figure.GetInfo();
        Console.WriteLine("{0} Are : {1:f2}", figure.Name, figure.Area());

        // You can use as to check if an
        // object is of a specific type
        Circle? testCircle = figure as Circle;
        if (testCircle == null)
        {
          Console.WriteLine("This is not a Circle");
        }

        if (figure is Circle)
        {
          Console.WriteLine("This is not a Rectangle");

        }
      }

      // You can store any class as a base
      // class and call the subclass methods
      // even if they don't exist in the base
      // class by casting
      object circleOne = new Circle(4);
      Circle circleTwo = (Circle)circleOne;
      Console.WriteLine("The {0} Area is {1:f2}", circleTwo.Name, circleTwo.Area());
    }
  }
}