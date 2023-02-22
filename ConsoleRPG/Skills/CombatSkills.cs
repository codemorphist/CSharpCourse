using ConsoleRPG.Creatures.NPC;

namespace ConsoleRPG.Skills
{
    interface ICombatSkill
    {
        string GetSkillName();
        void UseSkill(Monster monster);
    }

    abstract class CombatSkill
    {
        protected string SkillName;

        public string GetSkillName() => SkillName;

        public CombatSkill()
        {
            SkillName = this.GetType().Name;
        }
    }

    class ForceSprint : CombatSkill, ICombatSkill
    {
        public void UseSkill(Monster monster)
        {
            monster.SetHealth(monster.GetHealth() - 100);
        }

        public ForceSprint() : base() { }
    }

    class HyperHit : CombatSkill, ICombatSkill
    {
        public void UseSkill(Monster monster)
        {
            monster.SetHealth(monster.GetHealth() - 500);
        }

        public HyperHit() : base() { }
    }

    class HeavyHit : CombatSkill, ICombatSkill
    {
        public void UseSkill(Monster monster)
        {
            monster.SetHealth(monster.GetHealth() - 400);
        }

        public HeavyHit() : base() { }
    }
}
