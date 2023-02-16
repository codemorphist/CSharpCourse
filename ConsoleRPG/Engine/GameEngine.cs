﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;

using static ConsoleRPG.Utils.Generator;
using static ConsoleRPG.Interface.GameGraphics;
using static ConsoleRPG.Interface.InputOutput;

namespace ConsoleRPG.Engine
{
    internal class GameEngine
    {        
        public Monster GetMonster(Player player)
        {
            /* This function generaate Monster by Player characteristics */
            string name = GenerateName();
            int level = RandomNumber(player.GetLevel(), player.GetLevel() + 2);
            int health = RandomNumber(player.GetHealth() - 100, player.GetHealth() + 100);
            int max_health = RandomNumber(health, health + 500);
            int armor = RandomNumber(100, 500);
            int max_armor = RandomNumber(armor, armor + 100);
            int energy = RandomNumber(200, 500);
            int strength = RandomNumber(10, 100);
            int expireance_points = RandomNumber(10, 200);

            return new Monster(name, level, health, max_health,
                                armor, max_armor, strength, energy, expireance_points);
        }

        public Player CreatePlayer(string name, int type)
        {
            /* This function return Player with some type and name */ 
            switch (type) 
            {
                case 1:
                    return new Barbarian(name);
                case 2:
                    return new Tank(name);
                case 3:
                    return new Bandit(name);
                default: 
                    return null;
            }
        }

        private int PlayerHit(int strength)
        {
            Console.Clear();

            int hit = RandomNumber(1, 51);
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

        private void DamageMonster(ref Monster monster, int damage)
        {
            if (damage < 0) return;

            monster.SetHealth(monster.GetHealth() - damage);
        }

        private void DamagePlayer(ref Player player, int damage)
        {
            if (damage < 0) return;

            player.SetHealth(player.GetHealth() - damage);
        }

        public int Battle(Player player, Monster monster)
        {
            int player_hit;
            int monster_hit;

            while(player.GetHealth() != 0 && monster.GetHealth() != 0)
            {
                Console.Clear();

                player_hit = PlayerHit(player.GetStrength());
                monster_hit = RandomNumber(0, monster.GetStrength());

                DamageMonster(ref monster, player_hit);
                DamagePlayer(ref player, monster_hit);

                Print($"\n[INFO] Монстр вдарив вас з силою ({monster_hit})\n", color: ConsoleColor.Red);
                ShowPlayerInfo(player);

                Print($"\n\n[INFO] Ви завдали монстру удару з силою ({player_hit})\n", color: ConsoleColor.Cyan);
                ShowMonsterInfo(monster);

                Print("Натисніть будь-яку клавішу щоб продовжити...", AlignPrint.Center);
                Console.ReadKey();
            }

            if (player.GetHealth() == 0)
                return 0;
            else
                return 1;
        }
    }
}
