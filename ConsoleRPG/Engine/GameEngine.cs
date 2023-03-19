using System;
using System.Threading;
using System.Threading.Tasks;

using ConsoleRPG.Creatures.Heros;
using ConsoleRPG.Creatures.NPC;

using static ConsoleRPG.Utils.Generator;
using static ConsoleRPG.Utils.GameGraphics;
using static ConsoleRPG.Utils.InputOutput;
using static ConsoleRPG.Utils.Resources;

using ConsoleRPG.Creature;
using ConsoleRPG.Items;


namespace ConsoleRPG.Engine
{
    internal class GameEngine
    {
        private Player GamePlayer;

        public Monster GetMonster()
        {
            /* This function generate Monster by Player characteristics */
            string name = GenerateName();
            int level = RandomNumber(GamePlayer.Level, GamePlayer.Level + 2);
            int health = RandomNumber(GamePlayer.MaxHealth - 100, GamePlayer.MaxHealth);
            int max_health = RandomNumber(health, health + 100);
            int energy = RandomNumber(200, 500);
            int strength = RandomNumber(GamePlayer.Strength - 20, GamePlayer.Strength - 10);
            int expireance_points = RandomNumber(10, 200);

            Monster monster = new Monster(name, level, health, max_health, strength, energy, expireance_points);

            for (int i = 1; i < 4; i++)
            {
                if (RandomNumber(0, 3) == 1)
                    monster.PutAwayArmor((ArmorType)i, GetRandomArmor(level, i + 4));
            }

            if (RandomNumber(0, 4) == 4)
                monster.SetWeapon(GetRandomWeapon(level, RandomNumber(1,5)));

                return monster;
        }

        public void CreatePlayer(string name, int type)
        {
            /* This function create Player with some type and name */ 
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

            for (int i = 0; i < 4; i++)
                GamePlayer.PutAwayArmor((ArmorType)i, GetRandomArmor(GamePlayer.Level, i + 4));

            GamePlayer.SetWeapon(GetRandomWeapon(GamePlayer.Level, RandomNumber(1, 4)));
        }

        private Armor GetRandomArmor(int creature_level, int type)
        {
            string name = GenerateArmorName((IthemType)type, (IthemRank) RandomNumber(0,2));
            int level = RandomNumber(creature_level, creature_level+2);
            int armor_points = RandomNumber(level*50, level*60);

            return new Armor(name, level, armor_points);
        }

        private Weapon GetRandomWeapon(int creature_level, int weapon_type)
        {
            string name = GenerateWeaponName((IthemType) weapon_type-1);
            int level = RandomNumber(creature_level, creature_level + 2);
            int damage = RandomNumber(level * 70, level * 80);

            switch (weapon_type)
            {
                case 1:
                    return new Sword(name, level, damage);
                case 2:
                    return new Hammer(name, level, damage);
                case 3:
                    return new Axe(name, level, damage);
                case 4:
                    return new Spears(name, level, damage);
                default:
                    return null;
            }
        }

        public string NewArmor()
        {
            int type = RandomNumber(4,7);
            Armor armor = GetRandomArmor(GamePlayer.Level, type);
            GamePlayer.PutAwayArmor((ArmorType)type, armor);
            return $"You picked [{armor.Name}] [{armor.Level} Lv.]";
        }

        public string NewWeapon()
        {
            int type = RandomNumber(1, 4);
            Weapon weapon = GetRandomWeapon(GamePlayer.Level, type);
            GamePlayer.SetWeapon(weapon);
            return $"You picked [{weapon.Name}] [{weapon.Level} Lv.] [{weapon.Damage}]";
        }

        private int PlayerHit()
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

            DrawHitBar(100);

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
            return hit * 2;
        }

        private BodyPart ChoseBodyPart()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 5);
            Print("Натисніть відповідну клавішу що вдарити монстра по відповідній частині тіла\n",AlignPrint.Center);
            Print("[H] Head    [B] Body    [L] Legs    [F] Feet\n", AlignPrint.Center);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.H:
                    return BodyPart.Head;
                case ConsoleKey.B:
                    return BodyPart.Body;
                case ConsoleKey.L:
                    return BodyPart.Legs;
                case ConsoleKey.F:
                    return BodyPart.Feet;
                default:
                    return BodyPart.Body;
            }
        }

        public int Battle(Monster monster)
        {
            Console.Clear();

            int player_hit;
            int monster_hit;
            int random;
            BodyPart part;

            ShowPlayerInfo(GamePlayer);
            ShowMonsterInfo(monster);

            PrintByCords("Натисніть будь-яку клавішу щоб продовжити...", (Console.WindowWidth - 40) / 2, Console.WindowHeight - 1);
            Console.ReadKey();

            while (GamePlayer.Health != 0 && monster.Health != 0)
            {   
                // Info before attack
                ShowPlayerInfo(GamePlayer);
                ShowMonsterInfo(monster);

                part = ChoseBodyPart();
                random = PlayerHit();
                player_hit = GamePlayer.HitMonster(monster, part, random);
                monster_hit = monster.HitPlayer(GamePlayer, (BodyPart)RandomNumber(0, 3));

                // Info After attack
                ShowPlayerInfo(GamePlayer);
                ShowMonsterInfo(monster);
                PrintByCords($"-{player_hit}", Console.WindowWidth * 2/3 + 3, (Console.WindowHeight - 2 - dragon.Length) / 2, ConsoleColor.Cyan);
                PrintByCords($"-{monster_hit}", GamePlayer.Name.Length + 20, 0, ConsoleColor.Red);

                PrintByCords("Натисніть будь-яку клавішу щоб продовжити...", (Console.WindowWidth - 40) / 2, Console.WindowHeight-1);
                Console.ReadKey();

                Console.Clear();
            }

            // Return Battle result (0 - Lose, 1 - Win)
            if (GamePlayer.Health == 0)
                return 0;
            else
            {
                GamePlayer.LevelUp();
                return 1;
            }
        }
    }
}
