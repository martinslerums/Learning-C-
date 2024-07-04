using System;


namespace LessonFive
{
  class MagicWarrior : Warrior
  {
    int teleportChance = 0;
    CanTeleport teleportType = new CanTeleport();

    public MagicWarrior(string name = "Magic Warrior",
                        double health = 0,
                        double maxAttack = 0,
                        double maxBlock = 0,
                        int teleportChance = 0)
                        : base(name, health, maxAttack, maxBlock)
    {
      this.teleportChance = teleportChance;
    }

    public override double Block()
    {
      Random rnd = new Random();
      int rndDodge = rnd.Next(1, 100);

      if (rndDodge < this.teleportChance)
      {
        Console.WriteLine($"{Name} {teleportType.Teleport()}");
        return 10000;
      }
      else
      {
        return base.Block();
      }
    }
  }
}