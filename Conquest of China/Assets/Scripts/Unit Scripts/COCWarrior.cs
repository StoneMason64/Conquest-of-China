using TbsFramework.Units;

namespace TbsFramework.Example1
{
    public class COCWarrior : ChinaUnitDemo
    {
        protected override int Defend(Unit other, int damage)
        {
            var realDamage = damage;
            if (other is COCCavalry)
                realDamage *= 2;//Paladin deals double damage to archer.

            return realDamage - DefenceFactor;
        }
    }
}