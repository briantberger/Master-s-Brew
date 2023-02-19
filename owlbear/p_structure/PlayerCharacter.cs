using System;
using Items;

namespace Structure
{
    /// <summary>
    /// Represents the Player Character. This is the main point of contact
    /// between the front end and the rest of the program. 
    /// </summary>
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
            charHp      = new HitPoints(charClasses.getHitDie(),
                                        charAbi.getModifier("con"));
        }


        /// <summary>
        /// <para>MODIFIES: this</para>
        /// <para>EFFECTS : attempts to add item to character Inventory</para>
        /// </summary>
        /// <param name="item"></param>
        public void AddItemToInventory(BasicItem item)
        {
            // STUB
        }

        /// <summary>
        /// <para>MODIFIES: this</para>
        /// <para>EFFECTS : attempts to remove item from Inventory</para>
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItemFromInventory(BasicItem item)
        {
            // STUB
        }



        // TODO: I'm not sure equip stuff should be at this level - seems
        //       like something that should be handled in Inventory

        //public bool EquipItem(BasicItem item)
        //{
        //    // STUB
        //    return false;
        //}
        //
        //public void UnequipItem(BasicItem item)
        //{
        //    // STUB
        //}

        /* 
         * NOTE: 
         * Methods from old version of the program that aren't coming through:
         * - different methods for equipping/unequipping
         * - "using" an item (I think this behaviour should be handled in 
         *      Inventory
         * - There's a few methods used in data persistence I'm electing to not
         *      really think about too much yet. 
         */


        ///<summary>
        /// Represents a characters hitPoints with max HP and current HP.
        ///</summary>
        private class HitPoints
        {
            private int maxHp;
            private int currHp;

            // TODO: probably need two constructors (or one with a switch)
            // because you can either take the average of the hit die or roll
            // for it.

            public HitPoints(int[] hitDie, int conMod)
            {
                maxHp  = generateMaxHp(hitDie, conMod);
                currHp = maxHp;
            }


            /// <summary>
            /// <para>MODIFIES: this</para>
            /// <para>EFFECTS : alters hit points by amount, to be no less than
            /// 0 and no greater than maxHp.</para>
            /// </summary>
            /// <param name="amount"></param>
            public void ModifyHitPoints(int amount)
            {
                // STUB
            }

            /// <summary>
            /// <para>MODIFIES: this</para>
            /// <para>EFFECTS : increases Max HP by a random integer from the
            /// class' hit die.</para>
            /// </summary>
            /// <param name="hitDie"></param>
            public void IncreaseMaxHitPointsRoll(int hitDie)
            {
                // STUB
            }

            /// <summary>
            /// <para>MODIFIES: this</para>
            /// <para>EFFECTS : increases Max HP by the average of the class'
            /// hit die.</para>
            /// </summary>
            /// <param name="hitDie"></param>
            public void IncreaseMaxHitPointsAverage(int hitDie)
            {
                // STUB
            }

            /// <summary>
            /// EFFECTS : from the array of hitDie, generates maximum HP of
            /// character.
            /// </summary>
            /// <param name="hitDie"></param>
            /// <param name="conMod"></param>
            /// <returns></returns>
            private int generateMaxHp(int[] hitDie, int conMod)
            {
                // STUB
                return 0;
            }
        }
    }
}