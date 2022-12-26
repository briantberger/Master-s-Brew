using System;


namespace Items
{
    // Represents a Weapon with all basic item properties,
    // attack die, attack roll count, hit die bonus and attack die bonus.
    public class Weapon : BasicItem
    {
        //die used to roll for attack 
        private int attackDie;
        //number of times attack die is rolled
        private int rollCount;
        //bonus to d20 used to roll for hit
        private int hitBonus;
        //bonus to attack die rolls
        private int attackBonus;

        public Weapon(string n, string d, int w, int v, int ad, int rc, int hb, int ab) : base(n, d, w, v)
        {
            //Weapon-specific properties
            attackDie = ad;
            rollCount = rc;
            hitBonus = hb;
            attackBonus = ab;
        }

        public int getAttackDie()
        {
            return this.attackDie;
        }

        public int getRollCount()
        {
            return this.rollCount;
        }

        public int getHitBonus()
        {
            return this.hitBonus;
        }

        public int getAttackBonus()
        {
            return this.attackBonus;
        }

    }
}