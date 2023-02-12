using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static ConsoleRPG.Engine.Generators.NameGeneratror;

namespace ConsoleRPG.Engine.Generators
{
    static class Generator
    {
        private static readonly Random random = new Random();

        public static int RandomNumber(int min, int max) => random.Next(min, max+1);

        public static Monster MonsterGenerator(Player player)
        {
            string name = GenerateName();
            int level = RandomNumber(player.GetLevel() - 1, player.GetLevel() + 1);
            int health = RandomNumber(player.GetHealth()-100, player.GetHealth() + 100);
            int max_health = RandomNumber(health, health + 500);
            int armor = RandomNumber(100, 500);
            int energy = RandomNumber(200, 500);
            int strength = RandomNumber(10, 100);
            int expireance_points = RandomNumber(10, 200);

            return new Monster(name, level, health, max_health,
                               armor, strength, energy, expireance_points);
        }
    }
}
