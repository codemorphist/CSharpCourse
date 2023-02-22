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
        protected int ArmorPoints;

        // Set functions
        public void SetArmor(int armor) => ArmorPoints = armor >= 0 ? armor : ArmorPoints;

        // Get functions
        public int GetArmor(int armor) => ArmorPoints;

        public Armor(string name, int level, int armor_points) : base(name, level) 
        {
            ArmorPoints = armor_points;
        }
    }
}
