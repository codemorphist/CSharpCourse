using ConsoleRPG.Items;

namespace ConsoleRPG.Items
{
    abstract class Potion : Item
    { 
        public Potion(string name, int level) : base(name, level) 
        {
        
        }
    }
}
