using System;


namespace LessonFour
{
  class PowerButton : ICommand
  {
    IElectronicDevice device;

    public PowerButton(IElectronicDevice device)
    {
      this.device = device;
    }
    public void Execute()
    {
      device.TurOn();
    }

    public void Undo()
    {
      device.TurnOff();
    }
  }
}