using System;


namespace Items
{
    // Represents a Weapon with all basic item properties,
    // attack die, attack roll count, hit die bonus and attack die bonus.
    public class Weapon : BasicItem, Equippable, Actionable
    {
        //die used to roll for attack 
        private int m_attackDie;
        //number of times attack die is rolled
        private int m_rollCount;
        //bonus to d20 used to roll for hit
        private int m_hitBonus;
        //bonus to attack die rolls
        private int m_attackBonus;
        //is the weapon equipped?
        private bool m_equipped;

        private int m_range;

        public Weapon(string n, string d, int w, int v, int ad, int rc, int hb, int ab) : base(n, d, w, v)
        {
            //Weapon-specific properties
            m_attackDie   = ad;
            m_rollCount   = rc;
            m_hitBonus    = hb;
            m_attackBonus = ab;
        }

        public int AttackDie   { get => m_attackDie;   set => m_attackDie   = value; }
        public int RollCount   { get => m_rollCount;   set => m_rollCount   = value; }
        public int HitBonus    { get => m_hitBonus;    set => m_hitBonus    = value; }
        public int AttackBonus { get => m_attackBonus; set => m_attackBonus = value; }

        // EQUIPPABLE INTERFACE
        public bool equipped { get => m_equipped; set => m_equipped = value; }

        // ACTIONABLE INTERFACE
        public int range { get => m_range; set => m_range = range; }
        public string[] tags => throw new NotImplementedException();

        public void equip()
        {
            equipped = true;
        }

        public void unequip()
        {
            equipped = false;
        }
    }
}