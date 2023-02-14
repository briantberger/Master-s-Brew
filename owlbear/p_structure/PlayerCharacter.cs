using System;
using Items;

namespace Structure
{
    /*
    Represents the Player Character. Assumes a level 1 character. 
    */
    public class PlayerCharacter
    {

        private AbilityScores charAbi;
        private Inventory charInv;
        private CharacterClasses charClasses;
        private HitPoints charHp;


        public PlayerCharacter()
        {
            charAbi     = new AbilityScores();
            charInv     = new Inventory(charAbi.getScore("str"));
            charClasses = new CharacterClasses();
            charHp      = new HitPoints(charClasses.getHitDie(), charAbi.getModifier("con"));
        }


        /*
         * MODIFIES: this
         * EFFECTS : attempts to add an item to charInv.
         */
        public void addItemToInventory(BasicItem item)
        {
            // STUB
        }

        /*
         * MODIFIES: this
         * EFFECTS : Removes item from charInv. If item is also equipped, 
         *           unequips the item. 
         */
        public void removeItemFromInventory(BasicItem item)
        {
            // STUB
        }

        /*
         * MODIFIES: this
         * EFFECTS : Equips item to character and returns true. If item can't 
         *           be equipped, returns false. 
         *           
         * TODO: in the old version of this program there were three methods
         *       for equipping the different types of items. I feel like it
         *       should be doable with just one.
         */
        public Boolean equipItem(BasicItem item)
        {
            // STUB
            return false;
        }

        /*
         * MODIFIES: this
         * EFFECTS : Unequips item from character equipment.
         * 
         * TODO: old version uses index based system and again, three different
         *       methods depending on the type of item. 
         */
        public void unequipItem(BasicItem item)
        {
            // STUB
        }

        /* 
         * NOTE: 
         * Methods from old version of the program that aren't coming through:
         * - different methods for equipping/unequipping
         * - "using" an item (I think this behaviour should be handled in Inventory
         * - There's a few methods used in data persistence I'm electing to not
         *      really think about too much yet. 
         */

        private class HitPoints
        {
            private int maxHp;
            private int currHp;

            // TODO: probably need two constructors (or one with a switch)
            // because you can either take the average of the hit die or roll
            // for it.

            public HitPoints(int hitDie, int conMod)
            {
                maxHp  = (int) Math.Ceiling((1.0 + hitDie) / 2);
                currHp = maxHp;
            }


            /*
             * MODIFIES: this
             * EFFECTS : adds amount to currHp. If amount is negative and 
             *           resulting currHp would be negative, sets currHp to 0
             *           instead. If amount is positive and resulting currHp 
             *           would be greater than maxHp, sets currHp to maxHp.
             */
            public void modifyHitPoints(int amount)
            {
                // STUB
            }
        }
    }
}