using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class Monster
    {
        // Initialization of characteristics
        public string Name;
        public int Level;
        public int Health;
        public int Armor;
        public int Energy;
        public int Strength;
        public int ExperiencePoints;

        public Monster(string name)
        {
            Name = name;
            Level = 1;
            Health = 100;
            Armor = 100;
            Energy = 100;
            Strength = 5;
            ExperiencePoints = 100;
        }
    }
}
