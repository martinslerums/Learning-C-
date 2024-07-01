using System;


namespace LessonFour
{
  class Television : IElectronicDevice
  {
    public int Volume { get; set; }

    public void TurnOff()
    {
      Console.WriteLine("The TV is shutting down");
    }

    public void TurOn()
    {
      Console.WriteLine("The TV is turning on");
    }

    public void VolumeDown()
    {
      if (Volume != 0) Volume--;
      Console.WriteLine($"The TV volume is at {Volume}");
    }

    public void VolumeUp()
    {
      if (Volume != 100) Volume++;
      Console.WriteLine($"The TV volume is at {Volume}");
    }
  }
}