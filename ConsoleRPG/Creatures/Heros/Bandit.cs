using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Creatures.Heros
{
    internal class Bandit : Player
    {
        public Bandit(string name) : base (name)
        {
            SetAgility(150);
        }
    }
}
