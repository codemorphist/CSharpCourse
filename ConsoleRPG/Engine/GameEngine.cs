using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;

using static ConsoleRPG.Utils.Generator;

namespace ConsoleRPG.Engine
{
    internal class GameEngine
    {        
        public Monster GetMonster(Player player)
        {
            /* This function generaate Monster by Player characteristics */
            string name = GenerateName();
            int level = RandomNumber(player.GetLevel(), player.GetLevel() + 2);
            int health = RandomNumber(player.GetHealth() - 100, player.GetHealth() + 100);
            int max_health = RandomNumber(health, health + 500);
            int armor = RandomNumber(100, 500);
            int max_armor = RandomNumber(armor, armor + 100);
            int energy = RandomNumber(200, 500);
            int strength = RandomNumber(10, 100);
            int expireance_points = RandomNumber(10, 200);

            return new Monster(name, level, health, max_health,
                                armor, max_armor, strength, energy, expireance_points);
        }

        public Player CreatePlayer(string name, int type)
        {
            /* This function return Player with some type and name */ 
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
    }
}
