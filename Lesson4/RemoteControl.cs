using System;


namespace LessonFour
{
  class RemoteControl
  {
    public static IElectronicDevice GetDevice()
    {
      return new Television();
    }
  }
}