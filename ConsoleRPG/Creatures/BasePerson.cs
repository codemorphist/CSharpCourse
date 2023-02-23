using ConsoleRPG.Items;
using System;

namespace ConsoleRPG.Creature
{
    enum BodyPart
    {
        Head,
        Body,
        Legs,
        Feet
    }

    internal class BasePerson
    {
        private static readonly Random random = new Random();

        // Initialization of characteristics
        public string Name { get; }
        public int Level { get; protected set; }
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }
        public int Energy { get; protected set; }
        public int Strength { get; protected set; }
        public int ExperiencePoints { get; protected set; }

        // Initialization of armor
        // 1: Helmet
        // 2: Chest
        // 3: Leggins
        // 4: Boots
        public Armor[] Armors { get; protected set; }

        // Armor methods
        public void PutAwayArmor(ArmorType type, Armor armor)
        {
            /* This function puts Armor on a specific part of the person's body */
            if ((int)type > Armors.Length - 1 || (int)type < 0)
                return;

            Armors[(int)type] = armor;  
        }

        // Initialization of weapon
        public Weapon Weapons { get; protected set; }

        // Weapon methods
        public void SetWeapon(Weapon weapon) => Weapons = weapon;

        // Set methods
        public void SetLevel(int value) => Level = (value > 0) ? value : Level;
        public void SetHealth(int value) => Health = (value >= 0) ? value : 0;
        public void SetMaxHealth(int value) => MaxHealth = (value > 0) ? value : MaxHealth;
        public void SetEnergy(int value) => Energy = (value > 0) ? value : Energy;
        public void SetStrength(int value) => Strength = (value > 0) ? value : Strength;
        public void SetExperiencePoints(int value) => ExperiencePoints = (value > 0) ? value : ExperiencePoints;

        // Battle methods
        public void GetDamage(int damage, BodyPart part)
        {
            Armor armor = Armors[(int)part];
            if (armor != null)
            {
                armor.SetArmorPoints(armor.ArmorPoints - damage);

                if (armor.ArmorPoints == 0)
                    Armors[(int)part] = null;
            }
            else
            {
                SetHealth(Health - damage);
            }
        }

        // BasePerson constructor
        public BasePerson (string name)
        {
            Name = name;

            Armors = new Armor[4];
            Weapons = null;
        }
    }
}
