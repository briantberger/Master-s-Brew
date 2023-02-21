using System;


namespace Structure
{
    /// <summary>
    /// Represents the ability scores of a player character.
    /// </summary>
    public class AbilityScores
    {
        private int strSc;  
        private int dexSc;  
        private int conSc;  
        private int intSc;  
        private int wisSc;  
        private int chaSc;  

        /// <summary>
        /// Constructor for randomly choosing ability scores. Simulates rolling
        /// 4 dice and dropping the lowest number, resulting in scores that may
        /// be between 3 and 18. 
        /// </summary>
        public AbilityScores()
        {
            Random rnd = new Random();

            strSc = rnd.Next(3, 19);
            dexSc = rnd.Next(3, 19);
            conSc = rnd.Next(3, 19);
            intSc = rnd.Next(3, 19);
            wisSc = rnd.Next(3, 19);
            chaSc = rnd.Next(3, 19);
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
        public AbilityScores(int strIn, int dexIn, int conIn, int intIn, int wisIn, int chaIn)
        {
            strSc = strIn;
            dexSc = dexIn;
            conSc = conIn;
            intSc = intIn;
            wisSc = wisIn;
            chaSc = chaIn;
        } 

        /// <summary>
        /// EFFECTS : returns ability score corresponding to stat. 
        /// </summary>
        /// <param name="stat"></param>
        /// <returns></returns>
        public int getScore(string stat)
        {
            switch (stat)
            {
                case "str":
                    return strSc;
                case "dex":
                    return dexSc;
                case "con":
                    return conSc;
                case "int":
                    return intSc;
                case "wis":
                    return wisSc;
                case "cha":
                    return chaSc;
                default:
                    return -1;
            }
        }

        /// <summary>
        /// EFFECTS : returns modifier for selected ability score
        /// </summary>
        /// <param name="select"></param>
        /// <returns></returns>
        public int getModifier(string select)
        {
            int score = getScore(select);
            return generateModifier(score);
        }

        /// <summary>
        /// EFFECTS : generates ability score modifier.
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        private int generateModifier(int score)
        {
            if (score >= 10)
            {
                return (score - 10) / 2;
            }
            else
            {
                return ((score - 1) - 10) / 2;
            }
        }

        /// <summary>
        /// MODIFIES: this
        /// EFFECTS : sets ability score specified by select to val.
        /// </summary>
        /// <param name="select"></param>
        /// <param name="val"></param>
        public void setScore(string select, int val)
        {
            switch (select)
            {
                case "str":
                    strSc = val;
                    break;
                case "dex":
                    dexSc = val;
                    break;
                case "con":
                    conSc = val;
                    break;
                case "int":
                    intSc = val;
                    break;
                case "wis":
                    wisSc = val;
                    break;
                case "cha":
                    chaSc = val;
                    break;
                default:
                    break;
                    //do nothing.
                    //there should probably be some exception handling here 
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is AbilityScores scores &&
                   strSc == scores.strSc &&
                   dexSc == scores.dexSc &&
                   conSc == scores.conSc &&
                   intSc == scores.intSc &&
                   wisSc == scores.wisSc &&
                   chaSc == scores.chaSc;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(strSc, dexSc, conSc, intSc, wisSc, chaSc);
        }
    }
}