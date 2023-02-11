using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleRPG.Creatures;
using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Engine.Generators;

namespace ConsoleRPG.Engine
{
    internal class GameEngine
    {
        private readonly Generator generator = new Generator();
        
        public Monster GetMonster(Player player)
        {
            return generator.MonsterGenerator(player);
        }

        public Player CreatePlayer()
        {
            return new Tank("Aaron");
        }
    }
}
