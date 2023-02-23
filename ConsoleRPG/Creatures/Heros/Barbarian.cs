using ConsoleRPG.Items;

namespace ConsoleRPG.Creatures.Heros
{
    class Barbarian : Player
    {
        public Barbarian(string name) : base(name)
        {
            Strength = (int)(Strength * 1.5);
        }
    }
}
