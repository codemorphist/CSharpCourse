namespace ConsoleRPG.Creatures.Heros
{
    class Tank : Player
    {
        public Tank(string name) : base(name)
        {
            SetEndurance(150);
        }
    }
}
