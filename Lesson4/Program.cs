using System;

namespace LessonFour
{
  class Program
  {
    static void LessonFour(string[] args)
    {
      Vehicle audi = new Vehicle("Audi", 4, 160);

      // Check if Vehicle implements 
      // IDrivable
      if (audi is IDrivable)
      {
        audi.Move();
        audi.Stop();
      }
      else
      {
        Console.WriteLine("This car is faulty and can not be driven", audi.Brand);
      }

      IElectronicDevice TV = RemoteControl.GetDevice();
      PowerButton powBtn = new PowerButton(TV);

      powBtn.Execute();
      powBtn.Undo();
      powBtn.Execute();
      powBtn.Undo();
    }
  }
}