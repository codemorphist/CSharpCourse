namespace ConsoleRPG.Items
{
    enum IthemType
    {
        // Weapon
        Sword,
        Hummer,
        Axe,
        Spear,

        //Armor
        Helmet,
        Chest,
        Leggins,
        Boots
    }   

    enum IthemRank
    {
        Heavy,
        Light
    }

    class Item
    {
        // Initialization of variables 
        protected string Name;
        protected int Level;

        // Constructor of Ithems
        public Item(string name, int level)
        {
            Name = name;
            Level = level;
        }
    }
}
