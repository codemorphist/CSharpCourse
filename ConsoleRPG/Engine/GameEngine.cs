using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using ConsoleRPG.Creatures;
using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Engine.Generators;

namespace ConsoleRPG.Engine
{
    internal class GameEngine
    {        
        public Monster GetMonster(Player player)
        {
            return Generator.MonsterGenerator(player);
        }

        public Player CreatePlayer(string name, int type)
        {
            switch (type) 
            {
                case 1:
                    return new Barbarian(name);
                case 2:
                    return new Tank(name);
                case 3:
                    return new Bandit(name);
                default: 
                    return null;
            }
        }

        public Player CreatePlayer()
        {
            return new Tank("Aaron");
        }
    }
}
