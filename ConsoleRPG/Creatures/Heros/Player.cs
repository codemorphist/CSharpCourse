using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Creature;

namespace ConsoleRPG.Creatures.Heros
{
    internal class Player : BasePerson
    {
        // Initialization of characteristics
        private int Agility;
        private int Endurance;

        // Set functions
        public void SetAgility(int value) => Agility = (value > 0) ? value : Agility;
        public void SetEndurance(int value) => Endurance = (value > 0) ? value : Endurance;

        public void LevelUp()
        {
            SetLevel(GetLevel() + 1);
            SetStrength((int) (GetStrength() * 1.5));
            SetHealth(600);
        }

        // Get functions
        public int GetAgility() => Agility;
        public int GetEndurance() => Endurance;

        // Player Class constructor
        public Player(string name) : base (name)
        {
            SetLevel(1);
            SetHealth(600);
            SetMaxHealth(600);
            SetEnergy(100);
            SetMaxEnergy(100);
            SetStrength(50);
            SetAgility(100);
            SetEndurance(100);
            SetExperiencePoints(100);
        }
    }
}