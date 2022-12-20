using System;


namespace Items
{
    // Represents a piece of Armor with all basic item properties, 
    // armor class override and armor class bonus.
    public class Armor : BasicItem
    {
        int AC_Over;
        int AC_Bonus;

        public Armor(string n, string d, int w, int v, int ac_o, int ac_b) : base(n, d, w, v)
        {
            //Armor-specific properties
            AC_Over = ac_o;
            AC_Bonus = ac_b;
        }


    }
}