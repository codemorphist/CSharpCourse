using System;

using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;

using static ConsoleRPG.Utils.InputOutput;
using static ConsoleRPG.Utils.Generator;
using static ConsoleRPG.Utils.Resources;
using System.Runtime.InteropServices;
using ConsoleRPG.Creature;
using ConsoleRPG.Items;

namespace ConsoleRPG.Utils
{
    static class GameGraphics
    {
        public static void DrawGameBanner()
        {
            string[] banner =
            {
                "                                                                                  ,-.----.                ",
                "  ,----..                                             ,--,             ,-.----.   \\    /  \\    ,----..    ",
                " /   /   \\                                          ,--.'|             \\    /  \\  |   :    \\  /   /   \\   ",
                "|   :     :  ,---.        ,---,              ,---.  |  | :             ;   :    \\ |   |  .\\ :|   :     :  ",
                ".   |  ;. / '   ,'\\   ,-+-. /  | .--.--.    '   ,'\\ :  : '             |   | .\\ : .   :  |: |.   |  ;. /  ",
                ".   ; /--` /   /   | ,--.'|'   |/  /    '  /   /   ||  ' |      ,---.  .   : |: | |   |   \\ :.   ; /--`   ",
                ";   | ;   .   ; ,. :|   |  ,\" ' |  :  /`./ .   ; ,. :'  | |     /     \\ |   |  \\ : |   : .   /;   | ;  __  ",
                "|   : |   '   | |: :|   | /  | |  :  ;_   '   | |: :|  | :    /    /  ||   : .  / ;   | |`-' |   : |.' .' ",
                ".   | '___'   | .; :|   | |  | |\\  \\    `.'   | .; :'  : |__ .    ' / |;   | |  \\ |   | ;    .   | '_.' : ",
                "'   ; : .'|   :    ||   | |  |/  `----.   \\   :    ||  | '.'|'   ;   /||   | ;\\  \\:   ' |    '   ; : \\  | ",
                "'   | '/  :\\   \\  / |   | |--'  /  /`--'  /\\   \\  / ;  :    ;'   |  / |:   ' | \\.':   : :    '   | '/  .' ",
                "|   :    /  `----'  |   |/     '--'.     /  `----'  |  ,   / |   :    |:   : :-'  |   | :    |   :    /   ",
                " \\   \\ .'           '---'        `--'---'            ---`-'   \\   \\  / |   |.'    `---'.|     \\   \\ .'    ",
                "  `---`                                                        `----'  `---'        `---`      `---`      "
            };

            PrintArrayByCords(banner, (Console.WindowWidth - MaxLenInStringArray(banner)) / 2, 5);
        }

        public static void DrawMenuBanner()
        {
            string[] banner = 
            {
                " _______  _______  __    _  _______  _______  ___      _______  ______    _______  _______ ",
                "|       ||       ||  |  | ||       ||       ||   |    |       ||    _ |  |       ||       |",
                "|       ||   _   ||   |_| ||  _____||   _   ||   |    |    ___||   | ||  |    _  ||    ___|",
                "|       ||  | |  ||       || |_____ |  | |  ||   |    |   |___ |   |_||_ |   |_| ||   | __ ",
                "|      _||  |_|  ||  _    ||_____  ||  |_|  ||   |___ |    ___||    __  ||    ___||   ||  |",
                "|     |_ |       || | |   | _____| ||       ||       ||   |___ |   |  | ||   |    |   |_| |",
                "|_______||_______||_|  |__||_______||_______||_______||_______||___|  |_||___|    |_______|"
            };

            PrintArrayByCords(banner, (Console.WindowWidth - MaxLenInStringArray(banner)) / 2, 3);
        }

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
            PrintByCords("0", (Console.WindowWidth - 50) / 2 + 50, Console.WindowHeight / 2 + 1);
        }

        private static ConsoleColor GetColor(int value, int max_value)
        {
            double value_percent = (double)value / (double)max_value;
            if (value_percent <= 0.25)
                return ConsoleColor.Red;
            else if (value_percent < 0.5)
                return ConsoleColor.DarkYellow;
            else
                return ConsoleColor.Green;
        }

        private static string ShowHealth(int health, int max_health)
        {
            double health_percent = (double)health / (double)max_health;

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

            return health_bar;
        }

