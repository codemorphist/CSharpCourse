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
        public string Name { get; }
        public int Level { get; }

        // Constructor of Ithems
        public Item(string name, int level)
        {
            Name = name;
            Level = level;
        }
    }
}
