using ConsoleRPG.Creature;
using ConsoleRPG.Creatures.Heros;
using static ConsoleRPG.Utils.Generator;

namespace ConsoleRPG.Creatures.NPC
{
    internal class Monster : BasePerson
    {
        public int HitPlayer(Player player, BodyPart part)
        {
            int damage = RandomNumber(Strength/2, Strength);

            // Weapon damage
            if (Weapons != null)
                damage = (int)((Strength * 0.2 + Weapons.Damage) * RandomNumber(0, 101) / 100);

            player.GetDamage(damage, part);

            return damage;
        }

        // Monster Class constructor
        public Monster(string name, int level, int health, int max_health, int strength, int energy, int experience_points) : base (name)
        {
            Level = level;
            Health = health;
            MaxHealth = max_health;
            Energy = energy;
            Strength = strength;
            ExperiencePoints = experience_points;
        }
    }
}
