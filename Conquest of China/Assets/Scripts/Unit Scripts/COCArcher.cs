using TbsFramework.Units;

namespace TbsFramework.Example1
{
    public class COCArcher : MyUnit
    {
        protected override int Defend(Unit other, int damage)
        {
            var realDamage = damage;
            if (other is COCWarrior)
                realDamage *= 2;//Paladin deals double damage to archer.

            return realDamage - DefenceFactor;
        }
    }
}