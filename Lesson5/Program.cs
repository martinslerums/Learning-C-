using System;

namespace LessonFive
{
  class Program
  {
    static void LessonFive(string[] args)
    {
      LightningWarrior thor = new LightningWarrior("Thor", 100, 26, 10, 20);
      MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 8, 50);

      Battle.StartFight(thor, loki);
    }
  }
}