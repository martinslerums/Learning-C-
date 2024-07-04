using System;

namespace LessonFive
{
  class Warrior
  {
    public string Name { get; set; }
    public double Health { get; set; }
    public double MaxAttack { get; set; }
    public double MaxBlock { get; set; }

    Random rnd = new Random();

    public Warrior(string name = "Warrior", double health = 0, double maxAttack = 0, double maxBlock = 0)
    {
      Name = name;
      Health = health;
      MaxAttack = maxAttack;
      MaxBlock = maxBlock;
    }

    public virtual double Attack()
    {
      return rnd.Next(1, (int)MaxAttack);
    }

    public virtual double Block()
    {
      return rnd.Next(1, (int)MaxBlock);
    }
  }
}