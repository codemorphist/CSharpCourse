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

        // Get functions
        public int GetAgility() => Agility;
        public int GetEndurance() => Endurance;


        // Player Class constructor
        public Player(string name) : base (name)
        {
            SetHealth(100);
        }
    }
}