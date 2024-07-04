using System;


namespace LessonFour
{
  interface ICommand
  {
    void Execute();
    void Undo();
  }
}