using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class Creature
    {
        public string Name;
        public Characteristic Level = new Characteristic();
        public Characteristic Health = new Characteristic();
        public Characteristic Energy = new Characteristic();
        public Characteristic Strength = new Characteristic();
        public Characteristic Agility = new Characteristic();
        public Characteristic Endurance = new Characteristic();
        public Characteristic ExperiencePoints = new Characteristic();

        public void DisplayCreature()
        {
            Console.WriteLine($"[Name] :: {Name}");
            Console.WriteLine($"[Level] :: {Level.Value}");
            Console.WriteLine($"[Health] :: {Health.Value}");
            Console.WriteLine($"[Energy] :: {Energy.Value}");
            Console.WriteLine($"[Strength] :: {Strength.Value}");
            Console.WriteLine($"[Agility] :: {Agility.Value}");
            Console.WriteLine($"[Endurance] :: {Endurance.Value}");
            Console.WriteLine($"[Experience points] :: {ExperiencePoints.Value}");
        }

        public Creature(string name, int level = 1, int health = 100, int energy = 100, 
                        int strength = 100, int agility = 100, int endurance = 100, int points = 100) 
        {
            Name = name;
            Level.Set(level);
            Health.Set(health);
            Energy.Set(energy);
            Strength.Set(strength);
            Agility.Set(agility);  
            Endurance.Set(endurance);
            ExperiencePoints.Set(points);
        }
    }
}
