using System;
using System.Collections.Generic;

using ConsoleRPG.Creature;
using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Ithems;
using ConsoleRPG.Skills;

namespace ConsoleRPG.Creatures.Heros
{
    class Player : BasePerson
    {
        // Initialization of characteristics
        private int Agility;
        private int Endurance;

        // Initialization of skills
        private List<ICombatSkill> Skills;

        // Skills functions
        public List<ICombatSkill> GetSkills() => Skills; // This function return all skill
        public ICombatSkill GetSkill(int index) => Skills[index]; // This function return specific skill

        // Initialization of armor
        // 1: Helmet
        // 2: Chest
        // 3: Leggins
        // 4: Boots
        private Armor[] Armors;

        // Armor functions
        public void PutAwayArmor(ArmorType type, Armor armor)
        {
            /* This function puts Armor on a specific part of the player's body */

            try
            {
                if ((int) type > Armors.Length - 1)
                    throw new Exception("Не можливо вдягнути броню на цю чатину тіла");

                Armors[(int) type] = armor;
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"[ERROR] {ex.Message}");
            }
        }

        // This function return Armor from specific part of the player's body
        public Armor GetArmor(ArmorType type) => Armors[(int) type];

        // Initialization of weapon
        private IWeapon PlayerWeapon;

        // Weapon functions
        public IWeapon GetWeapon() => PlayerWeapon;
        public void SetWeapon(IWeapon weapon) => PlayerWeapon = weapon; 

        // Set functions
        public void SetAgility(int value) => Agility = (value > 0) ? value : Agility;
        public void SetEndurance(int value) => Endurance = (value > 0) ? value : Endurance;

        // Skills functions
        public void AddSkill(ICombatSkill skill) => Skills.Add(skill);
        public void RemoveSkill(ICombatSkill skill) => Skills.Remove(skill);
        public void UseSkill(int skill, Monster monster) => Skills[skill].UseSkill(monster);

        // Get functions
        public int GetAgility() => Agility;
        public int GetEndurance() => Endurance;

        // Game functions
        public void LevelUp()
        {
            SetLevel(GetLevel() + 1);
            SetStrength((int) (GetStrength() * 1.5));
            SetHealth(400 * GetLevel());
            SetMaxHealth(GetHealth());
        }

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
            Armors = new Armor[4];
        }
    }
}