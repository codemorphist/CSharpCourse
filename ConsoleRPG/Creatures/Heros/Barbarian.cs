namespace ConsoleRPG.Creatures.Heros
{
    class Barbarian : Player
    {
        public Barbarian(string name) : base(name)
        {
            SetStrength((int)(GetStrength() * 1.5));
        }
    }
}
