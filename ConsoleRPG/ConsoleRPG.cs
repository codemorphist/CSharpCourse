using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Engine;
using static ConsoleRPG.Interface.TUI;

namespace ConsoleRPG
{
    internal class ConsoleRPG
    {
        private static Random random = new Random();
        private static GameEngine Engine = new GameEngine();
        private static Player player = null;

        private static void DrawHitLine(int len)
        {
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2 - 1, 0);

            for (int i = 0; i < 50; i++)
            {
                if (i == len)
                    Print("<*>");
                else
                    Print(" ");
            }
        }

        private static void CreateNewPlayer()
        {
            Print("Введіть ім'я персонажу: ", AlignPrint.Left);
            string name = InputValue();

            PrintMenu(new string[]{ "Варвар", "Танк", "Бандит" }, AlignPrint.Left);
            Print("Виберіть тип: ", AlignPrint.Left);
            int type = InputInt();

            player = Engine.CreatePlayer(name, type);
        }

        private static void HitMechanic()
        {
            int hit = random.Next(1,51);
            int direction = 1;

            bool exit = false;

            Task.Factory.StartNew(() =>
            {
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
                exit = true;
            });

            int pause = random.Next(1, 15);

            while (!exit)
            {
                DrawHitLine(hit);

                hit += direction;

                if (hit == 51 || hit == 0)
                    direction *= -1;

                Thread.Sleep(pause);
            }

            if (hit > 25)
            {
                hit = 50 - hit;
            }

            Console.WriteLine();
            Console.WriteLine(hit * 4);
        }

        private static void ShowHealth(int health, int max_health)
        {
            double health_percent = (double) health / (double) max_health;

            ConsoleColor color;
            if (health_percent <= 0.25)
                color = ConsoleColor.Red;
            else if (health_percent < 0.5)
                color = ConsoleColor.DarkYellow;
            else
                color = ConsoleColor.Green;

            string health_bar = "";
            int size = 12;
            health_bar += "[";
            for (int i = 0; i < size; i++)
            {
                if (i < health_percent * size)
                    health_bar += "♥";
                else
                    health_bar += " ";
            }
            health_bar += "]";

            PrintLine(health_bar, AlignPrint.Left, color);
            PrintLine($"{health} / {max_health}", AlignPrint.Left, color);

            Console.ResetColor();
        }

        private static void ShowMonsterInfo(Monster monster)
        {
            PrintLine($"\n{monster.GetName()} [{monster.GetLevel()} Lv]", AlignPrint.Left);
            ShowHealth(monster.GetHealth(), monster.GetMaxHealth());
            PrintLine($"[Armor] : {monster.GetArmor()}", AlignPrint.Left);
            PrintLine($"[Strength] : {monster.GetStrength()}", AlignPrint.Left);
            PrintLine($"[Energy] : {monster.GetEnergy()}", AlignPrint.Left);
            PrintLine($"[Experience Points] : {monster.GetExperiencePoints()}", AlignPrint.Left);
        }

        private static void ShowPlayerInfo(Player player)
        {
            PrintLine($"\n{player.GetName()} [{player.GetLevel()} Lv]", AlignPrint.Left);
            ShowHealth(player.GetHealth(), player.GetMaxHealth());
            PrintLine($"[Strength] : {player.GetStrength()}", AlignPrint.Left);
            PrintLine($"[Agility] : {player.GetAgility()}", AlignPrint.Left);
            PrintLine($"[Endurance] : {player.GetEndurance()}", AlignPrint.Left);
            PrintLine($"[Energy] : {player.GetEnergy()}", AlignPrint.Left);
            PrintLine($"[Experience Points] : {player.GetExperiencePoints()}", AlignPrint.Left);
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
        }
    }
}
