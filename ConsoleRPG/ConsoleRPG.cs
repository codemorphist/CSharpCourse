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
using ConsoleRPG.Creature;
using System.Security.Cryptography;
using System.Threading;

namespace ConsoleRPG
{
    internal class ConsoleRPG
    {
        public static GameEngine Engine;

        private static void CreateNewPlayer()
        {
            PrintByCords("[Меню створення персонажа]", (Console.WindowWidth - 25) / 2, 0);

            PrintByCords("Введіть ім'я персонажу: ", (Console.WindowWidth - 20) / 2, Console.WindowHeight / 2);
            string name = InputValue();

            Console.Clear();

            PrintByCords("[Меню створення персонажа]", (Console.WindowWidth - 25) / 2, 0);

            PrintArrayByCords(new string[] { "[1] Варвар", "[2] Танк", "[3] Бандит\n" }, (Console.WindowWidth - 10) / 2, (Console.WindowHeight - 3) / 2);
            Print("Виберіть тип: ", AlignPrint.Center);
            int type = InputInt();

            Engine.CreatePlayer(name, type);
        }

        private static void PlayGame()
        {
            Engine = new GameEngine();

            CreateNewPlayer();

            Adventure adventure = new Adventure(Console.WindowWidth, Console.WindowHeight - 1);
            PrintArray(adventure.Field, adventure.hero_x, adventure.hero_y);

            while (true)
            {
                string info = "";

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.W:
                        adventure.MoveHero("Up");
                        break;
                    case ConsoleKey.S:
                        adventure.MoveHero("Down");
                        break;
                    case ConsoleKey.D:
                        adventure.MoveHero("Right");
                        break;
                    case ConsoleKey.A:
                        adventure.MoveHero("Left");
                        break;
                    case ConsoleKey.E:
                        switch (adventure.CurrentSymbol)
                        {
                            case 'M':
                                Monster monster = Engine.GetMonster();
                                if (Engine.Battle(monster) == 1)
                                {
                                    WinScreen();
                                    adventure.CurrentSymbol = 'D';
                                    Console.ReadKey();
                                    break;
                                }
                                DeadScreen();
                                Console.ReadKey();
                                return;
                            case 'A':
                                info = Engine.NewArmor();
                                adventure.CurrentSymbol = 'o';
                                break;
                            case 'W':
                                info =  Engine.NewWeapon();
                                adventure.CurrentSymbol = 'o';
                                break;
                            default:
                                info = "Nothing here..";
                                break;
                        }
                        break;
                }

                PrintArray(adventure.Field, adventure.hero_x, adventure.hero_y);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.Write($"\rX: {adventure.hero_x} Y: {adventure.hero_y}\t");

                if (info != "")
                {
                    Console.Write(info + ' ');
                    continue;
                }

                switch (adventure.CurrentSymbol)
                {
                    case 'M':
                        Console.Write("Monster is here... Press [E] to fight");
                        break;
                    case 'A':
                        Console.Write("Press [E] to pick up Armor");
                        break;
                    case 'W':
                        Console.Write("Press [E] to pick up Weapon");
                        break;
                    case 'C':
                        Console.Write("Press [E] to open a Chest (in next release)");
                        break;
                }

            }
        }

        private static int MainScreen()
        {
            Console.Clear();

            DrawMenuBanner();

            string[] menu = { "Натисніть відповідну клавішу:", "[S] Start Game", "[X] Exit" };
            PrintArrayByCords(menu, (Console.WindowWidth - MaxLenInStringArray(menu)) / 2, (Console.WindowHeight - menu.Length) / 2);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.X:
                    Console.Clear();
                    return 1;
                default:
                    Console.Clear();
                    PlayGame();
                    return 0;
            }
        }

        private static void LoadingScreen()
        {
            DrawGameBanner();

            PrintByCords("[", 1, Console.WindowHeight - 1);
            PrintByCords("]", Console.WindowWidth - 1, Console.WindowHeight - 1);
            for (int i = 0; i < Console.WindowWidth - 3; i++)
            {
                PrintByCords("#", i + 2, Console.WindowHeight - 1);
                Thread.Sleep(30);
            }

            Console.Clear();
        }

        static void Main(string[] args)
        {
            // Enable support Unicode input and output
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.CursorVisible = false;

            LoadingScreen();

            int exit;
            do
            {
                exit = MainScreen();
            } while (exit != 1);

            Console.Clear();
        }
    }
}

