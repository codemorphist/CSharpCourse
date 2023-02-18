namespace ConsoleRPG.Creatures.Heros
{
    internal class Tank : Player
    {
        public Tank(string name) : base(name)
        {
            SetEndurance(150);
        }
    }
}
