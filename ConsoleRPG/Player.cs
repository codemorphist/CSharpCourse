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
        public string Type { get; set; }
        public int Level { get { return Level; } set { Level = (value >= 0) ? value : Level; } }
        public int Health { get { return Health; } set { Health = (value >= 0) ? value : Health; } }
        public int Energy { get { return Energy; } set { Energy = (value >= 0) ? value : Energy; } }
        public int Strength { get { return Strength; } set { Strength = (value >= 0) ? value : Strength; } }
        public int Agility { get { return Agility; } set { Agility = (value >= 0) ? value : Agility; } }
        public int Endurance { get { return Endurance; } set { Endurance = (value >= 0) ? value : Endurance; } }
        public int ExperiencePoints { get { return ExperiencePoints; } set { ExperiencePoints = (value >= 0) ? value : ExperiencePoints; } }

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