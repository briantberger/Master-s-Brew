using System;


namespace Items
{
    /*
    This has to be a pretty robust class because potions can do a lot of different things in DND.
    I think the key thing is to focus on just making it so a potion can have however many effects
    and each effect is basically just a function in here. Like the potion just calls a bunch of 
    function pointers when it goes, I guess.
    */


    // TODO: Everything here - maybe leave for later.
    public class Potion : BasicItem
    {

        public Potion(string name, string desc, int weight, int value) :
            base(name, desc, weight, value, false)
        {
            //Potion-specific properties 
        }
    }
}