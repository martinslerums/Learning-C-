using System;


namespace LessonFive
{
  class Battle
  {
    //StartFight

    //Warrior1 attacks warrior2, warrior2 is damaged and health decreases.
    // Get attack result
    //Warrior2 attacks warrior1, warrior1 is damaged and health decreases.
    // Get attack result
    public static void StartFight(Warrior warrior1, Warrior warrior2)
    {
      while (true)
      {
        if (GetAttackResult(warrior1, warrior2) == "Game Over")
        {
          Console.WriteLine("Game Over");
          break;
        }

        if (GetAttackResult(warrior2, warrior1) == "Game Over")
        {
          Console.WriteLine("Game Over");
          break;
        }
      }
    }
    // Get attack result
    public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
    {
      double warAAttkAmt = warriorA.Attack();
      double warBBlkAmt = warriorB.Block();

      double dmgToWarB = warAAttkAmt - warBBlkAmt;


      if (dmgToWarB > 0)
      {
        warriorB.Health -= dmgToWarB;
      }
      else dmgToWarB = 0;

      Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warriorA.Name, warriorB.Name, dmgToWarB);

      Console.WriteLine("{0} Has {1} Health\n", warriorB.Name, warriorB.Health);

      if (warriorB.Health <= 0)
      {
        Console.WriteLine("{0} has been defeated! {1} is Victorious!\n", warriorB.Name, warriorA.Name);

        return "Game Over";
      }
      else return "Fight Again";
    }
  }
}