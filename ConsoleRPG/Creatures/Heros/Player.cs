using ConsoleRPG.Creature;
using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Skills;
using System.Collections.Generic;

namespace ConsoleRPG.Creatures.Heros
{
    internal class Player : BasePerson
    {
        // Initialization of characteristics
        private int Agility;
        private int Endurance;

        protected List<ICombatSkill> Skills;

        // Set functions
        public void SetAgility(int value) => Agility = (value > 0) ? value : Agility;
        public void SetEndurance(int value) => Endurance = (value > 0) ? value : Endurance;

        // Skills functions
        public void AddSkill(ICombatSkill skill) => Skills.Add(skill);
        public void RemoveSkill(ICombatSkill skill) => Skills.Remove(skill);
        public void UseSkill(int skill, Monster monster) => Skills[skill].UseSkill(monster);

        // Game functions
        public void LevelUp()
        {
            SetLevel(GetLevel() + 1);
            SetStrength((int) (GetStrength() * 1.5));
            SetHealth(300 * GetLevel());
            SetMaxHealth(GetHealth());
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
            SetStrength(200);
            SetAgility(100);
            SetEndurance(100);
            SetExperiencePoints(100);

            Skills = new List<ICombatSkill>();
        }
    }
}