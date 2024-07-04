using System;


namespace LessonFour
{
  // An interface is a class with nothing but
  // abstract methods. Interfaces are used
  // to represent a contract an object may
  // decide to support.
  
  // Classes that inherit an interface
  // must fulfill the contract and 
  // implement every abstract method
  interface IDrivable
  {
    int Wheels { get; set; }
    double Speed { get; set; }

    void Move();
    void Stop();
  }
}