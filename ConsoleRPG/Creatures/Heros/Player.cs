using System;
using System.Collections.Generic;

using ConsoleRPG.Creature;
using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Skills;

using static ConsoleRPG.Utils.Generator;

namespace ConsoleRPG.Creatures.Heros
{
    class Player : BasePerson
    {
        // Initialization of characteristics
        public int Agility { get; protected set; }
        public int Endurance { get; protected set; }

        // Initialization of skills
        public List<ICombatSkill> Skills { get; protected set; }

        // Skill function
        public void SetSkill(ICombatSkill skill) => Skills.Add(skill);

        // Set methods
        public void SetAgility(int value) => Agility = (value > 0) ? value : Agility;
        public void SetEndurance(int value) => Endurance = (value > 0) ? value : Endurance;

        // Skills methods
        public void AddSkill(ICombatSkill skill) => Skills.Add(skill);
        public void RemoveSkill(ICombatSkill skill) => Skills.Remove(skill);
        public void UseSkill(int skill, Monster monster) => Skills[skill].UseSkill(monster);

        // Battle method
        public int HitMonster(Monster monster, BodyPart part, int random)
        {
            int damage = Strength;

            // Damage with Weapon
            if (Weapons != null)
                damage = (int)((Strength * 0.2 + Weapons.Damage) * random / 100);

            // Critical hit chance
            if (RandomNumber(0, 200) - 10 < Agility && Agility < RandomNumber(0, 200) + 10)
                damage *= 2;

            monster.GetDamage(damage, part);

            return damage;
        }

        // Game methods
        public void LevelUp()
        {
            SetLevel(Level + 1);
            SetStrength((int) (Strength * 1.5));
            SetHealth(400 * Level);
            SetMaxHealth(Health);
        }

        // Player Class constructor
        public Player(string name) : base (name)
        {
            Level = 1;
            Health = 600;
            MaxHealth = 600;
            Energy = 100;
            Strength = 50;
            Agility = 80;
            Endurance = 100;
            ExperiencePoints = 100;

            Skills = new List<ICombatSkill>();
        }
    }
}