using System;
using System.Text;

using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Engine;
using ConsoleRPG.Items;

using static ConsoleRPG.Utils.InputOutput;
using static ConsoleRPG.Utils.GameGraphics;
using static ConsoleRPG.Utils.Animation;
using static ConsoleRPG.Utils.Resources;
using static ConsoleRPG.Utils.Generator;
using ConsoleRPG.Utils;

namespace ConsoleRPG
{
    internal class ConsoleRPG
    {
        public static GameEngine Engine;

        private static void CreateNewPlayer()
        {
            Print("Введіть ім'я персонажу: ", AlignPrint.Left);
            string name = InputValue();

            PrintMenu(new string[] { "[1] Варвар", "[2] Танк", "[3] Бандит" }, AlignPrint.Left);
            Print("Виберіть тип: ", AlignPrint.Left);
            int type = InputInt();

            Engine.CreatePlayer(name, type);
        }

        private static void AnimationTest()
        {
            Animation Phenix = new Animation(phenix_anim);
            Phenix.DrawAnimation(120);

            Console.ReadKey();
        }

        private static void PlayGame()
        {
            Engine = new GameEngine();

            CreateNewPlayer();

            Monster monster = Engine.GetMonster();

            while (Engine.Battle(monster) == 1)
            {
                WinScreen();
                Console.ReadKey();

                monster = Engine.GetMonster();
            }

            DeadScreen();
        }

        private static void MainScreen()
        {
            //DrawMainScreen();
            PrintMenu(new string[] { "[S] Start Game", "[E] Exit" }, AlignPrint.Center);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.S:
                    Console.Clear();
                    PlayGame();
                    break;
                case ConsoleKey.E:
                    Console.Clear();
                    return;
            }
        }

        static void Main(string[] args)
        {
            // Enable support Unicode input and output
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Sword: {GenerateWeaponName(IthemType.Sword)}");
                Console.WriteLine($"Hummer: {GenerateWeaponName(IthemType.Hummer)}");
                Console.WriteLine($"Axe: {GenerateWeaponName(IthemType.Axe)}");
                Console.WriteLine($"Spear: {GenerateWeaponName(IthemType.Spear)}");

                Console.ReadKey();
            }
        }
    }
}

