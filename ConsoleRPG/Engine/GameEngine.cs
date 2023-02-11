using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleRPG.Creatures;
using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Engine.Generators;

namespace ConsoleRPG.Engine
{
    internal class GameEngine
    {
        private Generator generator = new Generator();
        
        public Monster MonsterGenerator()
        {
            string name = generator.NameGenerator();
            int level = generator.RandomNumber(1,30);
            int health = generator.RandomNumber(100,1000);
            int max_health = generator.RandomNumber(health,health+500);
            int armor = generator.RandomNumber(100,500);
            int energy = generator.RandomNumber(200,500);
            int strength = generator.RandomNumber(10,100);
            int expireance_points = generator.RandomNumber(10,200);

            return new Monster(name, level, health, max_health, 
                               armor, strength, energy, expireance_points);
        }
    }
}
