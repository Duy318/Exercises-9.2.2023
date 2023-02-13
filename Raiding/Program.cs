using Raiding.Models;
using Raiding.Models.Contracts;
using System;
using System.Collections.Generic;

namespace Raiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validHeroCount = int.Parse(Console.ReadLine());

            List<BaseHero> heroes = new List<BaseHero>();

            while (true)
            {
                if (heroes.Count == validHeroCount)
                    break;

                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid")
                    heroes.Add(new Druid(heroName));

                else if (heroType == "Paladin")
                    heroes.Add(new Paladin(heroName));

                else if (heroType == "Rogue")
                    heroes.Add(new Rogue(heroName));

                else if (heroType == "Warrior")
                    heroes.Add(new Warrior(heroName));

                else
                    Console.WriteLine("Invalid hero!");
            }

            int bossPower = int.Parse(Console.ReadLine());

            int totalPartyPower = 0;

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());

                totalPartyPower += hero.Power;
            }

            Console.WriteLine(totalPartyPower >= bossPower ? "Victory!" : "Defeat...");
        }
    }
}