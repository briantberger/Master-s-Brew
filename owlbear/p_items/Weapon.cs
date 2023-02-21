using System;


namespace Items
{
    /// <summary>
    /// Represents a Weapon with BasicItem properties and an attack.
    /// Weapons are Equippable and Actionable.
    /// </summary>
    public class Weapon : BasicItem, Equippable, Actionable
    {
        private bool m_equipped;

        private int m_range;

        private ItemAction m_action;

        
        public Weapon(string name, string desc, int weight, int value,
            ItemAttack attack) : base(name, desc, weight, value)
        {
            m_action = attack;
            m_equipped = false;
        }

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
        public int range { get => m_range; set => m_range = range; }
        public string[] tags => throw new NotImplementedException();
        public ItemAction action { get => m_action; set => m_action = value; }

        /*
         * EFFECTS : Performs action associated with weapon.
         * TODO: return type of method might need changing
         */
        public ItemAction DoAction()
        {
            // STUB
            // but honestly that might be all it needs
            return action;
        }

    }
}