using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class RPG
    {
        static void Main(string[] args)
        {
            Player Bob = new Player("Bob", 1);
            Bob.Health.Set(12);
            Bob.DisplayCreature();
        }
    }
}
