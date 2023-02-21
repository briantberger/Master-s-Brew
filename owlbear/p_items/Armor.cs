using System;
using Items.Properties;


namespace Items
{
    /// <summary>
    /// Represents a piece of Armor with all basic item properties, armor class
    /// override and armor class bonus.
    /// </summary>
    public class Armor : BasicItem, Equippable
    {
        int m_AC_Over;
        int m_AC_Bonus;
        bool m_equipped;

        public Armor(string name, string desc, double weight, double value,
                     int ac_override, int ac_bonus) :
                     base(name, desc, weight, value, false)
        {
            m_AC_Over  = ac_override;
            m_AC_Bonus = ac_bonus;
            m_equipped = false;
        }

        public int AC_Over  { get => m_AC_Over;  set => m_AC_Over = value; }
        public int AC_Bonus { get => m_AC_Bonus; set => m_AC_Bonus = value; }

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
    }
}