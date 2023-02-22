using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;

namespace ConsoleRPG.Items
{
    // Interface for Weapons
    interface IWeapon
    {
        // Use weapon on moster
        void UseWeapon(Player player, Monster monster);
    }
    
    // Weapon class
    abstract class Weapon : Item
    {
        protected int Damage;

        public Weapon(string name, int level, int damage) : base(name, level)
        {
            Damage = damage;
        }
    }

    // Sword class (Prioritet for Barbarian)
    class Sword : Weapon, IWeapon
    {
        public Sword(string name, int level, int damage) : base(name, level, damage) { } 

        public void UseWeapon(Player player, Monster monster)
        {
            monster.SetHealth(monster.GetHealth() - Damage);
        }
    }

    // Hammer class (Prioritet for Tank)
    class Hammer : Weapon, IWeapon
    {
        public Hammer(string name, int level, int damage) : base(name, level, damage) { }

        public void UseWeapon(Player player, Monster monster)
        {
           
        }
    }

    // Axe class (Prioritet for Bandit)
    class Axe : Weapon, IWeapon
    {
        public Axe(string name, int level, int damage) : base(name, level, damage) { }

        public void UseWeapon(Player player, Monster monster)
        {
            
        }
    }

    // Spears class (Universall for all)
    class Spears : Weapon, IWeapon
    {
        public Spears(string name, int level, int damage) : base(name, level, damage) { }

        public void UseWeapon(Player player, Monster monster)
        {

        }
    }
}
