using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;

namespace ConsoleRPG.Ithems
{
    // Interface for Weapons
    interface IWeapon
    {
        // Use weapon on moster
        void UseWeapon(Player player, Monster monster);
    }
    
    // Weapon class
    abstract class Weapon : Ithem
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

    // Ax class (Prioritet for Bandit)
    class Ax : Weapon, IWeapon
    {
        public Ax(string name, int level, int damage) : base(name, level, damage) { }

        public void UseWeapon(Player player, Monster monster)
        {
            
        }
    }
}
