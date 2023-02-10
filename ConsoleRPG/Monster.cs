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
        public string Name { get; }
        private int Level;
        private int Health;
        private int Armor;
        private int Energy;
        private int Strength;
        private int ExperiencePoints;

        // Set functions
        public void SetLevel(int value) => Level = (value > 0) ? value : Level;
        public void SetHealth(int value) => Health = (value > 0) ? value : Health;
        public void SetArmor(int value) => Armor = (value > 0) ? value : Armor;
        public void SetEnergy(int value) => Energy = (value > 0) ? value : Energy;
        public void SetStrength(int value) => Strength = (value > 0) ? value : Strength;
        public void SetExperiencePoints(int value) => ExperiencePoints = (value > 0) ? value : ExperiencePoints;


        // Get functions
        public int GetLevel() => Level;
        public int GetHealth() => Health;
        public int GetArmor() => Armor;
        public int GetEnergy() => Energy;
        public int GetStrength() => Strength;
        public int GetExperiencePoints() => ExperiencePoints;

        // Monster Class constructor
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
