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

        private AbilityScores m_charAbi;
        private Inventory m_charInv;
        private CharacterClasses m_charClasses;
        private HitPoints m_charHp;

        private string m_name;

        /// <summary>
        /// Constructor for randomly generating ability scores
        /// </summary>
        public PlayerCharacter(CharacterClass charClass, string name)
        {
            m_charAbi     = new AbilityScores();
            m_charInv     = new Inventory(m_charAbi.getScore("str"));
            m_charClasses = new CharacterClasses(charClass);
            m_charHp      = new HitPoints(m_charClasses.getHitDie(),
                                        m_charAbi.getModifier("con"));
            m_name = name;
        }

        /// <summary>
        /// Constructor for manually inputting ability scores.
        /// </summary>
        /// <param name="strIn"></param>
        /// <param name="dexIn"></param>
        /// <param name="conIn"></param>
        /// <param name="intIn"></param>
        /// <param name="wisIn"></param>
        /// <param name="chaIn"></param>
        /// <param name="charClass"></param>
        public PlayerCharacter(int strIn, int dexIn, int conIn, int intIn,
                               int wisIn, int chaIn, CharacterClass charClass,
                               string name)
        {
            m_charAbi     = new AbilityScores(strIn, dexIn, conIn,
                                            intIn, wisIn, chaIn);
            m_charInv     = new Inventory(m_charAbi.getScore("str"));
            m_charClasses = new CharacterClasses(charClass);
            m_charHp      = new HitPoints(m_charClasses.getHitDie(),
                                        m_charAbi.getModifier("con"));
            m_name = name;
        }

        public AbilityScores CharAbi { get => m_charAbi;
                                        set => m_charAbi = value; }
        public Inventory CharInv     { get => m_charInv;
                                        set => m_charInv = value; }
        public CharacterClasses CharClasses { get => m_charClasses;
                                               set => m_charClasses = value; }
        public HitPoints CharHp { get => m_charHp; set => m_charHp = value; }

        public string Name { get => m_name; set => m_name = value; }


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
        public class HitPoints
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