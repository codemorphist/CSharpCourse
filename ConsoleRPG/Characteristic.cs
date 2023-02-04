using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleRPG
{
    internal struct Characteristic
    {
        public int Value;

        public void Set(int value)
        {
            if (value > 0)
               Value = value;
        }

        public Characteristic(int value = 100)
        {
            this.Value = value;
        }
    }
}
