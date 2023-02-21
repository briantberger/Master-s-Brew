using System;


namespace Items
{
    /// <summary>
    /// Represents a MagicItem with all BasicItem properties, an attunement
    /// requirement, and attunement status. MagicItems are Equippable and
    /// Actionable.
    /// </summary>
    public class MagicItem : BasicItem, Equippable, Actionable
    {
        private bool m_attunedRequired;
        private bool m_attunedStatus;

        private bool m_equipped;

        private int m_range;
        private ItemAction m_action;

        //TODO: I think we'll have the front end ask what the action of an
        //      item is before it gets made, so this constructor should be
        //      fine, but if it isn't, we'll figure something else out. 
        public MagicItem(string name, string desc, double weight, double value,
            bool attunedRequired, bool attunedStatus, ItemAction action) :
            base(name, desc, weight, value, false)
        {
            m_attunedRequired = attunedRequired;
            m_attunedStatus   = attunedStatus;
            m_equipped = false;
            m_action = action;
        }

        public bool AttunedStatus   { get => m_attunedStatus;   set => m_attunedStatus   = value; }
        public bool AttunedRequired { get => m_attunedRequired; set => m_attunedRequired = value; }

        // EQUIPPABLE INTERFACE
        public bool equipped { get => m_equipped; set => m_equipped = value; }
        public void equip()
        {
            equipped = true;
        }

        public void unequip()
        {
            equipped = false;
        }

        // ACTIONABLE INTERFACE 
        public int range { get => m_range; set => m_range = value; }
        public string[] tags => throw new NotImplementedException();
        public ItemAction action { get => m_action;
                                   set => m_action = value; }

        /*
        * EFFECTS : Performs action associated with weapon.
        * TODO: return type of method might need changing
        */
        public ItemAction DoAction()
        {
            // STUB
            return action;
        }
    }
}