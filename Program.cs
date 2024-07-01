using ConsoleApp1;
using LessonTwo;
using System;

namespace LessonTwo
{
  class LessonTwoProgram
  {
    static void Main(string[] args)
    {
      Animal whiskers = new Animal()
      {
        Name = "Whiskers",
        Sound = "Meoooow"
      };

      Dog batons = new Dog()
      {
        Name = "Batons",
        Sound = "Wooof",
        Sound2 = "Grrrrrrr"
      };

      batons.Sound = "Woooooooof";

      whiskers.MakeSound();
      batons.MakeSound();

      whiskers.SetAnimalIDInfo(12345, "Sally Whisker");
      whiskers.GetAnimalIDInfo();

      batons.SetAnimalIDInfo(12344, "Martin");

      Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
      Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));

      Animal monkey = new Animal()
      {
        Name = "Happy",
        Sound = "Heeeeaaa"
      };

      Animal spot = new Dog()
      {
        Name = "Spot",
        Sound = "Wofwof",
        Sound2 = "Geeerrrrr"
      };

      spot.MakeSound();
    }

  }
}