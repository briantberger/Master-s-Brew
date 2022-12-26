using System;


namespace Items
{
    // Represents a MagicalTrinket all basic item properties, 
    // attunement status, and if the item need be attuned at all to use its ability.
    public class MagicItem : BasicItem
    {
        private bool m_attunedRequired;
        private bool m_attunedStatus;


        //maybe these should act more like potions with a list of effects they can have? 
        //like if it's just a written effect whatever but if it's something like 
        //having it equipped raises your armor class it should be able to do that?
        //utility class might be useful.

        public MagicItem(string n, string d, int w, int v, bool a_r, bool a_s) : base(n, d, w, v)
        {

            //MagicItem specific properties
            m_attunedRequired = a_r;
            m_attunedStatus   = a_s;
        }

        public bool AttunedStatus   { get => m_attunedStatus;   set => m_attunedStatus   = value; }
        public bool AttunedRequired { get => m_attunedRequired; set => m_attunedRequired = value; }
    }
}