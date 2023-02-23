namespace ConsoleRPG.Items
{
    enum ArmorType
    {
        Helmet,
        Chest,
        Leggins,
        Boots
    }

    class Armor : Item
    {
        public int ArmorPoints { get; private set; }
        public int MaxArmorPoints { get; }

        // Set functions
        public void SetArmorPoints(int armor) => ArmorPoints = (armor >= 0) ? armor : 0;

        public Armor(string name, int level, int armor_points) : base(name, level) 
        {
            ArmorPoints = armor_points;
            MaxArmorPoints = armor_points;
        }
    }
}
