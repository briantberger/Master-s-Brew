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
            try
            {
                CharInv.AddItemToInventory(item);
            } catch (Exception e)
            {
                // TODO: update this when exception is properly defined
                throw;
            }
        }

        /// <summary>
        /// <para>MODIFIES: this</para>
        /// <para>EFFECTS : attempts to remove item from Inventory</para>
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItemFromInventory(BasicItem item)
        {
            try
            {
                CharInv.RemoveItemFromInventory(item);
            } catch (Exception e)
            {
                // TODO: update this when exception is properly defined
                throw;
            }
        }


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
                currHp += amount;

                if (currHp > maxHp)
                {
                    currHp = maxHp;
                    return;
                }

                if (currHp < 0)
                {
                    currHp = 0;
                    return;
                }

            }

            /// <summary>
            /// <para>MODIFIES: this</para>
            /// <para>EFFECTS : increases Max HP by a random integer from the
            /// class' hit die.</para>
            /// </summary>
            /// <param name="hitDie"></param>
            public void IncreaseMaxHitPointsRoll(int hitDie)
            {
                Random rnd = new Random();
                maxHp += rnd.Next(1, hitDie + 1);
            }

            /// <summary>
            /// <para>MODIFIES: this</para>
            /// <para>EFFECTS : increases Max HP by the average of the class'
            /// hit die.</para>
            /// </summary>
            /// <param name="hitDie"></param>
            public void IncreaseMaxHitPointsAverage(int hitDie)
            {
                maxHp += (1 + hitDie) / 2;
            }

            // TODO: figure out why we even need this
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