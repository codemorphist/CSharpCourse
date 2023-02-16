using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Creature
{
    internal class BasePerson
    {
        // Initialization of characteristics
        private readonly string Name;
        private int Level;
        private int Health, MaxHealth;
        private int Energy, MaxEnergy;
        private int Strength;
        private int ExperiencePoints;

        // Set functions
        public void SetLevel(int value) => Level = (value > 0) ? value : Level;
        public void SetHealth(int value) => Health = (value >= 0) ? value : 0;
        public void SetMaxHealth(int value) => MaxHealth = (value > 0) ? value : MaxHealth;
        public void SetEnergy(int value) => Energy = (value > 0) ? value : Energy;
        public void SetMaxEnergy(int value) => MaxEnergy = (value > 0) ? value : MaxEnergy;
        public void SetStrength(int value) => Strength = (value > 0) ? value : Strength;
        public void SetExperiencePoints(int value) => ExperiencePoints = (value > 0) ? value : ExperiencePoints;

        // Get functions 
        public string GetName () => Name;
        public int GetLevel() => Level;
        public int GetHealth() => Health;
        public int GetMaxHealth() => MaxHealth;
        public int GetEnergy() => Energy;
        public int GetStrength() => Strength;
        public int GetExperiencePoints() => ExperiencePoints;

        // Class constructor
        public BasePerson (string name)
        {
            Name = name;
        }
    }
}
