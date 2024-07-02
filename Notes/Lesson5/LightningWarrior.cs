using System;


namespace LessonFive
{
  class LightningWarrior : Warrior
  {
    int lightningStrikeChance = 0;

    CanLightningStrike strikeType = new CanLightningStrike();

    public LightningWarrior(string name = "Lightning Warrior",
                            double health = 0,
                            double maxAttack = 0,
                            double maxBlock = 0,
                            int lightningStrikeChance = 0)
                            : base(name, health, maxAttack, maxBlock)
    {
      this.lightningStrikeChance = lightningStrikeChance;
    }

    public override double Attack()
    {
      Random rnd = new Random();
      int rndStrike = rnd.Next(1, 100);

      if (rndStrike < this.lightningStrikeChance)
      {
        Console.WriteLine($"{Name} {strikeType.LightningStrike()}");
        return MaxAttack * 2;
      } 
      else 
      {
        return base.Attack();
      }
    }


  }
}