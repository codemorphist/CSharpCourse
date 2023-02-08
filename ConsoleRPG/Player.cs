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
        public string Name;
        public string Type;
        public int Level;
        public int Health;
        public int Energy;
        public int Strength;
        public int Agility;
        public int Endurance;
        public int ExperiencePoints;

        public Player(string name, string type)
        {
            Name = name;
            Type = type;

            switch (type)
            {
                case "Barbarian":
                    // Characteristics settings ...
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