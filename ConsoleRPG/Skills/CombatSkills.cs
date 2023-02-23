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
}
