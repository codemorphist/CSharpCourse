using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Creature;

namespace ConsoleRPG.Creatures.NPC
{
    internal class Monster : BasePerson
    {
        // Initialization of characteristics
        private int Armor, MaxArmor;

        // Set functions
        public void SetArmor(int value) => Armor = (value > 0) ? value : Armor;
        public void SetMaxArmor(int value) => MaxArmor = (value > 0) ? value : MaxArmor;

        // Get functions
        public int GetArmor() => Armor;

        // Monster Class constructor
        public Monster(string name, int level, int health, int max_health,
            int armor, int max_armor, int strength, int energy, int experience_points) : base (name)
        {
            SetLevel(level);
            SetHealth(health);
            SetMaxHealth(max_health);
            SetArmor(armor);
            SetMaxArmor(max_armor);
            SetEnergy(energy);
            SetStrength(strength);
            SetExperiencePoints(experience_points);
        }
    }
}
