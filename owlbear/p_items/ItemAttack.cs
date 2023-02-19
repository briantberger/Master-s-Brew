using System;
namespace Items
{
    /*
     * Represents the attack of an item. An items attack is defined by its
     * attack die, the number of times that die is rolled, its hit bonus,
     * and its attack bonus.
     * 
     * For example, the "Staff" melee weapon in DnD 5e would have the following
     * attack:
     * Hit Bonus: +4, Attack: 1d6+2.
     * This means that your hit roll of a d20 would have +4, and the damage of
     * the attack would be computed by 1 roll of a 6 sided dice, plus two points
     * of damage regardless of the roll. 
     */
	public class ItemAttack : ItemAction
	{
        //die used to roll for attack 
        private int m_attackDie;
        //number of times attack die is rolled
        private int m_rollCount;
        //bonus to d20 used to roll for hit
        private int m_hitBonus;
        //bonus to attack die rolls
        private int m_attackBonus;

        public ItemAttack(string name, int attackDie, int rollCount,
                          int hitBonus, int attackBonus) : base (name)
		{
            m_attackDie = attackDie;
            m_rollCount = rollCount;
            m_hitBonus = hitBonus;
            m_attackBonus = attackBonus;
		}


        public int AttackDie { get => m_attackDie; set => m_attackDie = value; }
        public int RollCount { get => m_rollCount; set => m_rollCount = value; }
        public int HitBonus { get => m_hitBonus; set => m_hitBonus = value; }
        public int AttackBonus { get => m_attackBonus;
                                 set => m_attackBonus = value; }

        /*
         * EFFECTS : returns roll for Hit and damage roll in a Tuple
         */
        public Tuple<int, int> PerformAttack()
        {
            return new Tuple<int, int>(0, 0);
        }
    }
}

