using ConsoleRPG.Items;

namespace ConsoleRPG.Locations
{
    internal class Store : Location
    {
        public Item[] Items { get; protected set; }

        public Item BuyItem(int index)
        {
            Item item =  Items[index];
            Items[index] = null;

            return item;
        }

        public Store(string name, Item[] items) : base (name)
        {
            Items = items;
        }
    }
}
