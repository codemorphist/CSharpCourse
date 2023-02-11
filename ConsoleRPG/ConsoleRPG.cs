using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleRPG.Creatures.NPC;
using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Engine;

namespace ConsoleRPG
{
    internal class ConsoleRPG
    {
        private static Random random = new Random();
        private static GameEngine engine = new GameEngine();

        private static string InputValue(string text)
        {
            // This function return inputed by user value
            Console.Write(text);    
            return Console.ReadLine();
        }

        private static int InputInt(string text)
        {
            // This function return inputed by user integer
            return Convert.ToInt32(InputValue(text));
        }

        private static void DrawHitLine(int len)
        {
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2 - 1, 0);

            for (int i = 0; i < 50; i++)
            {
                if (i == len)
                    Console.Write("<*>");
                else
                    Console.Write(" ");
            }
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

            if (health_percent <= 0.25)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (health_percent < 0.5)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            int size = 12;
            Console.Write("\t[");
            for (int i = 0; i < size; i++)
            {
                if (i < health_percent * size)
                 Console.Write("♥");
                else
                 Console.Write(" ");
            }
            Console.WriteLine("]");
            Console.WriteLine($"\t{health} / {max_health}");

            Console.ResetColor();
        }

        private static void ShowMonsterInfo(Monster monster)
        {
            Console.WriteLine("\t" + monster.GetName());
            ShowHealth(monster.GetHealth(), monster.GetMaxHealth());
            Console.WriteLine($"\t[Armor] : {monster.GetArmor()} ⛨");
            Console.WriteLine($"\t[Strength] : {monster.GetStrength()} ⚔");
            Console.WriteLine($"\t[Energy] : {monster.GetEnergy()} 🗲");
            Console.WriteLine($"\t[Experience Points] : {monster.GetExperiencePoints()} ✪");
        }

        private static void ShowPlayerInfo(Player player)
        {
            Console.WriteLine("\t" + player.GetName());
            ShowHealth(player.GetHealth(), player.GetMaxHealth());
            Console.WriteLine($"\t[Strength] : {player.GetStrength()} ⚔");
            Console.WriteLine($"\t[Energy] : {player.GetEnergy()} 🗲");
            Console.WriteLine($"\t[Experience Points] : {player.GetExperiencePoints()} ✪");
        }

        static void Main(string[] args)
        {
            // Enable support Unicode input and output
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Player player = new Tank("Aaron");
            Monster monster = engine.GetMonster(player);

            ShowPlayerInfo(player);

            Console.WriteLine();

            ShowMonsterInfo(monster);
        }
    }
}
