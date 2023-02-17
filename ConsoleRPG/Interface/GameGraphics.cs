using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using static ConsoleRPG.Interface.InputOutput;
using static ConsoleRPG.Utils.Generator;

namespace ConsoleRPG.Interface
{
    static class GameGraphics
    {
        public static void DrawHitLine(int len)
        {
            string hitline = "[";

            ConsoleColor color;
            if (len >= 20 && len <= 30)
                color = ConsoleColor.Red;
            else if (len >= 10 && len <= 40)
                color = ConsoleColor.Yellow;
            else
                color = ConsoleColor.Green;

            for (int i = 0; i < 50; i++)
            {
                if (i == len)
                    hitline += "*";
                else
                    hitline += " ";
            }
            hitline += "]";

            PrintByCords(hitline, (Console.WindowWidth - hitline.Length) / 2, Console.WindowHeight / 2, color);
        }

        public static void DrawHitBar(int strength)
        {
            PrintByCords("Натисніть [Space] щоб завдати удару!", (Console.WindowWidth - 36) / 2, Console.WindowHeight / 2 - 2);
            PrintByCords("0", (Console.WindowWidth - 50) / 2 - 1, Console.WindowHeight / 2 + 1);
            PrintByCords($"{strength}", Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 + 1);
            PrintByCords("0", (Console.WindowWidth - 50) / 2 + 50, Console.WindowHeight / 2  + 1);
        }

        private static void ShowHealth(int health, int max_health)
        {
            double health_percent = (double)health / (double)max_health;

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
        }

        public static void ShowMonsterInfo(Monster monster)
        {
            PrintLine($"\n{monster.GetName()} [{monster.GetLevel()} Lv]", AlignPrint.Left);
            ShowHealth(monster.GetHealth(), monster.GetMaxHealth());
            PrintLine($"[Armor] : {monster.GetArmor()}", AlignPrint.Left);
            PrintLine($"[Strength] : {monster.GetStrength()}", AlignPrint.Left);
            PrintLine($"[Energy] : {monster.GetEnergy()}", AlignPrint.Left);
            PrintLine($"[Experience Points] : {monster.GetExperiencePoints()}", AlignPrint.Left);
        }

        public static void ShowPlayerInfo(Player player)
        {
            PrintLine($"\n{player.GetName()} [{player.GetLevel()} Lv]", AlignPrint.Left);
            ShowHealth(player.GetHealth(), player.GetMaxHealth());
            PrintLine($"[Strength] : {player.GetStrength()}", AlignPrint.Left);
            PrintLine($"[Agility] : {player.GetAgility()}", AlignPrint.Left);
            PrintLine($"[Endurance] : {player.GetEndurance()}", AlignPrint.Left);
            PrintLine($"[Energy] : {player.GetEnergy()}", AlignPrint.Left);
            PrintLine($"[Experience Points] : {player.GetExperiencePoints()}", AlignPrint.Left);
        }

        public static void DeadScreen()
        {
            Console.Clear();
            string[] dead = {
                            "You Lose!                     .___.",
                            "          /)               ,-^     ^-. ",
                            "         //               /           \\",
                            ".-------| |--------------/  __     __  \\-------------------.__",
                            "|WMWMWMW| |>>>>>>>>>>>>> | />>\\   />>\\ |>>>>>>>>>>>>>>>>>>>>>>:>",
                            "`-------| |--------------| \\__/   \\__/ |-------------------'^^",
                            "         \\\\               \\    /|\\    /",
                            "          \\)               \\   \\_/   /",
                            "                            |       |",
                            "                            |+H+H+H+|",
                            "                            \\       /",
                            "                             ^-----^"};

            PrintArrayByCords(dead, (Console.WindowWidth - MaxLenInStringArray(dead)) / 2, 
                (Console.WindowHeight - dead.Length) / 2);
        }

        public static void WinScreen()
        {
            Console.Clear();

            string[] win = {
                "|   |- - - - - - - - - - - - - - - - - - -|   |",
                "| O |                                     | O |",
                "|   |                                     |   |",
                "| O |                                     | O |",
                "|   |                                     |   |",
                "| O |                                     | O |",
                "|   |         ! Y O U   W I N !           |   |",
                "| O |                                     | O |",
                "|   |       P R E S S  A N Y  K E Y       |   |",
                "| O |       T O  C O N T I N U E . . .    | O |",
                "|   |                                     |   |",
                "| O |                                     | O |",
                "|   |                                     |   |",
                "| O |                                     | O |",
                "|   |                                     |   |",
                "| O |- - - - - - - - - - - - - - - - - - -| O |"
            };

            PrintArrayByCords(win, (Console.WindowWidth - MaxLenInStringArray(win)) / 2, 
                (Console.WindowHeight - win.Length) / 2);
        }
    }
}
