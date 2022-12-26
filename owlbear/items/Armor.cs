using System;


namespace Items
{
    // Represents a piece of Armor with all basic item properties, 
    // armor class override and armor class bonus.
    public class Armor : BasicItem
    {
        int m_AC_Over;
        int m_AC_Bonus;

        public Armor(string n, string d, int w, int v, int ac_o, int ac_b) : base(n, d, w, v)
        {
            //Armor-specific properties
            m_AC_Over  = ac_o;
            m_AC_Bonus = ac_b;
        }

        public int AC_Over  { get => m_AC_Over;  set => m_AC_Over = value; }
        public int AC_Bonus { get => m_AC_Bonus; set => m_AC_Bonus = value; }
    }
}