using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class Monster : Creature
    {
        public Characteristic Armor = new Characteristic();

        public void DisplayMonster() 
        {
            Console.WriteLine($"[Name] :: {Name}");
            Console.WriteLine($"[Level] :: {Level.Value}");
            Console.WriteLine($"[Health] :: {Health.Value}");
            Console.WriteLine($"[Armor] :: {Armor.Value}");
            Console.WriteLine($"[Energy] :: {Energy.Value}");
            Console.WriteLine($"[Strength] :: {Strength.Value}");
            Console.WriteLine($"[Agility] :: {Agility.Value}");
            Console.WriteLine($"[Endurance] :: {Endurance.Value}");
            Console.WriteLine($"[Experience points] :: {ExperiencePoints.Value}");
        }

        public Monster(string name, int armor = 100) : base (name)
        {
            Armor.Set(armor);
        }
    }
}
