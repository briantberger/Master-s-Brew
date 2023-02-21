using System;
namespace Structure
{
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
            maxHp = generateMaxHp(hitDie, conMod);
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

