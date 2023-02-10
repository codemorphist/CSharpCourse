using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class Player
    {
        // Initialization of characteristics
        private string Name { get; }
        private string Type { get; }
        private int Level;
        private int Health;
        private int Energy;
        private int Strength;
        private int Agility;
        private int Endurance;
        private int ExperiencePoints;

        // Set functions
        public void SetLevel(int value) => Level = (value > 0) ? value : Level;
        public void SetHealth(int value) => Health = (value > 0) ? value : Health;
        public void SetEnergy(int value) => Energy = (value > 0) ? value : Energy;
        public void SetStrength(int value) => Strength = (value > 0) ? value : Strength;
        public void SetAgility(int value) => Agility = (value > 0) ? value : Agility;
        public void SetEndurance(int value) => Endurance = (value > 0) ? value : Endurance;
        public void SetExperiencePoints(int value) => ExperiencePoints = (value > 0) ? value : ExperiencePoints;

        // Get functions
        public int GetLevel() => Level;
        public int GetHealth() => Health;
        public int GetEnergy() => Energy;
        public int GetStrength() => Strength;
        public int GetAgility() => Agility;
        public int GetEndurance() => Endurance;
        public int GetExperiencePoints() => ExperiencePoints;

        // Player Class constructor
        public Player(string name, string type)
        {
            Name = name;
            Type = type;

            switch (type)
            {
                case "Barbarian":
                    // Characteristics settings ...
                    Health = 100;
                    break;
                case "Tank":
                    // Characteristics settings ...
                    break;
                case "Bandit":
                    // Characteristics settings ...
                    break;
            }
        }
    }
}