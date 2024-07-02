using System;
using System.Collections;
using System.Collections.Generic;

namespace LessonSix
{
  class Program
  {
    static void LessonSix(string[] args)
    {
      // Generic collections are type safe
      // and provide performance benefits

      // You define the data type when defining
      // the generic. This is a dynamically
      // resizing collection 
      
      List<Animal> animalList = new List<Animal>();

      List<int> numList = new List<int>();
      numList.Add(24);

      animalList.Add(new Animal() { Name = "Doug" });
      animalList.Add(new Animal() { Name = "Paul" });
      animalList.Add(new Animal() { Name = "Sally" });
      animalList.Add(new Animal() { Name = "Robert" });

      animalList.Insert(1, new Animal() { Name = "Steve" });
      animalList.RemoveAt(4);

      Console.WriteLine("# of Animals : {0}", animalList.Count());

      foreach (Animal a in animalList)
      {
        Console.WriteLine(a.Name);
      }

      int x = 5, y = 4;
      Animal.GetSum<int>(ref x, ref y);

      string strX = "5", strY = "4";
      Animal.GetSum<string>(ref strX, ref strY);


      // Use the generic struct
      Rectangle<int> rec1 = new Rectangle<int>(20, 50);
      Console.WriteLine(rec1.GetArea());

      Rectangle<string> rec2 = new Rectangle<string>("20", "50");
      Console.WriteLine(rec2.GetArea());


      // Create delegate objects
      Arithmetic add, sub, addSub;
      add = new Arithmetic(Add);
      sub = new Arithmetic(Subtract);
      addSub = add + sub;

      Console.WriteLine($"Add {6} & {10}");
      add(6, 10);

      Console.WriteLine($"Add & Subtract {10} & {4}");
      addSub(10, 4);

    }

    // Can create generic structs
    // and classes in this same way
    public struct Rectangle<T>
    {
      // Generic fields
      private T width;
      private T length;

      // Generic properties
      public T Width
      {
        get { return width; }
        set { width = value; }
      }

      public T Length
      {
        get { return length; }
        set { length = value; }
      }

      // Generic constructor
      public Rectangle(T w, T l)
      {
        width = w;
        length = l;
      }

      public string GetArea()
      {
        double dblWidth = Convert.ToDouble(Width);
        double dblLength = Convert.ToDouble(Length);
        return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
      }
    }

    // Declare a delegate type that performs
    // arithmetic. It defines the return type
    // and the types for attributes
    public delegate void Arithmetic(double num1, double num2);

    // Methods that will be assigned to the delegate

    public static void Add(double num1, double num2)
    {
      Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }

    public static void Subtract(double num1, double num2)
    {
      Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    }

  }
}