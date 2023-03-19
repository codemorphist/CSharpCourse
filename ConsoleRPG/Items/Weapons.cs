namespace ConsoleRPG.Items
{
   
    // Weapon class
    abstract class Weapon : Item
    {
        public int Damage { get; }

        public Weapon(string name, int level, int damage) : base(name, level)
        {
            Damage = damage;
        }
    }

    // Sword class (Prioritet for Barbarian)
    class Sword : Weapon
    {
        public Sword(string name, int level, int damage) : base(name, level, damage) { } 
    }

    // Hammer class (Prioritet for Tank)
    class Hammer : Weapon
    {
        public Hammer(string name, int level, int damage) : base(name, level, damage) { }
    }

    // Axe class (Prioritet for Bandit)
    class Axe : Weapon
    {
        public Axe(string name, int level, int damage) : base(name, level, damage) { }
    }

    // Spears class (Universall for all)
    class Spears : Weapon
    {
        public Spears(string name, int level, int damage) : base(name, level, damage) { }
    }
}
