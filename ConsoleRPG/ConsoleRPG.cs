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

namespace ConsoleRPG
{
    internal class ConsoleRPG
    {
        public static GameEngine Engine;

        private static void CreateNewPlayer()
        {
            Print("Введіть ім'я персонажу: ", AlignPrint.Left);
            string name = InputValue();

            PrintArray(new string[] { "[1] Варвар", "[2] Танк", "[3] Бандит" });
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

        private static void TestPlyaerInfo()
        {
            Player player = new Barbarian("Test");
            player.PutAwayArmor(ArmorType.Chest, new Armor("dahso", 1, 32));
            player.PutAwayArmor(ArmorType.Leggins, new Armor("fdas", 1, 32));
            Monster monster = new Monster("TestMonster", 1,1,1,1,11,1);
            monster.PutAwayArmor(ArmorType.Helmet, new Armor("Armor",1,5));
            monster.PutAwayArmor(ArmorType.Boots, new Armor("Armodfar", 1, 5));
            monster.PutAwayArmor(ArmorType.Chest, new Armor("dajksj", 3, 7));
            ShowPlayerInfo(player);
            ShowMonsterInfo(monster);


            Console.ReadKey();
        }

        private static void MainScreen()
        {
            //DrawMainScreen();
            PrintArray(new string[] { "[S] Start Game", "[E] Exit" });

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

            PlayGame();
        }
    }
}

