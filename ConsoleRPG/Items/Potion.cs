using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Items;

namespace ConsoleRPG.Items
{
    interface IPotion
    {
        void UsePotion(Player player);
    }

    abstract class Potion : Item
    {
        public Potion(string name, int level) : base(name, level)
        {

        }
    }

    // This potion change Player health
    class HealthPotion : Potion, IPotion
    {
        public int HealthChange { get; protected set; }

        public void UsePotion(Player player)
        {
            player.SetHealth(player.Health + HealthChange);
        }

        public HealthPotion(string name, int level, int helth_change) : base(name, level) 
        {
            HealthChange = helth_change;
        }
    }

    // This potion change Player strength
    class StrengthPotion : Potion, IPotion
    {
        public int StrengthChange { get; protected set; }

        public void UsePotion(Player player)
        {
            player.SetStrength(player.Strength + StrengthChange);
        }

        public StrengthPotion(string name, int level, int strength_change) : base (name, level)
        {
            StrengthChange = strength_change;
        }
    }
}
