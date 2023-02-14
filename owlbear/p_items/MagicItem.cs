using System;


namespace Items
{
    // Represents a MagicalTrinket all basic item properties, 
    // attunement status, and if the item need be attuned at all to use its ability.
    public class MagicItem : BasicItem, Equippable, Actionable
    {
        private bool m_attunedRequired;
        private bool m_attunedStatus;

        private bool m_equipped;

        private int m_range;

        public MagicItem(string n, string d, int w, int v, bool a_r, bool a_s) : base(n, d, w, v)
        {

            //MagicItem specific properties
            m_attunedRequired = a_r;
            m_attunedStatus   = a_s;
        }

        public bool AttunedStatus   { get => m_attunedStatus;   set => m_attunedStatus   = value; }
        public bool AttunedRequired { get => m_attunedRequired; set => m_attunedRequired = value; }

        // EQUIPPABLE INTERFACE
        public bool equipped { get => m_equipped; set => m_equipped = value; }

        // ACTIONABLE INTERFACE 
        public int range { get => m_range; set => m_range = value; }
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