using ConsoleRPG.Creatures.NPC;

namespace ConsoleRPG.Ithems
{
    interface IWeapon
    {
        void UseWeapon(Monster monster);
    }

    abstract class Weapon : Ithem
    {
        protected int Damage;

        public Weapon(string name, int level, int damage) : base(name, level)
        {
            Damage = damage;
        }
    }

    class Sword : Weapon, IWeapon
    {
        public Sword(string name, int level, int damage) : base(name, level, damage) { } 

        public void UseWeapon(Monster monster)
        {
            
        }
    }

    class Hammer : Weapon, IWeapon
    {
        public Hammer(string name, int level, int damage) : base(name, level, damage) { }

        public void UseWeapon(Monster monster)
        {
            
        }
    }

    class Ax : Weapon, IWeapon
    {
        public Ax(string name, int level, int damage) : base(name, level, damage) { }

        public void UseWeapon(Monster monster)
        {
            
        }
    }
}