        private static void ShowArmor(Armor[] armors, int x, int y, int space)
        {
            if (armors == null) 
                return;

            if (armors[0] != null)
                PrintByCords("[H]", x, y,   GetColor(armors[0].ArmorPoints, armors[0].MaxArmorPoints));
            if (armors[1] != null)
                PrintByCords("[C]", x, y+space, GetColor(armors[1].ArmorPoints, armors[1].MaxArmorPoints));
            if (armors[2] != null)
                PrintByCords("[L]", x, y+2*space, GetColor(armors[2].ArmorPoints, armors[2].MaxArmorPoints));
            if (armors[3] != null)
                PrintByCords("[B]", x, y+3*space, GetColor(armors[3].ArmorPoints, armors[3].MaxArmorPoints));
        }

        private static void ShowWeapon(Weapon weapon, int x, int y)
        {
            if (weapon != null)
                PrintByCords($"{weapon.Name} [{weapon.Damage}]", x, y);
        }

        public static void ShowMonsterInfo(Monster monster)
        {
            int y = (Console.WindowHeight - 2 - dragon.Length) / 2;
            Console.SetCursorPosition(0, y);
            Print($"{monster.Name} [{monster.Level} Lv]\n", AlignPrint.Center);
            Print($"{ShowHealth(monster.Health, monster.MaxHealth)}", AlignPrint.Center, GetColor(monster.Health, monster.MaxHealth));
            PrintArt(dragon, (Console.WindowWidth - MaxLenInStringArray(dragon)) / 2, y+2);
            ShowArmor(monster.Armors, (Console.WindowWidth + MaxLenInStringArray(dragon)) / 2 + 5, y+2, (int)(dragon.Length / 4));
            if (monster.Weapons != null)
                ShowWeapon(monster.Weapons, (Console.WindowWidth - monster.Weapons.Name.Length) / 2, y + 2 + dragon.Length);
        }

        public static void ShowPlayerInfo(Player player)
        {
            Console.SetCursorPosition(0,0);
            Print($"{player.Name} [{player.Level} Lv]", AlignPrint.Left);
            Print($"\n{ShowHealth(player.Health, player.MaxHealth)}", AlignPrint.Left, GetColor(player.Health, player.MaxHealth));
            Print($"\n[STR] {player.Strength}", AlignPrint.Left);
            Print($"\n[ENR] {player.Energy}", AlignPrint.Left);
            Print($"\n[AGL] {player.Agility}", AlignPrint.Left);
            Print($"\n[END] {player.Endurance}", AlignPrint.Left);
            Print($"\n[EXP] {player.ExperiencePoints}", AlignPrint.Left);
            ShowArmor(player.Armors, player.Name.Length + 12, 0, 2);
            ShowWeapon(player.Weapons, 0, 8);
        }

        public static void DeadScreen()
        {
            Console.Clear();
            string[] dead = {
                            "     Y O U  L O S E        ,--.",
                            "                          {    }",
                            "                          K,   }",
                            "                         /  `Y`",
                            "                    _   /   /",
                            "                   {_'-K.__/",
                            "                     `/-.__L._",
                            "                     /  ' /`\\_}",
                            "                    /  ' /     ",
                            "            ____   /  ' /",
                            "     ,-'~~~~    ~~/  ' /_",
                            "   ,'             ``~~~%%',",
                            "  (                     %  Y",
                            " {                      %% I",
                            "{      -                 %  `.",
                            "|       ',                %  )",
                            "|        |   ,..__      __. Y",
                            "|    .,_./  Y ' / ^Y   J   )|",
                            "\\           |' /   |   |   ||",
                            " \\          L_/    . _ (_,.'(",
                            "  \\,   ,      ^^\" \" ' / |   )",
                            "    \\_  \\          /,L]     /",
                            "      '-_`-,       ` `   ./`",
                            "         `-(_            )",
                            "             ^^\\..___,.--`"};

            PrintArrayByCords(dead, (Console.WindowWidth - MaxLenInStringArray(dead)) / 2, 
                (Console.WindowHeight - dead.Length) / 2);
        }

        public static void WinScreen()
        {
            Console.Clear();

            string[] win = {
                "          *_   _   _   _   _   _ *",
                "          | `_' `-' `_' `-' `_' `|        ",
                "  ^       |                      |       ^",
                "  |       |     Y O U  W I N     |       |",
                "  |  (*)  |_   _   _   _   _   _ |  \\^/  |",
                "  | _<\">_ | `_' `-' `_' `-' `_' `| _(#)_ |",
                " o+o \\ / \\0                      0/ \\ / (=)",
                "  0'\\ ^ /\\/                      \\/\\ ^ /`0",
                "    /_^_\\ |                      | /_^_\\",
                "    || || |                      | || ||",
                "    d|_|b_T______________________T_d|_|b"
            };

            PrintArrayByCords(win, (Console.WindowWidth - MaxLenInStringArray(win)) / 2, 
                (Console.WindowHeight - win.Length) / 2);
        }
    }
}
