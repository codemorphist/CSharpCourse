using ConsoleRPG.Utils;

namespace ConsoleRPG.Locations
{
    abstract class Location : TimeHelper
    {
        public string LocationName { get; protected set; }

        public Location(string name) : base ()
        {
            LocationName = name;
        }
    }
}
