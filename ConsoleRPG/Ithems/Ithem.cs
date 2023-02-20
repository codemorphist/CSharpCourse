using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Ithems
{
    class Ithem
    {
        // Initialization of variables 
        protected string Name;
        protected int Level;

        // Constructor of Ithems
        public Ithem(string name, int level)
        {
            Name = name;
            Level = level;
        }
    }
}
