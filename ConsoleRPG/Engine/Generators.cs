using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Engine.Generators
{
    internal class Generator
    {
        private Random random = new Random();

        public int RandomNumber(int min, int max) => random.Next(min, max+1);

        public string NameGenerator()
        {
            string[] names = { "Aron", "Methis", "Draco" };

            string name = names[RandomNumber(0, names.Length)];
            return name;
        }
    }
}
