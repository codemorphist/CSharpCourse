using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Engine;

using static ConsoleRPG.Interface.InputOutput;
using static ConsoleRPG.Interface.GameGraphics;

namespace ConsoleRPG
{
    internal class ConsoleRPG
    {
        private static GameEngine Engine = new GameEngine();
        private static Player player = null;

        private static void CreateNewPlayer()
        {
            Print("Введіть ім'я персонажу: ", AlignPrint.Left);
            string name = InputValue();

            PrintMenu(new string[] { "Варвар", "Танк", "Бандит" }, AlignPrint.Left);
            Print("Виберіть тип: ", AlignPrint.Left);
            int type = InputInt();

            player = Engine.CreatePlayer(name, type);
        }

        static void Main(string[] args)
        {
            // Enable support Unicode input and output
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            CreateNewPlayer();

            Monster monster = Engine.GetMonster(player);

            ShowPlayerInfo(player);
            ShowMonsterInfo(monster);
            
            Print($"\nНатисніть будть-яку клавішу щоб почати бій з {monster.GetName()}");
            Console.ReadKey();

            while ( Engine.Battle(player, monster) == 1)
            {
                WinScreen();
                Console.ReadKey();

                player.LevelUp();
                monster = Engine.GetMonster(player);
            }

            DeadScreen();
        }
    }
}
