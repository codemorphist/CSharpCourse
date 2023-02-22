using System;
using System.Threading;
using System.Threading.Tasks;

using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;

using static ConsoleRPG.Utils.Generator;
using static ConsoleRPG.Utils.GameGraphics;
using static ConsoleRPG.Utils.InputOutput;

namespace ConsoleRPG.Engine
{
    internal class GameEngine
    {
        private Player GamePlayer;

        public Monster GetMonster()
        {
            /* This function generate Monster by Player characteristics */
            string name = GenerateName();
            int level = RandomNumber(GamePlayer.GetLevel(), GamePlayer.GetLevel() + 2);
            int health = RandomNumber(GamePlayer.GetHealth() - 100, GamePlayer.GetHealth());
            int max_health = RandomNumber(health, health + 100);
            int armor = RandomNumber(100, 500);
            int max_armor = RandomNumber(armor, armor + 100);
            int energy = RandomNumber(200, 500);
            int strength = RandomNumber(GamePlayer.GetStrength() - 300, GamePlayer.GetStrength() - 200);
            int expireance_points = RandomNumber(10, 200);

            return new Monster(name, level, health, max_health,
                                armor, max_armor, strength, energy, expireance_points);
        }

        public void CreatePlayer(string name, int type)
        {
            /* This function return Player with some type and name */ 
            switch (type) 
            {
                case 1:
                    GamePlayer = new Barbarian(name);
                    break;
                case 2:
                    GamePlayer = new Tank(name);
                    break;
                case 3:
                    GamePlayer = new Bandit(name);
                    break;
                default: 
                    GamePlayer = null;
                    break;
            }
        }

        private int PlayerHit(int strength)
        {
            Console.Clear();

            int hit = RandomNumber(1, 50);
            int direction = 1;

            bool exit = false;

            Task.Factory.StartNew(() =>
            {
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
                exit = true;
            });

            int pause = 10;

            DrawHitBar(strength);

            while (!exit)
            {
                DrawHitLine(hit);

                hit += direction;

                if (hit == 51 || hit == 0)
                    direction *= -1;

                Thread.Sleep(pause);
            }

            if (hit > 25)
                hit = 50 - hit;

            Console.Clear();
            return (int) (strength * ((double) hit / 25));
        }

        private void DamageMonster(Monster monster)
        {
            if (GamePlayer.GetWeapon() != null)
            {
                GamePlayer.GetWeapon().UseWeapon(GamePlayer, monster);
            }
        }

        private void DamagePlayer(Monster monster)
        {   
        }

        public int Battle(Monster monster)
        {
            int player_hit;
            int monster_hit;

            Console.Clear();

            ShowPlayerInfo(GamePlayer);
            ShowMonsterInfo(monster);

            Print("Натисніть будь-яку клавішу щоб почати бій...", AlignPrint.Center);
            Console.ReadKey();

            while (GamePlayer.GetHealth() != 0 && monster.GetHealth() != 0)
            {
                Console.Clear();

                DamageMonster(monster);
                DamagePlayer(monster);

                Print($"\n[INFO] Монстр вдарив вас з силою ({0})\n", color: ConsoleColor.Red);
                ShowPlayerInfo(GamePlayer);

                Print($"\n\n[INFO] Ви завдали монстру удару з силою ({0})\n", color: ConsoleColor.Cyan);
                ShowMonsterInfo(monster);

                Print("Натисніть будь-яку клавішу щоб продовжити...", AlignPrint.Center);
                Console.ReadKey();
            }

            if (GamePlayer.GetHealth() == 0)
                return 0;
            else
                return 1;
        }
    }
}
